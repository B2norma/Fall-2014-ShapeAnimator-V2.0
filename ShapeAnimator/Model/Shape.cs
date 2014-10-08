using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Holds information about a shape
    /// </summary>
    public abstract class Shape
    {
        #region Instance variables

        private readonly Color shapeColor;
        private readonly int speedX;
        private readonly int speedY;
        private int direction;
        private Point location;
        private ShapeSprite sprite;

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
        public int Width { get; protected set; }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height { get; protected set; }

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
        ///     Gets the direction.
        /// </summary>
        /// <value>
        ///     The direction.
        /// </value>
        public int Direction
        {
            get { return this.direction; }
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

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        protected Shape()
        {
            this.sprite = new CircleSprite(this);
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        protected Shape(Point location) : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            this.location = location;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        /// <param name="tempDirection">The temporary direction.</param>
        /// <param name="tempSpeedX">The temporary speed x.</param>
        /// <param name="tempSpeedY">The temporary speed y.</param>
        /// <param name="tempColor">Color of the temporary.</param>
        protected Shape(int tempDirection, int tempSpeedX, int tempSpeedY, Color tempColor)
        {
            this.direction = tempDirection;
            this.speedX = tempSpeedX;
            this.speedY = tempSpeedY;
            this.shapeColor = tempColor;
            this.location = new Point(0, 0);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Moves this instance.
        /// </summary>
        public abstract void Move();

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
            this.checkBounds(g);
            this.sprite.Paint(g);
        }

        private void checkBounds(Graphics g)
        {
            if (this.X + this.Width > g.VisibleClipBounds.Width || this.Y + this.Height > g.VisibleClipBounds.Height ||
                this.X < 0 || this.Y < 0)
            {
                this.directionFlip();
                this.Move();
            }
        }

        private void directionFlip()
        {
            if (this.direction == 1)
            {
                this.direction = -1;
            }
            else
            {
                this.direction = 1;
            }
        }

        #endregion
    }
}