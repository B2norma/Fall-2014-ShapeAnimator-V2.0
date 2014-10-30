using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Properties;

namespace ShapeAnimator.Model
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
            this.shapesList.Clear();

            this.generateShapes(numberOfShapes);
            this.generateCircles(numberOfCircles);
            this.generateRectangles(numberOfRectangles);
            this.generateSpottedRectangle(numberOfSpottedRectangles);
        }

        private void generateSpottedRectangle(int numberOfSpottedCircles)
        {
            for (int i = 0; i < numberOfSpottedCircles; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewSpottedRectangle();
                this.placeShapeWithinBounds(tempShape);
                this.shapesList.Add(tempShape);
            }
        }

        private void generateRectangles(int numberOfRectangles)
        {
            for (int i = 0; i < numberOfRectangles; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewRectangle();
                this.placeShapeWithinBounds(tempShape);
                this.shapesList.Add(tempShape);
            }
        }

        private void generateCircles(int numberOfCircles)
        {
            for (int i = 0; i < numberOfCircles; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewCircle();
                this.placeShapeWithinBounds(tempShape);
                this.shapesList.Add(tempShape);
            }
        }

        private void generateShapes(int numberOfShapes)
        {
            for (int i = 0; i < numberOfShapes; i++)
            {
                Shape tempShape = ShapeFactory.CreateNewShape();
                this.placeShapeWithinBounds(tempShape);
                this.shapesList.Add(tempShape);
            }
        }

        private void placeShapeWithinBounds(Shape tempShape)
        {

            tempShape.X = RandomUtils.NextInt(this.canvas.Width - tempShape.Width);
            tempShape.Y = RandomUtils.NextInt(this.canvas.Height - tempShape.Height);
            
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

            if (this.shapesList != null)
            {
                foreach (Shape shape in this.shapesList)
                {
                    moveAndDrawShape(g, shape);
                }
            }
        }

        private static void moveAndDrawShape(Graphics g, Shape shape)
        {
            checkbounds(g, shape);
            shape.Move();
            shape.Paint(g);
        }

        private static void checkbounds(Graphics g, Shape shape)
        {
            verifyXBounds(g, shape);
            verifyYBounds(g, shape);
        }

        private static void verifyYBounds(Graphics g, Shape shape)
        {
            if ((shape.Y + shape.Height + shape.SpeedY) >= g.VisibleClipBounds.Height || shape.Y - shape.SpeedY <= 0)
            {
                shape.DirectionYFlip();
            }
        }

        private static void verifyXBounds(Graphics g, Shape shape)
        {
            if ((shape.X + shape.Width + shape.SpeedX) >= g.VisibleClipBounds.Width || shape.X - shape.SpeedX <= 0)
            {
                shape.DirectionXFlip();
            }
        }

        #endregion

    }
}