using System;

namespace ShapeAnimator.Utilities
{
    internal static class RandomUtils
    {

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


        #endregion

    }
}