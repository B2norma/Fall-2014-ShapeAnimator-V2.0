using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    class LRectangleSprite : RectangleSprite
    {
         public LRectangleSprite() : base()
        {
        }
         public LRectangleSprite(Shape shape) : base(shape)
        {

        }

         /// <summary>
         /// Draws a LRectangle shape
         /// Preconditon: g != null
         /// </summary>
         /// <param name="g">The graphics object to draw the shape one</param>
         /// <exception cref="System.ArgumentNullException">g</exception>
         public override void Paint(Graphics g)
         {
             base.Paint(g);

             var yellowBrush = new SolidBrush(Color.IndianRed);
             g.FillRectangle(yellowBrush, this.theShape.X, this.theShape.Y+75, 125, 50);
         }
    }
}
