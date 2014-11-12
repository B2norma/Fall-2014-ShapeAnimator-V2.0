using System;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.Utilities
{
    internal static class ShapeFactory
    {
        #region Enums

        /// <summary>
        ///     The Shapes that are avaliable to create.
        /// </summary>
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
                    return new Ellipse();
                case Shapes.Rectangle:
                    return new Rectangle();
                case Shapes.SpottedRectangle:
                    return new SpottedRectangle();
                default:
                    return null;
            }
        }

        /// <summary>
        ///     Creates a new shape.
        /// </summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <returns></returns>
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