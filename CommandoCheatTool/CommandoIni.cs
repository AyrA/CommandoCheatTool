using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoCheatTool
{
    /// <summary>
    /// Commando INI file
    /// </summary>
    /// <remarks>This is ridiculously primitive. Do not use for other ini files</remarks>
    public class CommandoIni
    {
        /// <summary>
        /// Maximum possible number of lifes
        /// </summary>
        /// <remarks>
        /// Exceeding this simply clamps the value
        /// </remarks>
        public const int MAX_LIVES = 999_999_999;

        /// <summary>
        /// Gets the ini file name
        /// </summary>
        /// <returns>INI file name</returns>
        /// <remarks>
        /// Commando wants to store the ini in the Windows directory because it's an old game,
        /// but Windows is smart and redirects this to avoid the problem with admin rights.
        /// </remarks>
        public static string GetIniFileName()
        {
            return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "VirtualStore",
            "Windows",
            "Commando.dat"
            );
        }

        /// <summary>
        /// Health. Range: 1-6 when <see cref="Armour"/> is false, otherwise 1-10
        /// </summary>
        /// <remarks>
        /// Getting to zero reduces <see cref="Lives"/> and sets the player back to the last checkpoint,
        /// unless <see cref="Lives"/> hits zero
        /// </remarks>
        public int Health { get; set; }
        /// <summary>
        /// Lives. Range: 1+
        /// </summary>
        /// <remarks>
        /// Hitting zero is game over
        /// </remarks>
        public int Lives { get; set; }
        /// <summary>
        /// Level. Range: between <see cref="Level.MIN_LEVEL"/> and <see cref="Level.MAX_LEVEL"/> inclusive
        /// </summary>
        /// <remarks>The value is limited by the game to the maximum value.
        /// Values below <see cref="Level.MIN_LEVEL"/> are menu screens or the intro
        /// </remarks>
        public int CurrentLevel { get; set; }
        /// <summary>
        /// Score. Range: 0-3000
        /// </summary>
        /// <remarks>Getting 3000 gives an extra life</remarks>
        public int Score { get; set; }

        /// <summary>
        /// Regular grenades. Range: 0-6
        /// </summary>
        /// <remarks>
        /// Regular grenades explode after a short duration when thrown
        /// </remarks>
        public int Grenades { get; set; }
        /// <summary>
        /// Napalm grenades. Range: 0-6
        /// </summary>
        /// <remarks>
        /// Napalm grenades spew out fire upwards, then eventually explode.
        /// The fire will not damage the player.
        /// </remarks>
        public int NapalmGrenades { get; set; }
        /// <summary>
        /// Remote detonated grenates. Range: 0-6
        /// </summary>
        /// <remarks>
        /// Pressing Z the first time throws the grenade,
        /// pressing it again detonates it.
        /// You cannot throw these for some reason while other grenades are currently active.
        /// </remarks>
        public int RemoteGrenades { get; set; }

        /// <summary>
        /// If set, adds an additional 4 hitpoints to the player (Increase from 6 to 10)
        /// </summary>
        /// <remarks>
        /// Medics will heal all 10 hitpoins, but only heal at all when you're below 6
        /// </remarks>
        public bool Armour { get; set; }
        /// <summary>
        /// A fancy helmet that does nothing
        /// </summary>
        /// <remarks>
        /// This just looks pretty.
        /// It's completely useless unless I missed something.
        /// </remarks>
        public bool Helmet { get; set; }
        /// <summary>
        /// Permits double jumping
        /// </summary>
        /// <remarks>
        /// Has no recharge time. Can be used immediately again after landing.
        /// The exhaust can damage enemies and detonate explosive items.
        /// </remarks>
        public bool Jetpack { get; set; }

        /// <summary>
        /// Weapons the player has unlocked. The pistol and knife are always available
        /// </summary>
        /// <remarks>
        /// Each chapter will provide some weapons at the level start.
        /// Some weapons are not obtainable in all chapters.
        /// The <see cref="WeaponType.GaussRifle"/> and <see cref="WeaponType.MachineGun"/>
        /// are only obtainable in a secret location.
        /// </remarks>
        public WeaponType Weapons { get; set; }

        /// <summary>
        /// Unlocked chapters
        /// </summary>
        /// <remarks>
        /// The jungle chapter is always available.
        /// Unlocking <see cref="LevelType.Ice"/> automatically unlocks <see cref="LevelType.Desert"/>,
        /// even if not explicitly specified
        /// </remarks>
        public LevelType UnlockedLevels { get; set; }

        /// <summary>
        /// Creates a new instance and tries to parse the existing file (if any)
        /// </summary>
        public CommandoIni()
        {
            string[] Lines = null;
            try
            {
                Lines = File.ReadAllLines(GetIniFileName());
            }
            catch
            {
                //No ini file
                Health = 6;
                Lives = 20;
                CurrentLevel = CommandoCheatTool.Level.MIN_LEVEL;
            }
            if (Lines != null)
            {
                Parse(Lines);
            }
        }

        /// <summary>
        /// Saves the current values to file
        /// </summary>
        public void Save()
        {
            Validate();
            var Lines = new List<string>
            {
                "[Status]",
                $"Health={Health}",
                $"Lives={Lives}",
                $"Level={CurrentLevel}",
                $"score={Score}",

                "[Check]",
                "Check=666",

                "[Weapons]"
            };
            if (Weapons != WeaponType.None)
            {
                foreach (var V in Enum.GetValues(typeof(WeaponType)))
                {
                    var WT = (WeaponType)V;
                    if (WT != WeaponType.None && Weapons.HasFlag(WT))
                    {
                        //Minigun is written in lowercase
                        Lines.Add(WT == WeaponType.Minigun ? "minigun=1" : $"{WT}=1");
                    }
                }
            }

            Lines.Add("[Items]");
            if (Grenades > 0)
            {
                Lines.Add($"grenade={Grenades}");
            }
            if (NapalmGrenades > 0)
            {
                Lines.Add($"napalm={NapalmGrenades}");
            }
            if (RemoteGrenades > 0)
            {
                Lines.Add($"satchel={RemoteGrenades}");
            }
            if (Armour)
            {
                Lines.Add("armour=1");
            }
            if (Helmet)
            {
                Lines.Add("helmet=1");
            }
            if (Jetpack)
            {
                Lines.Add("jetpack=1");
            }
            Lines.Add("[Levels]");
            if (UnlockedLevels.HasFlag(LevelType.Desert))
            {
                Lines.Add("desert=1");
            }
            if (UnlockedLevels.HasFlag(LevelType.Ice))
            {
                Lines.Add("ice=1");
            }

            File.WriteAllLines(GetIniFileName(), Lines.ToArray());
        }

        public void Validate()
        {
            if (CurrentLevel < Level.MIN_LEVEL || CurrentLevel > Level.MAX_LEVEL)
            {
                throw new ValidationException($"Level number must be from {Level.MIN_LEVEL} to {Level.MAX_LEVEL} inclusive");
            }
            if (Health < 1)
            {
                throw new ValidationException("Setting health to zero or less will immediately kill the player");
            }
            if (Health > 10)
            {
                throw new ValidationException($"Cannot have more than 10 health points at most");
            }
            if (Health > 5 && !Armour)
            {
                throw new ValidationException("Health points above 6 require armour");
            }
            if (Lives < 1)
            {
                throw new ValidationException("Setting lives to zero or less will immediately end the game");
            }
            if (Lives > MAX_LIVES)
            {
                throw new ValidationException($"Lives are limited to {MAX_LIVES}");
            }
            if (Score < 0 || Score > 3000)
            {
                throw new ValidationException("Score must be in the range 0-3000 inclusive");
            }
            if (Range(0, Grenades, 6) != Grenades || Range(0, NapalmGrenades, 6) != NapalmGrenades || Range(0, RemoteGrenades, 6) != RemoteGrenades)
            {
                throw new ValidationException("Can only carry 0-6 grenades");
            }
            if (UnlockedLevels == LevelType.Ice)
            {
                throw new ValidationException("Cannot unlock ice area alone. Must unlock desert first");
            }
            WeaponType T = WeaponType.None;
            foreach (var V in Enum.GetValues(typeof(WeaponType)))
            {
                T |= (WeaponType)V;
            }
            if ((T | Weapons) != T)
            {
                throw new ValidationException("Unkown weapon enumeration value found");
            }
        }

        private void Parse(string[] Lines)
        {
            //Note: All ini keys are unique in this game.
            //This means we can ignore the section structures of INI files completely.

            foreach (var L in Lines)
            {
                if (string.IsNullOrWhiteSpace(L) || !L.Contains('='))
                {
                    continue;
                }
                var Parts = L.Split('=');
                if (Parts.Length != 2 || !int.TryParse(Parts[1], out int Value))
                {
                    System.Diagnostics.Debug.Print($"Invalid INI line: {L}");
                    continue;
                }
                //Parse and validate
                switch (Parts[0].ToUpper())
                {
                    case "CHECK":
                        if (Value != 666)
                        {
                            System.Diagnostics.Debug.Print($"Check value was not 666 but {Value}. Invalid INI?");
                        }
                        break;
                    case "HEALTH":
                        Health = Range(1, Value, 10);
                        break;
                    case "LIVES":
                        Lives = Range(1, Value, 9999);
                        break;
                    case "LEVEL":
                        CurrentLevel = Range(CommandoCheatTool.Level.MIN_LEVEL, Value, CommandoCheatTool.Level.MAX_LEVEL);
                        break;
                    case "SCORE":
                        Score = Range(0, Value, 3000);
                        break;

                    case "GAUSSPISTOL":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.GaussPistol;
                        }
                        break;
                    case "UZI":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.Uzi;
                        }
                        break;
                    case "LASERPISTOL":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.LaserPistol;
                        }
                        break;
                    case "RIFLE":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.Rifle;
                        }
                        break;
                    case "SHOTGUN":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.Shotgun;
                        }
                        break;
                    case "MINIGUN":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.Minigun;
                        }
                        break;
                    case "FLAMER":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.Flamer;
                        }
                        break;
                    case "MACHINEGUN":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.MachineGun;
                        }
                        break;
                    case "GAUSSRIFLE":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.GaussRifle;
                        }
                        break;
                    case "ROCKETLAUNCHER":
                        if (Value == 1)
                        {
                            Weapons |= WeaponType.RocketLauncher;
                        }
                        break;

                    case "GRENADE":
                        Grenades = Range(1, Value, 6);
                        break;
                    case "NAPALM":
                        NapalmGrenades = Range(1, Value, 6);
                        break;
                    case "SATCHEL":
                        RemoteGrenades = Range(1, Value, 6);
                        break;
                    case "ARMOUR":
                        Armour = Value == 1;
                        break;
                    case "HELMET":
                        Helmet = Value == 1;
                        break;
                    case "JETPACK":
                        Jetpack = Value == 1;
                        break;

                    case "DESERT":
                        if (Value == 1)
                        {
                            UnlockedLevels |= LevelType.Desert;
                        }
                        break;
                    case "ICE":
                        if (Value == 1)
                        {
                            UnlockedLevels |= LevelType.Ice;
                        }
                        break;
                    default:
                        System.Diagnostics.Debug.Print($"Unknown INI line: {L}");
                        break;
                }
            }
        }

        private static int Range(int Min, int Value, int Max)
        {
            return Math.Min(Max, Math.Max(Min, Value));
        }
    }

    [Flags]
    public enum WeaponType
    {
        None = 0,
        GaussPistol = 1,
        Uzi = GaussPistol << 1,
        LaserPistol = Uzi << 1,
        Rifle = LaserPistol << 1,
        Shotgun = Rifle << 1,
        Minigun = Shotgun << 1,
        Flamer = Minigun << 1,
        MachineGun = Flamer << 1,
        GaussRifle = MachineGun << 1,
        RocketLauncher = GaussRifle << 1
    }

    [Flags]
    public enum LevelType
    {
        None = 0,
        Desert = 1,
        Ice = Desert << 1
    }
}
