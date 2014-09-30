using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    internal class RectangleSprite : ShapeSprite
    {
        private const int myWidth = 75;
        private const int myHeight = 125;
        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public RectangleSprite(Shape shape) : base(shape,myWidth,myHeight)
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
            base.Paint(g);

            var yellowBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(yellowBrush, this.TheShape.X, this.TheShape.Y, 75, 125);
        }
    }
}