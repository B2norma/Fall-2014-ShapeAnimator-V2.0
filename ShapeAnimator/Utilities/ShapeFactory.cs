using System;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.Utilities
{
    internal static class ShapeFactory
    {

        #region Enums

        private enum Shapes
        {
            Ellipse,
            Rectangle,
            SpottedRectangle
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
            int randomShape = RandomUtils.NextInt(Enum.GetNames(typeof (Shapes)).Length);
            return createFinalShape(randomShape);
        }

        private static Shape createFinalShape(int randomShape)
        {
            switch ((Shapes)randomShape)
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

        #endregion

    }
}