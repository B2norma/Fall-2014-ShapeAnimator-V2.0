using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class Rectangle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Rectangle" /> class.
        ///     Pre: nothing can be null
        /// </summary>
        public Rectangle() : base()
        {
            this.Sprite = new RectangleSprite(this);
        }
    }
}