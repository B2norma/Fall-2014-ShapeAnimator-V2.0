using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    internal class LRectangleSprite : RectangleSprite
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LRectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public LRectangleSprite(Shape shape) : base(shape)
        {
        }

        /// <summary>
        ///     Draws a LRectangle shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var yellowBrush = new SolidBrush(Color.IndianRed);
            g.FillRectangle(yellowBrush, this.TheShape.X, this.TheShape.Y + 75, 125, 50);
        }
    }
}