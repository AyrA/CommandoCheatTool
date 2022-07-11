using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CommandoCheatTool
{
    public partial class FrmComCheat : Form
    {
        private Process Proc = null;

        public FrmComCheat()
        {
            InitializeComponent();
            CbLevel.Items.AddRange(LevelNames.GetLevels());

            LoadIni();
        }

        private void Info(string Title, string Body)
        {
            MessageBox.Show(Body, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadIni()
        {
            var values = new CommandoIni();

            //Grenades
            TbGrenadeC.Value = values.Grenades;
            TbGrenadeX.Value = values.NapalmGrenades;
            TbGrenadeZ.Value = values.RemoteGrenades;

            //Status values
            TbHealth.Value = values.Health;
            TbLives.Value = values.Lives;
            TbScore.Value = values.Score;
            CbLevel.SelectedItem = LevelNames.GetLevel(values.CurrentLevel);

            //Items
            CbArmour.Checked = values.Armour;
            CbHelmet.Checked = values.Helmet;
            CbJetpack.Checked = values.Jetpack;

            //Levels
            CbDesert.Checked = values.UnlockedLevels.HasFlag(LevelType.Desert);
            CbIce.Checked = values.UnlockedLevels.HasFlag(LevelType.Ice);

            //Weapons
            CbGaussPistol.Checked = values.Weapons.HasFlag(WeaponType.GaussPistol);
            CbUzi.Checked = values.Weapons.HasFlag(WeaponType.Uzi);
            CbLaserPistol.Checked = values.Weapons.HasFlag(WeaponType.LaserPistol);
            CbRifle.Checked = values.Weapons.HasFlag(WeaponType.Rifle);
            CbShotgun.Checked = values.Weapons.HasFlag(WeaponType.Shotgun);
            CbMinigun.Checked = values.Weapons.HasFlag(WeaponType.Minigun);
            CbFlamer.Checked = values.Weapons.HasFlag(WeaponType.Flamer);
            CbMachinegun.Checked = values.Weapons.HasFlag(WeaponType.MachineGun);
            CbGaussRifle.Checked = values.Weapons.HasFlag(WeaponType.GaussRifle);
            CbRocketLauncher.Checked = values.Weapons.HasFlag(WeaponType.RocketLauncher);

        }

        private void SaveIni()
        {
            var ini = new CommandoIni
            {
                Weapons = WeaponType.None,
                UnlockedLevels = LevelType.None,

                Health = (int)TbHealth.Value,
                CurrentLevel = ((Level)CbLevel.SelectedItem).LevelNumber,
                Lives = (int)TbLives.Value,
                Score = (int)TbScore.Value,

                Armour = CbArmour.Checked,
                Helmet = CbHelmet.Checked,
                Jetpack = CbJetpack.Checked,

                Grenades = (int)TbGrenadeC.Value,
                NapalmGrenades = (int)TbGrenadeX.Value,
                RemoteGrenades = (int)TbGrenadeZ.Value
            };

            ini.UnlockedLevels |= CbDesert.Checked ? LevelType.Desert : LevelType.None;
            ini.UnlockedLevels |= CbIce.Checked ? LevelType.Ice : LevelType.None;

            ini.Weapons |= CbGaussPistol.Checked ? WeaponType.GaussPistol : WeaponType.None;
            ini.Weapons |= CbUzi.Checked ? WeaponType.Uzi : WeaponType.None;
            ini.Weapons |= CbLaserPistol.Checked ? WeaponType.LaserPistol : WeaponType.None;
            ini.Weapons |= CbRifle.Checked ? WeaponType.Rifle : WeaponType.None;
            ini.Weapons |= CbShotgun.Checked ? WeaponType.Shotgun : WeaponType.None;
            ini.Weapons |= CbMinigun.Checked ? WeaponType.Minigun : WeaponType.None;
            ini.Weapons |= CbFlamer.Checked ? WeaponType.Flamer : WeaponType.None;
            ini.Weapons |= CbMachinegun.Checked ? WeaponType.MachineGun : WeaponType.None;
            ini.Weapons |= CbGaussRifle.Checked ? WeaponType.GaussRifle : WeaponType.None;
            ini.Weapons |= CbRocketLauncher.Checked ? WeaponType.RocketLauncher : WeaponType.None;

            ini.Save();
        }

        private void RunGame()
        {
            if (Proc != null && !Proc.HasExited)
            {
                Proc.Refresh();
                var hWnd = Proc.MainWindowHandle;
                if (hWnd != IntPtr.Zero)
                {
                    NativeMethods.ActivateWindow(hWnd);
                }
                else
                {
                    MessageBox.Show($"Cannot activate the current game instance", "Switching process failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
#if DEBUG
                var Game = @"D:\Games\Commando\commando.exe";
#else
                var Game = Path.Combine(Application.StartupPath, "commando.exe");
#endif
                if (!File.Exists(Game))
                {
                    MessageBox.Show($"Cannot find {Game}\r\nMake sure the cheat tool is in the same directory as the game", "Starting process failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Proc = Process.Start(Game);
                    Proc.EnableRaisingEvents = true;
                    Proc.Exited += ProcessExitCheck;
                }
            }
        }

        private void ProcessExitCheck(object sender, EventArgs e)
        {
            DialogResult YN = DialogResult.No;
            if (Proc.ExitCode != 0)
            {
                YN = MessageBox.Show(
                    $@"Process exited with error code 0x{Proc.ExitCode:X8}
The game does this occasionally when you try to access some menu options.
After a few game restarts it will usually eventually work.

Want to run it again?",
                    "Game ended abnormally",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
            }
            if (YN == DialogResult.Yes)
            {
                Proc.Dispose();
                Proc = null;
                RunGame();
            }
        }

        private void LlJungle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Chapter selection", "This is the first chapter and is always available");
        }

        private void LlHealthInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Health", @"Health 7-10 requires the armour upgrade.
If you don't enable it your health will reset to 6");
        }

        private void LlScoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Score", "Scoring 3000 points grants a new life");
        }

        private void LlArmour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Armour", "Grants 4 extra life points");
        }

        private void LlHelmet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Helmet", "Looks pretty but has no other effects");
        }

        private void LlJetpack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Jetpack", "Permits double jumping. The exhaust can damage enemies and trigger explosive items.");
        }

        private void LlEnemies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Enemies", @"The game consists mostly of enemies with either 4 or 8 hitpoints.
Those with 4 hitpoints can be killed by single shots from more powerful guns.
Those with 8 hitpoints appear everywhere in the last chapter as well as occasionally in the final level in the first chapter.
You can only kill them in one hit with the two explosive weapons.");
        }

        private void LlReload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Ammo and reloading", @"Ammo for all guns is infinite, so feel free to continuously hold down the fire key.
Some guns need to reload, and you cannot trigger this manually.

A good example is the Uzi: As soon as you fire your 4th shot, the gun won't fire anymore for 1-2 seconds.
In the case of the Uzi, you're still fully mobile.
Other guns, like the rifle, reload immediately after firing and block your movement.
The shotgun is a special case. It reloads when you're stationary, but can be fired while moving.
This allows you to fire at an enemy and get out of the way before the gun reloads.");
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadIni();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveIni();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Validation failed. Please correct the error below:\r\n{ex.Message}", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error: {ex.Message}", $"Unknown error: {ex.GetType().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            RunGame();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
