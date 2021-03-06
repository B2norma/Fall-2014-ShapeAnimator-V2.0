﻿using ShapeAnimator.View;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     The Rectangle Class. Inherits from shape.
    /// </summary>
    public class Rectangle : Shape
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rectangle" /> class.
        ///     Pre: nothing can be null
        /// </summary>
        public Rectangle()
        {
            this.Sprite = new RectangleSprite(this);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Calculates the area of the shape.
        /// </summary>
        /// <returns>
        ///     The area of the shape.
        /// </returns>
        public override double CalculateArea()
        {
            return this.Height*this.Width;
        }

        /// <summary>
        ///     Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>
        ///     The parimeter of the shape.
        /// </returns>
        public override double CalculatePerimeter()
        {
            return (2*this.Height) + (2*this.Width);
        }

        #endregion
    }
}