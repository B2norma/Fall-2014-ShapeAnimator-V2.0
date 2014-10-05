using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class SpottedRectangle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedRectangle" /> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="tempDirection">The direction.</param>
        /// <param name="tempSpeedX">The speed x.</param>
        /// <param name="tempSpeedY">The speed y.</param>
        /// <param name="tempColor">Color of the Shape.</param>
        public SpottedRectangle(Point location, int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor)
            : base(location, tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            this.Width = 75;
            this.Height = 125;
            this.Sprite = new SpottedRectangleSprite(this);
        }

        public override void Move()
        {
            this.Y += this.SpeedY*this.Direction;
        }
    }
}