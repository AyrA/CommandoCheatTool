using System;
using System.Windows.Forms;

namespace CommandoCheatTool
{
    public partial class FrmComCheat : Form
    {
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

        }

        private void SaveIni()
        {

        }

        private void RunGame()
        {

        }

        private void LlJungle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Chapter selection", "This is the first chapter and is always available");
        }

        private void LlHealthInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Health", @"Health 7-8 requires either armour or helmet.
Health 9-10 requires both.
If you don't enable these items your health will reset to 6");
        }

        private void LlScoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Score", "Scoring 3000 points grants a new life");
        }

        private void LlArmour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Armour", "Grants two extra life points");
        }

        private void LlHelmet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info("Helmet", "Grants two extra life points. It also looks cool");
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
            SaveIni();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            RunGame();
        }
    }
}
