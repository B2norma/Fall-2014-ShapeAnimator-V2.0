using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimator.Model
{
    class LRectangle : Rectangle
    {

        public LRectangle (Point Location, int tempDirection, int tempSpeedX, int tempSpeedY) : base(Location, tempDirection, tempSpeedX, tempSpeedY)
        {
            width = 100;
            height = 100;
        }

        public override void Move()
        {
            
        }
    }
}
