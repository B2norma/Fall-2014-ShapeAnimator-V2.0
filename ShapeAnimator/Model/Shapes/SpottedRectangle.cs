using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class SpottedRectangle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedRectangle" /> class.
        /// </summary>
        public SpottedRectangle() : base()
        {
            this.Sprite = new SpottedRectangleSprite(this);
        }
    }
}