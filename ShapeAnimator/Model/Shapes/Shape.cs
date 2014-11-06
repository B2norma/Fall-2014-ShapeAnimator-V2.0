using System;
using System.Drawing;
using ShapeAnimator.Utilities;
using ShapeAnimator.View;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     Holds information about the shape
    /// </summary>
    public abstract class Shape
    {
        #region Constants


        #endregion

        #region Instance variables

        private readonly Color shapeColor;
        private readonly int speedX;
        private readonly int speedY;
        private int directionX;
        private int directionY;
        private Point location;
        private ShapeSprite sprite;
        private int hitCount;
        private readonly int id;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the x location of the shape.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>
        public int X
        {
            get { return this.location.X; }
            set { this.location.X = value; }
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            get { return this.location.Y; }
            set { this.location.Y = value; }
        }

        /// <summary>
        ///     Gets
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width { get; private set; }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height { get; private set; }

        /// <summary>
        ///     Gets the sprite.
        /// </summary>
        /// <value>
        ///     The sprite.
        /// </value>
        protected ShapeSprite Sprite
        {
            set { this.sprite = value; }
        }

        /// <summary>
        ///     Gets the directionX.
        /// </summary>
        /// <value>
        ///     The directionX.
        /// </value>
        public int DirectionX
        {
            get { return this.directionX; }
        }

        /// <summary>
        ///     Gets the direction y.
        /// </summary>
        /// <value>
        ///     The direction y.
        /// </value>
        public int DirectionY
        {
            get { return this.directionY; }
        }

        /// <summary>
        ///     Gets the speed x.
        /// </summary>
        /// <value>
        ///     The speed x.
        /// </value>
        public int SpeedX
        {
            get { return this.speedX; }
        }

        /// <summary>
        ///     Gets the speed y.
        /// </summary>
        /// <value>
        ///     The speed y.
        /// </value>
        public int SpeedY
        {
            get { return this.speedY; }
        }

        /// <summary>
        ///     Gets the color.
        /// </summary>
        /// <value>
        ///     The color.
        /// </value>
        public Color Color
        {
            get { return this.shapeColor; }
        }

        /// <summary>
        /// Gets the hit count.
        /// </summary>
        /// <value>
        /// The hit count.
        /// </value>
        public int HitCount
        {
            get { return this.hitCount; }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return this.id; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        protected Shape()
        {
            this.shapeColor = RandomUtils.GenerateRandomColor();
            this.speedX = RandomUtils.GenerateRandomSpeed();
            this.speedY = RandomUtils.GenerateRandomSpeed();
            this.directionX = verifyDirectionValue(RandomUtils.GenerateRandomDirection());
            this.directionY = verifyDirectionValue(RandomUtils.GenerateRandomDirection());
            this.Width = RandomUtils.GenerateRandomHeightWidth();
            this.Height = RandomUtils.GenerateRandomHeightWidth();
            this.id = RandomUtils.GenerateRandomId();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Moves this instance.
        /// </summary>
        public void Move()
        {
            this.X += this.SpeedX*this.DirectionX;
            this.Y += this.SpeedY*this.DirectionY;
        }

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }
            this.sprite.Paint(g);
        }

        /// <summary>
        ///     Flips the X direction.
        /// </summary>
        public void DirectionXFlip()
        {
            hitCount++;
            this.directionX = this.directionX*-1;
        }

        /// <summary>
        ///     Flips the Y direction.
        /// </summary>
        public void DirectionYFlip()
        {
            hitCount++;
            this.directionY = this.directionY * -1;
        }


        private static int verifyDirectionValue(int randomDirection)
        {
            if (randomDirection == 0)
            {
                return -1;
            }
            return 1;
        }

        /// <summary>
        ///     Calculates the area of the shape.
        /// </summary>
        /// <returns> The area of the shape. </returns>
        public abstract double CalculateArea();

        /// <summary>
        ///     Calculates the perimeter of the shape.
        /// </summary>
        /// <returns> The parimeter of the shape. </returns>
        public abstract double CalculatePerimeter();

        #endregion
    }
}