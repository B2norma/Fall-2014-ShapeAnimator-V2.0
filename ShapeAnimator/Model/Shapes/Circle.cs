using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class Circle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        ///     Pre: Nothing can be null.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="tempDirection">The temporary direction.</param>
        /// <param name="tempSpeedX">The temporary speed x.</param>
        /// <param name="tempSpeedY">The temporary speed y.</param>
        /// <param name="tempColor">Color of the Shape.</param>
        public Circle(Point location, int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor)
            : base(location, tempDirection, tempSpeedX, tempSpeedY, tempColor)
        {
            this.Width = 100;
            this.Height = 100;
            this.Sprite = new CircleSprite(this);
        }

        /// <summary>
        ///     Default constructor
        /// </summary>
        public override void Move()
        {
            this.X += this.SpeedX*this.Direction;
        }
    }
}