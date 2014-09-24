using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    internal class RectangleSprite : ShapeSprite
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public RectangleSprite(Shape shape) : base(shape)
        {
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.TheShape == null)
            {
                return;
            }

            var yellowBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(yellowBrush, this.TheShape.X, this.TheShape.Y, 75, 125);
        }
    }
}