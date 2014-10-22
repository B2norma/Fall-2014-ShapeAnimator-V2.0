using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class SpottedRectangle : Shape
    {
        private const int ShapeWidth = 75;
        private const int ShapeHeight = 125;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedRectangle" /> class.
        /// </summary>
        public SpottedRectangle() : base(ShapeWidth,ShapeHeight)
        {
            this.Sprite = new SpottedRectangleSprite(this);
        }
    }
}