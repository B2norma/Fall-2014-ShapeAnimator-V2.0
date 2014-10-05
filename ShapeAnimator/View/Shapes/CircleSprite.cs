using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Responsible for drawing the actual sprite on the screen.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {
        private const int myWidth = 100;
        private const int myHeight = 100;
        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="shape">The shape.</param>
        public CircleSprite(Shape shape):base(shape,myWidth,myHeight)
        {
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var theBrush = new SolidBrush(this.TheShape.color);
            g.FillEllipse(theBrush, this.TheShape.X, this.TheShape.Y, this.TheShape.Width, this.TheShape.Height);
        }
    }
}