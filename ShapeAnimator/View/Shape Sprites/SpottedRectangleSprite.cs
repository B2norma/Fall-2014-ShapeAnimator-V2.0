using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View
{
    /// <summary>
    ///     A Spotted Rectangle Sprite, inherits from the Rectangle Sprite.
    /// </summary>
    public class SpottedRectangleSprite : RectangleSprite
    {

        # region Constructors
        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedRectangleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="shape">The shape.</param>
        public SpottedRectangleSprite(Shape shape) : base(shape)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a LRectangle shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var redBrush = new SolidBrush(Color.IndianRed);
            g.FillEllipse(redBrush, this.TheShape.X + this.TheShape.Width/2, this.TheShape.Y + this.TheShape.Height/2,
                10, 10);
        }

        #endregion

    }
}