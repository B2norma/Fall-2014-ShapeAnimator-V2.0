using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimator.Model
{
    class SpottedRectangle : Shape
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SpottedRectangle"/> class.
        /// </summary>
        /// <param name="Location">The location.</param>
        /// <param name="tempDirection">The direction.</param>
        /// <param name="tempSpeedX">The speed x.</param>
        /// <param name="tempSpeedY">The speed y.</param>
        /// <param name="tempColor">Color of the Shape.</param>
        public SpottedRectangle (Point Location, int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor) : base(Location, tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            width = 75;
            height = 125;
            this.sprite = new LRectangleSprite(this);
        }

        public override void Move()
        {
            Y += SpeedY*Direction;
        }
    }
}
