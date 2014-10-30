using ShapeAnimator.View.Shapes;
using System;

namespace ShapeAnimator.Model.Shapes
{
    internal class Circle : Shape
    {

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle() : base()
        {
            this.Sprite = new CircleSprite(this);
        }

        #endregion

        #region Methods
        
        public double CalculateArea()
        {
            return Math.PI * (this.Height / 2) * (this.Width / 2);
        }

        public double CalculatePerameter()
        {
            return (2 * Math.PI) * (Math.Sqrt((Math.Pow((this.Height / 2), 2) + Math.Pow((this.Width / 2), 2)) / 2));
        }

        #endregion

    }
}