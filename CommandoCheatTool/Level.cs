using System;

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
            if((an && !bn) || (!an && bn) || (an && bn))
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
