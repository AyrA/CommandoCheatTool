using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoCheatTool
{
    public class Level
    {
        /// <summary>
        /// Maximum level number
        /// </summary>
        public const int MAX_LEVEL = 99; //TODO
        /// <summary>
        /// Minimum level number
        /// </summary>
        public const int MIN_LEVEL = 6;

        public int LevelNumber { get; }
        public string Name { get; }

        public Level(int LevelNumber, string Name)
        {
            if (LevelNumber < MIN_LEVEL || LevelNumber > MAX_LEVEL)
            {
                throw new ArgumentOutOfRangeException(nameof(LevelNumber));
            }
            this.LevelNumber = LevelNumber;
            this.Name = Name ?? throw new ArgumentNullException(nameof(Name));
        }

        public override string ToString()
        {
            return $"Level {LevelNumber}: {Name}";
        }
    }
}
