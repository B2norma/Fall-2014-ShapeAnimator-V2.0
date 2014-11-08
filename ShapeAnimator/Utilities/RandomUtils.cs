using System;
using System.Drawing;

namespace ShapeAnimator.Utilities
{
    internal static class RandomUtils
    {
        #region Constants

        private const int MaxRgbValue = 256;
        private const int MinRgbValue = 1;
        private const int MaxSpeedValue = 5;
        private const int MinSpeedValue = 1;
        private const int MinSize = 20;
        private const int MaxSize = 101;
        private const int AvaliableDirections = 2;

        #endregion

        #region Variables

        private static readonly Random Randomizer = new Random();

        #endregion

        #region Methods

        /// <summary>
        ///     Generates a random integer between 0 and maxNumber.
        /// </summary>
        /// <param name="maxNumber">The maximum number.</param>
        /// <returns></returns>
        public static int NextInt(int maxNumber)
        {
            return Randomizer.Next(maxNumber);
        }

        /// <summary>
        ///     Generates a random integer between minNumber and maxNumber.
        /// </summary>
        /// <param name="minNumber">The minimum number.</param>
        /// <param name="maxNumber">The maximum number.</param>
        /// <returns></returns>
        public static int NextInt(int minNumber, int maxNumber)
        {
            return Randomizer.Next(minNumber, maxNumber);
        }

        /// <summary>
        ///     Generates the random color.
        /// </summary>
        /// <returns></returns>
        public static Color GenerateRandomColor()
        {
            return Color.FromArgb(NextInt(MinRgbValue, MaxRgbValue),
                NextInt(MinRgbValue, MaxRgbValue), NextInt(MinRgbValue, MaxRgbValue));
        }

        /// <summary>
        ///     Generates the random speed.
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomSpeed()
        {
            return NextInt(MinSpeedValue, MaxSpeedValue);
        }

        /// <summary>
        ///     Generates the random width or height.
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomHeightWidth()
        {
            return NextInt(MinSize, MaxSize);
        }

        /// <summary>
        ///     Generates the random direction.
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomDirection()
        {
            return NextInt(AvaliableDirections);
        }

        /// <summary>
        ///     Generates the random identifier.
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomId()
        {
            return NextInt(int.MaxValue);
        }

        #endregion
    }
}