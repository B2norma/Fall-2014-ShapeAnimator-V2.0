using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View
{
    /// <summary>
    ///     A Rectangle Sprite, inherits from ShapeSprite.
    /// </summary>
    public class RectangleSprite : ShapeSprite
    {

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="shape">The shape.</param>
        public RectangleSprite(Shape shape) : base(shape)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var theBrush = new SolidBrush(this.TheShape.Color);
            g.FillRectangle(theBrush, this.TheShape.X, this.TheShape.Y, this.TheShape.Width, this.TheShape.Height);
        }

        #endregion

    }
}