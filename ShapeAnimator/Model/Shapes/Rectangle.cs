using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(Point Location, int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor) : base(Location, tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            width = 75;
            height = 125;
            sprite = new RectangleSprite(this);

        }

        public override void Move()
        {
            Y += SpeedY*Direction;
        }
    }
}
