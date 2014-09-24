using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    /// Holds all common attributes of shapes. 
    /// </summary>
    public abstract class ShapeSprite
    {
        #region Instance variables

        /// <summary>
        /// The actual shape object. 
        /// </summary>
        protected readonly Shape theShape;

        #endregion

        protected ShapeSprite()
        {
            theShape = null;
        }

        protected ShapeSprite(Shape theShape)
        {
            if (theShape == null)
            {
                throw new ArgumentNullException("shape");
            }
            this.theShape = theShape;
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public abstract void Paint(Graphics g);
    }
}
