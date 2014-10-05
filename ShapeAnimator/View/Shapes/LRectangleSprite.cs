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
            g.FillEllipse(yellowBrush, this.TheShape.X+this.TheShape.Width/2, this.TheShape.Y + this.TheShape.Height/2,10,10);
        }
    }
}