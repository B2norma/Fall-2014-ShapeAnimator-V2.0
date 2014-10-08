using System;
using System.Drawing;
using ShapeAnimator.Model.Shapes;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimator.Model
{
    internal static class ShapeFactory
    {
        private const int MinimumSpeed = 1;
        private const int MaximumSpeed = 6;

        /// <summary>
        ///     Creates a new shape. It generates a Random Shape, random speed in the x and y direction, a random direction, 
        ///     and a random color.
        ///     Prerequisites: Nothing can be null.
        /// </summary>
        /// <param name="randomizer">The randomizer.</param>
        /// <returns></returns>
        public static Shape CreateNewShape(Random randomizer)
        {
            int randomShape = randomizer.Next(Enum.GetNames(typeof (Shapes)).Length);

            int tempSpeedX = randomizer.Next(MinimumSpeed, MaximumSpeed);
            int tempSpeedY = randomizer.Next(MinimumSpeed, MaximumSpeed);

            int randomDirection = randomizer.Next(2);
            randomDirection = verifyDirectionValue(randomDirection);

            Color tempColor = generateRandomColor(randomizer);
            return createFinalShape(randomShape, randomDirection, tempSpeedX, tempSpeedY, tempColor);
        }

        private static Color generateRandomColor(Random randomizer)
        {
            int tempRed = generateRandomColorValue(randomizer);
            int tempGreen = generateRandomColorValue(randomizer);
            int tempBlue = generateRandomColorValue(randomizer);

            return Color.FromArgb(tempRed, tempGreen, tempBlue);
        }

        private static int generateRandomColorValue(Random randomizer)
        {
            return randomizer.Next(1, 256);
        }

        private static Shape createFinalShape(int randomNumber, int randomDirection, int tempSpeedX,
            int tempSpeedY, Color tempColor)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            if (randomNumber == (int) Shapes.LRectangle)
            {
                return new SpottedRectangle(randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            return null;
        }
        private static int verifyDirectionValue(int randomDirection)
        {
            if (randomDirection == 0)
            {
                return -1;
            }
            return 1;
        }

        private enum Shapes
        {
            Circle,
            Rectangle,
            LRectangle
        }
    }
}