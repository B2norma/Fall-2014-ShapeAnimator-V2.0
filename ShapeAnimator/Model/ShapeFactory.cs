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
            int tempSpeedX = randomizer.Next(6);
            int tempSpeedY = randomizer.Next(6);
            int randomDirection = randomizer.Next(2);
            int tempPointX;
            int tempPointY;
            Point tempPoint;
            Shape tempShape;

            randomDirection = flipDirectionValue(randomDirection);
            tempShape = createTemporaryShape(randomNumber, randomDirection, tempSpeedX, tempSpeedY);

            tempPointX = (int) randomizer.Next(boundsWidth - tempShape.Width);
            tempPointY = (int) randomizer.Next(boundsHeight - tempShape.Height);

            tempPoint = new Point(tempPointX, tempPointY);
            return createFinalShape(randomNumber, tempPoint, randomDirection, tempSpeedX, tempSpeedY);
        }

        private static Shape createFinalShape(int randomNumber, Point tempPoint, int randomDirection, int tempSpeedX,
            int tempSpeedY)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(tempPoint, randomDirection, tempSpeedX, tempSpeedY);
            }
            else if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY);
            }
            else if (randomNumber == (int) Shapes.LRectangle)
            {
                return new LRectangle(tempPoint, randomDirection, tempSpeedX, tempSpeedY);
            }
            return __;
        }

        private static Shape createTemporaryShape(int randomNumber, int randomDirection, int randomX, int randomY)
        {
            if (randomNumber == (int) Shapes.Circle)
            {
                return new Circle(new Point(1), randomDirection, randomX, randomY);
            }
            else if (randomNumber == (int) Shapes.Rectangle)
            {
                return new Rectangle(new Point(1), randomDirection, randomX, randomY);
            }
            else if (randomNumber == (int) Shapes.LRectangle)
            {
               return new LRectangle(new Point(1), randomDirection, randomX, randomY);
            }
        }

        private static int flipDirectionValue(int randomDirection)
        {
            if (randomDirection == 0)
            {
                return -1;
            }
        }
    }
}
