using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShapeAnimator.Properties;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Manages the collection of shapes on the canvas.
    /// </summary>
    public class CanvasManager
    {
        #region Instance variables

        private readonly PictureBox canvas;
        private List<Shape> shapesList;

        #endregion

        #region Constructors

        /// <summary>
        /// Prevents a default instance of the <see cref="CanvasManager"/> class from being created.
        /// </summary>
        private CanvasManager()
        {
            this.shapesList = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CanvasManager" /> class.
        ///     Precondition: pictureBox != null
        /// </summary>
        /// <param name="pictureBox">The picture box that will be drawing on</param>
        public CanvasManager(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }

            this.canvas = pictureBox;
            this.shapesList = new List<Shape>();
        }

        #endregion

        /// <summary>
        ///     Places the shape on the canvas.
        ///     Precondition: None
        /// </summary>
        /// <param name="numberOfShapes"></param>
        public void PlaceShapesOnCanvas(int numberOfShapes)
        {
            var randomizer = new Random();
            for (int i = 0; i < numberOfShapes; i++)
            {
            int x = randomizer.Next(this.canvas.Width);
            int y = randomizer.Next(this.canvas.Height);

                String randomShapeSprite;
                int tempInteger = randomizer.Next(3);
                if (tempInteger == 0)
                {
                    randomShapeSprite = "circle";
                }
                else if (tempInteger == 1)
                {
                    randomShapeSprite = "rectangle";
                }
                else
                {
                    randomShapeSprite = "lRectangle";
                }

            this.shapesList.Add(new Shape(x, y,randomizer,randomShapeSprite));

        }
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

           if (shapesList != null)
            {
                foreach (Shape shape in shapesList)
                {
                    moveAndDrawShape(g, shape);
                }
           }

        }

        private static void moveAndDrawShape(Graphics g, Shape shape)
        {
            shape.Move();
            shape.Paint(g);
        }
    }
}