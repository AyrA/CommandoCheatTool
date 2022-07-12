using System;

namespace CommandoCheatTool
{
    /// <summary>
    /// Level structure for displaying in a form
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Maximum level number
        /// </summary>
        public const int MAX_LEVEL = 27;
        /// <summary>
        /// Minimum level number
        /// </summary>
        public const int MIN_LEVEL = 5;

        /// <summary>
        /// Gets the internal level number
        /// </summary>
        /// <remarks>
        /// The internal level number is the number used in the INI file
        /// </remarks>
        public int LevelNumber { get; }
        /// <summary>
        /// Gets the level name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a level info structure
        /// </summary>
        /// <param name="LevelNumber">Internal level number</param>
        /// <param name="Name">Level name</param>
        public Level(int LevelNumber, string Name)
        {
            if (LevelNumber < MIN_LEVEL || LevelNumber > MAX_LEVEL)
            {
                throw new ArgumentOutOfRangeException(nameof(LevelNumber));
            }
            this.LevelNumber = LevelNumber;
            this.Name = Name ?? throw new ArgumentNullException(nameof(Name));
        }

        /// <summary>
        /// Display string with external level number
        /// </summary>
        /// <returns>Display string</returns>
        /// <remarks>
        /// The external level number is the internal number adjusted to start at "1"
        /// </remarks>
        public override string ToString()
        {
            return $"Level {LevelNumber - MIN_LEVEL + 1}: {Name}";
        }

        #region Comparison

        public override int GetHashCode()
        {
            return
                0x329D79E9 ^
                LevelNumber.GetHashCode() ^
                Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Level param))
            {
                return false;
            }
            return param.LevelNumber == LevelNumber && param.Name == Name;
        }

        public static bool operator ==(Level A, Level B)
        {
            var an = A is null;
            var bn = B is null;
            if ((an && !bn) || (!an && bn) || (an && bn))
            {
                return an && bn;
            }
            return A.Name == B.Name && A.LevelNumber == B.LevelNumber;
        }

        public static bool operator !=(Level A, Level B)
        {
            return !(A == B);
        }

        #endregion
    }
}
