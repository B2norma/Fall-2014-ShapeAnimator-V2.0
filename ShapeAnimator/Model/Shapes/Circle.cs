using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    internal class Circle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle() : base()
        {
            this.Sprite = new CircleSprite(this);
        }
    }
}