using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.Properties;
using ShapeAnimator.Utilities;

namespace ShapeAnimator.Controller
{
    /// <summary>
    ///     Manages the collection of shapes on the canvas.
    /// </summary>
    public class ShapeController
    {

        #region Instance variables

        private readonly PictureBox canvas;
        private readonly List<Shape> shapesList;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the shapes list.
        /// </summary>
        /// <value>
        ///     The shapes list.
        /// </value>
        public List<Shape> ShapesList
        {
            get { return this.shapesList; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is paused.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is paused; otherwise, <c>false</c>.
        /// </value>
        public bool IsPaused { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeController" /> class from being created.
        /// </summary>
        private ShapeController()
        {
            this.shapesList = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeController" /> class.
        ///     Precondition: pictureBox != null
        /// </summary>
        /// <param name="pictureBox">The picture box that will be drawing on</param>
        public ShapeController(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }

            this.canvas = pictureBox;
            this.shapesList = new List<Shape>();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Places the shape on the canvas.
        ///     Precondition: None
        /// </summary>
        /// <param name="numberOfShapes">The number of shapes</param>
        /// <param name="numberOfCircles">The number of circles.</param>
        /// <param name="numberOfRectangles">The number of rectangles.</param>
        /// <param name="numberOfSpottedRectangles">The number of spotted circles.</param>
        public void PlaceShapesOnCanvas(int numberOfShapes, int numberOfCircles, int numberOfRectangles,
            int numberOfSpottedRectangles)
        {
                this.ShapesList.Clear();

                this.generateShapes(numberOfShapes);
                this.generateEllipses(numberOfCircles);
                this.generateRectangles(numberOfRectangles);
                this.generateSpottedRectangle(numberOfSpottedRectangles);
        }

        private void generateSpottedRectangle(int numberOfSpottedCircles)
        {
            for (int i = 0; i < numberOfSpottedCircles; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewSpottedRectangle();
                this.placeShapeWithinBoundsNotOverlapping(tempShape);
                this.ShapesList.Add(tempShape);
            }
        }

        private void generateRectangles(int numberOfRectangles)
        {
            for (int i = 0; i < numberOfRectangles; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewRectangle();
                this.placeShapeWithinBoundsNotOverlapping(tempShape);
                this.ShapesList.Add(tempShape);
            }
        }

        private void generateEllipses(int numberOfEllipses)
        {
            for (int i = 0; i < numberOfEllipses; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewEllipse();
                this.placeShapeWithinBoundsNotOverlapping(tempShape);
                this.ShapesList.Add(tempShape);
            }
        }

        private void generateShapes(int numberOfShapes)
        {
            for (int i = 0; i < numberOfShapes; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewShape();
                this.placeShapeWithinBoundsNotOverlapping(tempShape);
                this.ShapesList.Add(tempShape);
            }
        }

        private void placeShapeWithinBoundsNotOverlapping(Shape tempShape)
        {
            do
            {
                tempShape.X = RandomUtils.NextInt(this.canvas.Width - tempShape.Width);
                tempShape.Y = RandomUtils.NextInt(this.canvas.Height - tempShape.Height);
            } while (this.checkIfInitialPlacementValid(tempShape) == false);
        }

        private bool checkIfInitialPlacementValid(Shape tempShape)
        {
            foreach (Shape shape in this.shapesList)
            {
                if (this.isCollisionBetweenShapes(tempShape, shape))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        ///     Moves the shape around and the calls the Shape::Paint method to draw the shape.
        ///     Precondition: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw on</param>
        public void Update(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.ShapesList != null)
            {
                foreach (Shape shape in this.ShapesList)
                {
                    this.moveAndDrawShape(g, shape);
                }
            }
        }

        private void moveAndDrawShape(Graphics g, Shape shape)
        {
            if (!IsPaused)
            {
                this.moveTheShape(g, shape);
            }
            shape.Paint(g);
        }

        private void moveTheShape(Graphics g, Shape shape)
        {
            shape.Move();
            if (this.checkbounds(g, shape))
            {
                shape.Move();
            }
            this.loopThroughToCheckForCollissions(shape);
        }

        private bool checkbounds(Graphics g, Shape shape)
        {
            bool xOutOfBounds = this.verifyXBounds(g, shape);
            bool yOutOfBounds = this.verifyYBounds(g, shape);
            return (xOutOfBounds || yOutOfBounds);
        }

        private bool verifyYBounds(Graphics g, Shape shape)
        {
            if ((shape.Y + shape.Height) >= g.VisibleClipBounds.Height || shape.Y <= 0)
            {
                shape.DirectionYFlip();
                return true;
            }
            return false;
        }

        private bool verifyXBounds(Graphics g, Shape shape)
        {
            if ((shape.X + shape.Width) >= g.VisibleClipBounds.Width || shape.X <= 0)
            {
                shape.DirectionXFlip();
                return true;
            }
            return false;
        }

        #region Collision Detection

        private void loopThroughToCheckForCollissions(Shape shape)
        {
            foreach (Shape shapeToCompare in this.shapesList)
            {
                if (shape != shapeToCompare)
                {
                    this.collissionLogic(shape, shapeToCompare);
                }
            }
        }

        private void collissionLogic(Shape shape, Shape shapeToCompare)
        {
            if (this.isCollisionBetweenShapes(shape, shapeToCompare))
            {
                this.collissionCheckIfYDirectionSame(shape, shapeToCompare);
            }
        }

        private void collissionCheckIfYDirectionSame(Shape shape, Shape shapeToCompare)
        {
            if (shape.DirectionY == shapeToCompare.DirectionY)
            {
                this.collissionCheckIfXDirectionSameIfYSame(shape, shapeToCompare);
            }
            else
            {
                this.collissionCheckIfXDirectionSameIfYDifferent(shape, shapeToCompare);
            }
            shapeToCompare.Move();
            shape.Move();
        }

        private void collissionCheckIfXDirectionSameIfYDifferent(Shape shape, Shape shapeToCompare)
        {
            if (shape.DirectionX == shapeToCompare.DirectionX)
            {
                if (this.checkForTopOrBottomCollision(shape, shapeToCompare))
                {
                    shape.DirectionYFlip();
                    shapeToCompare.DirectionYFlip();
                }
                else
                {
                    shape.DirectionXFlip();
                }
            }
            else
            {
                if (this.checkForTopOrBottomCollision(shape, shapeToCompare))
                {
                    shape.DirectionYFlip();
                    shapeToCompare.DirectionYFlip();
                }
                else
                {
                    shape.DirectionXFlip();
                    shapeToCompare.DirectionXFlip();
                }
            }
        }

        private void collissionCheckIfXDirectionSameIfYSame(Shape shape, Shape shapeToCompare)
        {
            if (shape.DirectionX == shapeToCompare.DirectionX)
            {
                if (this.checkForTopOrBottomCollision(shape, shapeToCompare))
                {
                    shape.DirectionYFlip();
                }
                else
                {
                    shape.DirectionXFlip();
                }
            }
            else
            {
                if (this.checkForTopOrBottomCollision(shape, shapeToCompare))
                {
                    shape.DirectionYFlip();
                }
                else
                {
                    shape.DirectionXFlip();
                    shapeToCompare.DirectionXFlip();
                }
            }
        }

        private bool checkForTopOrBottomCollision(Shape shape, Shape shapeToCompare)
        {
            if (shape.X + shape.Width > shapeToCompare.X &&
                shape.X + shape.Width < shapeToCompare.X + shapeToCompare.Width)
            {
                return ifXandWidthCornerCheckForY(shape, shapeToCompare);
            }
            return ifXCornerCheckForY(shape, shapeToCompare);
        }

        private static bool ifXCornerCheckForY(Shape shape, Shape shapeToCompare)
        {
            if (shape.Y + shape.Height > shapeToCompare.Y &&
                shape.Y + shape.Height < shapeToCompare.Y + shapeToCompare.Height)
            {
                if (shapeToCompare.X + shapeToCompare.Width - (shape.X) > shape.Y + shape.Height - shapeToCompare.Y)
                {
                    return true;
                }
                return false;
            }
            if (shapeToCompare.X + shapeToCompare.Width - (shape.X) >
                shapeToCompare.Y + shapeToCompare.Height - shape.Y)
            {
                return true;
            }
            return false;
        }

        private static bool ifXandWidthCornerCheckForY(Shape shape, Shape shapeToCompare)
        {
            if (shape.Y + shape.Height > shapeToCompare.Y &&
                shape.Y + shape.Height < shapeToCompare.Y + shapeToCompare.Height)
            {
                if ((shape.X + shape.Width) - shapeToCompare.X > shape.Y + shape.Height - shapeToCompare.Y)
                {
                    return true;
                }
                return false;
            }
            if ((shape.X + shape.Width) - shapeToCompare.X > shapeToCompare.Y + shapeToCompare.Height - shape.Y)
            {
                return true;
            }
            return false;
        }

        private bool isCollisionBetweenShapes(Shape shape, Shape shapeToCompare)
        {
            if (shape.X < shapeToCompare.X + shapeToCompare.Width &&
                shape.X + shape.Width > shapeToCompare.X &&
                shape.Y < shapeToCompare.Y + shapeToCompare.Height &&
                shape.Y + shape.Height > shapeToCompare.Y)
            {
                return true;
            }
            return false;
        }

        #endregion

        #endregion
    }
}