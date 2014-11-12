using System;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.Utilities
{
    internal static class ShapeFactory
    {
        #region Enums

        public enum Shapes
        {
            Ellipse,
            Rectangle,
            SpottedRectangle,
            Random
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Creates a new shape.
        ///     Prerequisites:
        /// </summary>
        /// <returns></returns>
        public static Shape CreateNewShape()
        {
            int randomShape = RandomUtils.NextInt(Enum.GetNames(typeof (Shapes)).Length - 1);
            return createFinalShape((Shapes) randomShape);
        }

        private static Shape createFinalShape(Shapes randomShape)
        {
            switch (randomShape)
            {
                case Shapes.Ellipse:
                    return CreateNewEllipse();
                case Shapes.Rectangle:
                    return CreateNewRectangle();
                case Shapes.SpottedRectangle:
                    return CreateNewSpottedRectangle();
                default:
                    return null;
            }
        }



        /// <summary>
        ///     Creates a new circle.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateNewEllipse()
        {
            return new Ellipse();
        }

        /// <summary>
        ///     Creates a new rectangle.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateNewRectangle()
        {
            return new Rectangle();
        }

        /// <summary>
        ///     Creates a new spotted circle.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateNewSpottedRectangle()
        {
            return new SpottedRectangle();
        }

        public static Shape CreateNewShape(Shapes shapeType)
        {
            if (shapeType.Equals(Shapes.Random))
            {
                return CreateNewShape();
            }
            return createFinalShape(shapeType);
        }

        #endregion
    }
}