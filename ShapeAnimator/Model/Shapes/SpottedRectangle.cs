using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class SpottedRectangle : Shape
    {
        private const int shapeWidth = 75;
        private const int shapeHeight = 125;
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
            this.Width = shapeWidth;
            this.Height = shapeHeight;
            this.Sprite = new SpottedRectangleSprite(this);
        }

        public override void Move()
        {
            this.Y += this.SpeedY*this.Direction;
        }
    }
}