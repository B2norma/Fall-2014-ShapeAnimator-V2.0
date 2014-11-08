using System;
using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View
{
    /// <summary>
    ///     Holds all common attributes of shapes.
    /// </summary>
    public abstract class ShapeSprite
    {
        #region Properties

        /// <summary>
        ///     Gets the value of theShape variable.
        /// </summary>
        /// <value>
        ///     theShape.
        /// </value>
        protected Shape TheShape { get; set; }

        #endregion

        #region Constructors

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

        #endregion

        #region Methods

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

        #endregion
    }
}