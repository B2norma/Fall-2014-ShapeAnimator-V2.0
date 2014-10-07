using System;
using System.Drawing;
using System.Linq.Expressions;
using ShapeAnimator.Model.Shapes;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimator.Model
{
    internal static class ShapeFactory
    {
        private const int minimumSpeed = 1;
        private const int maximumSpeed = 6;
        /// <summary>
        ///     Creates a new shape. It generates a Random Shape, random speed in the x and y direction, a random direction, a
        ///     random location withing the bounds specified,
        ///     and a random color.
        ///     Prerequisites: Nothing can be null.
        /// </summary>
        /// <param name="randomizer">The randomizer.</param>
        /// <param name="boundsWidth">Width of the bounds.</param>
        /// <param name="boundsHeight">Height of the bounds.</param>
        /// <returns></returns>
        public static Shape CreateNewShape(Random randomizer, int boundsWidth, int boundsHeight)
        {
            int randomNumber = randomizer.Next(Enum.GetNames(typeof(Shapes)).Length);
            int tempSpeedX = randomizer.Next(minimumSpeed, maximumSpeed);
            int tempSpeedY = randomizer.Next(minimumSpeed, maximumSpeed);
            int randomDirection = randomizer.Next(2);
            Color tempColor = Color.Black;
            Shape tempShape = createTemporaryShape(randomNumber, randomDirection, tempSpeedX, tempSpeedY, tempColor);

            randomDirection = flipDirectionValue(randomDirection);
            

            int tempPointX = randomizer.Next(boundsWidth - tempShape.Width);
            int tempPointY = randomizer.Next(boundsHeight - tempShape.Height);
            
            var tempPoint = new Point(tempPointX, tempPointY);

            tempColor = generateRandomColor(randomizer);
            return createFinalShape(randomNumber, tempPoint, randomDirection, tempSpeedX, tempSpeedY, tempColor);
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

        private static Shape createFinalShape(int randomNumber, Point tempPoint, int randomDirection, int tempSpeedX,
            int tempSpeedY, Color tempColor)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(tempPoint, randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            if (randomNumber == (int) Shapes.LRectangle)
            {
                return new SpottedRectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY, tempColor);
            }
            return null;
        }

        private static Shape createTemporaryShape(int randomNumber, int randomDirection, int randomX, int randomY,
            Color tempColor)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(new Point(1), randomDirection, randomX, randomY, tempColor);
            }
            if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(new Point(1), randomDirection, randomX, randomY, tempColor);
            }
            if (randomNumber == (int) Shapes.LRectangle)
            {
                return new SpottedRectangle(new Point(1), randomDirection, randomX, randomY, tempColor);
            }
            return null;
        }

        private static int flipDirectionValue(int randomDirection)
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