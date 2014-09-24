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
        protected ShapeSprite(Shape theShape)
        {
            if (theShape == null)
            {
                throw new ArgumentNullException("theShape");
            }
            this.TheShape = theShape;
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public abstract void Paint(Graphics g);
    }
}