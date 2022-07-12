using System;
using System.Linq;

namespace CommandoCheatTool
{
    /// <summary>
    /// Level names
    /// </summary>
    /// <remarks>
    /// These are made-up names.
    /// There are no level names shown in the game.
    /// </remarks>
    public static class LevelNames
    {
        /// <summary>
        /// Made-up level names in order they appear
        /// </summary>
        private static readonly string[] Names = new string[]
        {
            "Game Intro (Cutscene)",
            "Jungle Intro (Cutscene)",
            "Jungle 1",
            "Mine",
            "Storage",
            "Jungle 2",
            "Airport",
            "Jungle End (Cutscene)",
            "Desert Intro (Cutscene)",
            "Desert",
            "Military Storage Facility",
            "Train",
            "Oil Refinery",
            "Crash Site",
            "Desert End (Cutscene)",
            "Ice Intro (Cutscene)",
            "Ice",
            "Air Base",
            "Mecha Assembly Facility",
            "Rocket Launch Facility",
            "Rocket",
            "Rocket Explosion (Cutscene)",
            "Ice End (Cutscene)"
        };

        /// <summary>
        /// Level structures
        /// </summary>
        private static readonly Level[] Levels = Names
            //Dealing with null means we could elegantly remove cutscenes from the list.
            .Select((l, i) => l == null ? null : new Level(i + Level.MIN_LEVEL, l))
            .Where(m => m != null)
            .ToArray();

        /// <summary>
        /// Gets level names in order of appearance
        /// </summary>
        /// <returns>Level names</returns>
        public static string[] GetLevelNames()
        {
            return (string[])Names.Clone();
        }

        /// <summary>
        /// Gets level structures
        /// </summary>
        /// <returns>Level structures</returns>
        public static Level[] GetLevels()
        {
            return (Level[])Levels.Clone();
        }

        /// <summary>
        /// Gets a level by the level number used in the INI file
        /// </summary>
        /// <param name="LevelNumber">Level number</param>
        /// <returns>Level</returns>
        public static Level GetLevel(int LevelNumber)
        {
            if (LevelNumber < Level.MIN_LEVEL || LevelNumber > Level.MAX_LEVEL)
            {
                throw new ArgumentOutOfRangeException(nameof(LevelNumber));
            }
            return Levels.First(m => m.LevelNumber == LevelNumber);
        }

    }
}
