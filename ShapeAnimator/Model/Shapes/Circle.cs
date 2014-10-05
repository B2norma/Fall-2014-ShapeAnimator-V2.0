using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    class Circle : Shape
    {
        

        public Circle(Point Location, int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor) : base(Location, tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            width = 100;
            height = 100;
            sprite = new CircleSprite(this);
        }

        /// <summary>
        ///     Default constructor
        /// </summary>


        public override void Move()
        {
            X += SpeedX*Direction;
            return;
        }

    }
}
