using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Holds all common attributes of shapes.
    /// </summary>
    public abstract class ShapeSprite
    {
        #region Properties
        public int width { get; private set; }
        public int height { get; private set; }
        #endregion
        #region Instance variables

        /// <summary>
        ///     The shape object.
        /// </summary>
        protected readonly Shape TheShape;
        #endregion

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeSprite" /> class from being created.
        /// </summary>
        protected ShapeSprite()
        {
            this.TheShape = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeSprite" /> class.
        /// </summary>
        /// <param name="theShape">The shape.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        protected ShapeSprite(Shape theShape,int tempWidth, int tempHeight)
        {
            if (theShape == null)
            {
                throw new ArgumentNullException("theShape");
            }
            width = tempWidth;
            height = tempHeight;
            this.TheShape = theShape;
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public virtual void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.TheShape == null)
            {
                throw new Exception("Shape is null");
            }
        }

    }
}