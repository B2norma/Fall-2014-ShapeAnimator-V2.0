using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class Circle : Shape
    {
        private const int ShapeWidth = 100;
        private const int ShapeHeight = 100;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle() : base(ShapeWidth, ShapeHeight)
        {
            this.Sprite = new CircleSprite(this);
        }
    }
}