using System;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.Model
{
    internal static class ShapeFactory
    {
        /// <summary>
        ///     Creates a new shape.
        ///     Prerequisites:
        /// </summary>
        /// <returns></returns>
        public static Shape CreateNewShape()
        {
            int randomShape = RandomUtils.NextInt(Enum.GetNames(typeof (Shapes)).Length);
            return createFinalShape(randomShape);
        }

        private static Shape createFinalShape(int randomShape)
        {
            if ((Shapes) randomShape == Shapes.Circle)
            {
                return new Circle();
            }
            if ((Shapes) randomShape == Shapes.Rectangle)
            {
                return new Rectangle();
            }
            if ((Shapes) randomShape == Shapes.LRectangle)
            {
                return new SpottedRectangle();
            }
            return null;
        }

        private enum Shapes
        {
            Circle,
            Rectangle,
            LRectangle
        }
    }
}