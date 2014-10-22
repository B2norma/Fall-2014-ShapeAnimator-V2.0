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
        public Rectangle() : base(ShapeWidth, ShapeHeight)
        {
            this.Sprite = new RectangleSprite(this);
        }
    }
}