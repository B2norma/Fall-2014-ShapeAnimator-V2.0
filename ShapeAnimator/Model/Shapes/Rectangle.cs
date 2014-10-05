using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAnimator.Model.Shapes
{
    virtual class Rectangle : Shape
    {
        public Rectangle(Point Location, int tempDirection, int tempSpeedX, int tempSpeedY) : base(Location, tempDirection, tempSpeedX, tempSpeedY)
        {
            width = 75;
            height = 125;
        }

        public override void Move()
        {

        }
    }
}
