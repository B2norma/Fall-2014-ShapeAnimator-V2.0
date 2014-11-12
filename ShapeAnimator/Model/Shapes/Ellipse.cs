using System;
using ShapeAnimator.View;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     The Ellipse Class. Inherits from Shape.
    /// </summary>
    public class Ellipse : Shape
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Ellipse" /> class.
        /// </summary>
        public Ellipse()
        {
            this.Sprite = new EllipseSprite(this);
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
            return Math.PI*((double) this.Height/2)*((double) this.Width/2);
        }

        /// <summary>
        ///     Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>
        ///     The parimeter of the shape.
        /// </returns>
        public override double CalculatePerimeter()
        {
            return (2*Math.PI)*
                   (Math.Sqrt((Math.Pow(((double) this.Height/2), 2) + Math.Pow(((double) this.Width/2), 2))/2));
        }

        #endregion
    }
}