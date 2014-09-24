using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Responsible for drawing the actual sprite on the screen.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {


        /// <summary>
        ///     Prevents a default instance of the <see cref="CircleSprite" /> class from being created.
        /// </summary>
        private CircleSprite() : base()
        {
            
        }



        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="shape">The shape.</param>
        public CircleSprite(Shape shape) : base(shape)
        {

        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (theShape == null)
            {
                return;
            }

            var yellowBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(yellowBrush, this.theShape.X, this.theShape.Y, 100, 100);
        }
    }
}