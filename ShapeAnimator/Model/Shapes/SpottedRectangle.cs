using ShapeAnimator.View;

namespace ShapeAnimator.Model.Shapes
{
    internal class SpottedRectangle : Rectangle
    {

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedRectangle" /> class.
        /// </summary>
        public SpottedRectangle()
        {
            this.Sprite = new SpottedRectangleSprite(this);
        }

        #endregion

    }
}