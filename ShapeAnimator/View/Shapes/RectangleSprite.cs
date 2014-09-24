using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    class RectangleSprite : ShapeSprite
    {
        public RectangleSprite() : base()
        {
        }
         public RectangleSprite(Shape shape) : base(shape)
        {

        }

         /// <summary>
         /// Draws a shape
         /// Preconditon: g != null
         /// </summary>
         /// <param name="g">The graphics object to draw the shape one</param>
         /// <exception cref="System.ArgumentNullException">g</exception>
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

            var yellowBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(yellowBrush, this.theShape.X, this.theShape.Y, 75, 125);
        }
    }
}
