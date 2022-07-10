using System.Linq;

namespace CommandoCheatTool
{
    public static class LevelNames
    {
        private static readonly string[] Names = new string[]
        {
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

        private static readonly Level[] Levels = Names
            .Select((l, i) => l == null ? null : new Level(i + Level.MIN_LEVEL, l))
            .Where(m => m != null)
            .ToArray();

        public static string[] GetLevelNames()
        {
            return (string[])Names.Clone();
        }

        public static Level[] GetLevels()
        {
            return (Level[])Levels.Clone();
        }

    }
}
