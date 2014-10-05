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

        protected ShapeSprite sprite;
        private Point location;
        protected int width;
        protected int height;
        private int direction;
        private readonly int speedX;
        private readonly int speedY;


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

        public int Width
        {
            get { return this.width; }
            protected set { width = value; }
        }

        public int Height
        {
            get { return this.height;  }
            protected set { height = value; }
        }

        public int Direction
        {
            get { return this.direction; }
        }

        public int SpeedX
        {
            get { return this.speedX; }
        }

        public int SpeedY
        {
            get { return this.speedY; }
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

        protected Shape(Point Location, int tempDirection, int tempSpeedX, int tempSpeedY) : this(Location)
        {
            this.direction = tempDirection;
            this.speedX = tempSpeedX;
            this.speedY = tempSpeedY;
        }

        /// <summary>
        ///     Constructs a shape specified x,y location
        ///     Precondition: None
        ///     Postcondition: X == x; Y == y
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// ///
        /// <param name="tempRandom">Random number generator</param>

        #endregion

        #region Methods

        /// <summary>
        ///     Randomly moves a shape in the x, y direction
        ///     Precondition: None
        ///     Postcondition: X == X@prev + amount of movement in X direction; Y == Y@prev + amount of movement in Y direction
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
            checkBounds(g);
            this.sprite.Paint(g);
        }

        private void checkBounds(Graphics g)
        {
            if (this.X + this.Width > g.VisibleClipBounds.Width || this.Y + this.Height > g.VisibleClipBounds.Height || this.X < 0 || this.Y < 0)
            {
                directionFlip();
                this.Move();
            }
        }

        private void directionFlip()
        {
            if (direction == 1)
            {
                direction = -1;
            }
            else
            {
                direction = 1;
            }
        }



        #endregion
    }
}