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


        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="Location">The location.</param>
        /// <param name="tempDirection">The temporary direction.</param>
        /// <param name="tempSpeedX">The temporary speed x.</param>
        /// <param name="tempSpeedY">The temporary speed y.</param>
        /// <param name="tempColor">Color of the Shape.</param>
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
