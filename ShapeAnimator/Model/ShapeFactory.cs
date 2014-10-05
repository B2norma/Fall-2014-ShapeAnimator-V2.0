using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model.Shapes;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimator.Model
{
    static class ShapeFactory
    {
        private enum Shapes
        {
            Circle,
            Rectangle,
            LRectangle
        }


        public static Shape CreateNewShape(Random randomizer, int boundsWidth, int boundsHeight)
        {
            int randomNumber = randomizer.Next(3);
            int tempSpeedX = randomizer.Next(1,6);
            int tempSpeedY = randomizer.Next(1,6);
            int randomDirection = randomizer.Next(2);
            int tempPointX;
            int tempPointY;
            Point tempPoint;
            Shape tempShape;
            Color tempColor;
            tempColor = Color.Black;

            randomDirection = flipDirectionValue(randomDirection);
            tempShape = createTemporaryShape(randomNumber, randomDirection, tempSpeedX, tempSpeedY,tempColor);

            tempPointX = (int) randomizer.Next(boundsWidth - tempShape.Width);
            tempPointY = (int) randomizer.Next(boundsHeight - tempShape.Height);
            tempPoint = new Point(tempPointX, tempPointY);

            tempColor = generateRandomColor(randomizer);
            return createFinalShape(randomNumber, tempPoint, randomDirection, tempSpeedX, tempSpeedY, tempColor);
        }

        private static Color generateRandomColor(Random randomizer)
        {
            int tempRed;
            int tempGreen;
            int tempBlue;

            tempRed = generateRandomColorValue(randomizer);
            tempGreen = generateRandomColorValue(randomizer);
            tempBlue = generateRandomColorValue(randomizer);

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
                return new Circle(tempPoint, randomDirection, tempSpeedX, tempSpeedY,tempColor);
            }
            else if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY,tempColor);
            }
            else if (randomNumber == (int) Shapes.LRectangle)
            {
                return new SpottedRectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY,tempColor);
            }
            return null;
        }

        private static Shape createTemporaryShape(int randomNumber, int randomDirection, int randomX, int randomY,Color tempColor)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(new Point(1), randomDirection, randomX, randomY,tempColor);
            }
            else if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(new Point(1), randomDirection, randomX, randomY,tempColor);
            }
            else if (randomNumber == (int) Shapes.LRectangle)
            {
               return new SpottedRectangle(new Point(1), randomDirection, randomX, randomY,tempColor);
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
    }
}
