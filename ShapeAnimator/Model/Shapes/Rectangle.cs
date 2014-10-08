using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class Rectangle : Shape
    {
        private const int ShapeWidth = 75;
        private const int ShapeHeight = 125;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rectangle" /> class.
        ///     Pre: nothing can be null
        /// </summary>
        /// <param name="tempDirection">The direction.</param>
        /// <param name="tempSpeedX">The speed x.</param>
        /// <param name="tempSpeedY">The speed y.</param>
        /// <param name="tempColor">Color of the Shape.</param>
        public Rectangle(int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor)
            : base(tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            this.Width = ShapeWidth;
            this.Height = ShapeHeight;
            this.Sprite = new RectangleSprite(this);
        }

        public override void Move()
        {
            this.Y += this.SpeedY*this.Direction;
        }
    }
}