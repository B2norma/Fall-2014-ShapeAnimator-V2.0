using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ShapeAnimator.Controller;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Forms
{
    /// <summary>
    ///     Manages the form that will display shapes.
    /// </summary>
    public partial class ShapeAnimatorForm
    {
        #region Constants

        private const string PauseButtonPause = "Pause";

        private const string PauseButtonResume = "Resume";

        private const double NumberDisplayScale = .001;

        private const int MaxNumberOfShapes = 10;

        #endregion

        #region Instance variables

        private readonly ShapeController canvasManager;
        private bool colorSelected;

        private bool hitCountSelected;
        private bool isPaused;

        private bool nameSelected;

        #endregion

        #region Properties

        /// <summary>
        ///     Converts the text in the numberShapesTextBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        public int NumberShapes
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.numberShapesTextBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        /// <summary>
        ///     Converts the text in the CircleBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        public int NumberCircles
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.CircleBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        /// <summary>
        ///     Converts the text in the RectangleBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        public int NumberRectangles
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.RectangleBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        /// <summary>
        ///     Converts the text in the SpottedCircleBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        public int NumberSpottedRectangles
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.SpottedRectangleBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeAnimatorForm" /> class.
        ///     Precondition: None
        /// </summary>
        public ShapeAnimatorForm()
        {
            this.InitializeComponent();

            this.canvasManager = new ShapeController(this.canvasPictureBox);
        }

        #endregion

        #region Event generated methods

        private void ShapeAnimatorForm_Load(object sender, EventArgs e)
        {
            this.makeDataGridViewDoubleBuffered();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.updateGuiDataGrid();
            if (this.hitCountSelected)
            {
                this.sortGridByCountThenName();
            }
            this.Refresh();
        }

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void animateButton_Click(object sender, EventArgs e)
        {
            if (this.NumberShapes + this.NumberCircles + this.NumberRectangles + this.NumberSpottedRectangles <=
                MaxNumberOfShapes)
            {
                this.animationTimer.Stop();
                this.canvasManager.PlaceShapesOnCanvas(this.NumberShapes, this.NumberCircles, this.NumberRectangles,
                    this.NumberSpottedRectangles);
                this.animationTimer.Start();
                this.loadInitialGrid();

                this.enableButtonsForAnimation();
            }
            else
            {
                MessageBox.Show("The max number of shapes allowed on the screen is " + MaxNumberOfShapes + ".", 
                    "Too Many Shapes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (this.isPaused == false)
            {
                this.PauseResumeButton.Text = PauseButtonResume;
                this.isPaused = true;
                this.canvasManager.IsPaused = this.isPaused;
            }
            else
            {
                this.PauseResumeButton.Text = PauseButtonPause;
                this.isPaused = false;
                this.canvasManager.IsPaused = this.isPaused;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.resetButtons();
            this.clearCanvas();
        }

        private void AnimationSlider_ValueChanged(object sender, EventArgs e)
        {
            this.animationTimer.Interval = (500 - this.AnimationSlider.Value + 1);
        }

        private void dataGridForShapes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.nameSelected = false;
            this.hitCountSelected = false;
            this.colorSelected = false;
            if (e.ColumnIndex == 0)
            {
                this.sortGridByNameThenColor();
            }
            else if (e.ColumnIndex == 1)
            {
                this.sortGridByColor();
            }
            else if (e.ColumnIndex == 4)
            {
                this.sortGridByCountThenName();
            }
        }

        private void pictureBox_MouseClick(object sender, EventArgs e)
        {
            if (this.isPaused)
            {
                var cursor = (MouseEventArgs) e;
                Point clickedPoint = cursor.Location;

                foreach (Shape currentShape in this.canvasManager.ShapesList)
                {
                    foreach (Point currentPoint in currentShape.GetShapePoints())
                    {
                        if (this.checkIfShapeIsAtPoint(clickedPoint, currentPoint, currentShape))
                        {
                            return;
                        }
                    }
                }
            }
        }

        private bool checkIfShapeIsAtPoint(Point clickedPoint, Point currentPoint, Shape currentShape)
        {
            if (clickedPoint.Equals(currentPoint))
            {
                var colorChooser = new ColorDialog {AllowFullOpen = true, Color = currentShape.Color};
                colorChooser.ShowDialog();
                currentShape.Color = colorChooser.Color;
                if (this.nameSelected)
                {
                    this.sortGridByNameThenColor();
                }
                else if (this.colorSelected)
                {
                    this.sortGridByColor();
                }
                return true;
            }
            return false;
        }

        #endregion

        #region Private Methods

        #region Grid Related Methods

        private void loadInitialGrid()
        {
            this.loadNewGrid(this.canvasManager.ShapesList);
        }

        private void loadNewGrid(IEnumerable<Shape> shapeList)
        {
            this.dataGridForShapes.Rows.Clear();

            foreach (Shape currentShape in shapeList)
            {
                this.dataGridForShapes.Rows.Add(currentShape.GetType().Name, this.formatColor(currentShape.Color),
                    this.formatNumber(currentShape.CalculatePerimeter()),
                    this.formatNumber(currentShape.CalculateArea()), currentShape.HitCount,
                    currentShape.Id);
            }
        }

        private void updateGuiDataGrid()
        {
            foreach (DataGridViewRow currentRow in this.dataGridForShapes.Rows)
            {
                foreach (Shape currentShape in this.canvasManager.ShapesList)
                {
                    if ((int) currentRow.Cells[5].Value == currentShape.Id)
                    {
                        currentRow.Cells[4].Value = currentShape.HitCount;
                        currentRow.Cells[1].Value = this.formatColor(currentShape.Color);
                    }
                }
            }
        }

        private object formatColor(Color color)
        {
            return "(" + color.R + ", " + color.G + ", " + color.B + ")";
        }

        private string formatNumber(double numberToBeFormatted)
        {
            String number =
                ((int) (numberToBeFormatted/NumberDisplayScale)*NumberDisplayScale).ToString(
                    CultureInfo.InvariantCulture);
            int pos = number.IndexOf('.');
            if (pos == -1)
            {
                pos = number.Length;
            }

            return (new String(' ', 6 - pos) + number);
        }

        private void makeDataGridViewDoubleBuffered()
        {
            Type dgvType = this.dataGridForShapes.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridForShapes, true, null);
        }

        private void sortGridByNameThenColor()
        {
            this.nameSelected = true;
            IOrderedEnumerable<Shape> sortedShapes =
                this.canvasManager.ShapesList.OrderBy(shape => shape.GetType().Name)
                    .ThenBy(shape => shape.Color.ToArgb());
            this.convertAndDisplayUpdatedList(sortedShapes);
        }

        private void sortGridByColor()
        {
            this.colorSelected = true;
            IOrderedEnumerable<Shape> sortedShapes =
                this.canvasManager.ShapesList.OrderBy(shape => shape.Color.ToArgb());
            this.convertAndDisplayUpdatedList(sortedShapes);
        }

        private void sortGridByCountThenName()
        {
            this.hitCountSelected = true;
            IOrderedEnumerable<Shape> sortedShapes =
                this.canvasManager.ShapesList.OrderBy(shape => shape.HitCount).ThenBy(shape => shape.GetType().Name);
            this.convertAndDisplayUpdatedList(sortedShapes);
        }

        #endregion

        private void clearCanvas()
        {
            this.animationTimer.Stop();
            this.canvasManager.PlaceShapesOnCanvas(0, 0, 0, 0);
            this.animationTimer.Start();
        }

        private void enableButtonsForAnimation()
        {
            this.PauseResumeButton.Enabled = true;
            this.ClearButton.Enabled = true;
            this.isPaused = false;
            this.startButton.Enabled = false;
            this.CircleBox.Enabled = false;
            this.RectangleBox.Enabled = false;
            this.numberShapesTextBox.Enabled = false;
        }

        private void resetButtons()
        {
            this.dataGridForShapes.Rows.Clear();
            this.numberShapesTextBox.Clear();
            this.CircleBox.Clear();
            this.RectangleBox.Clear();
            this.startButton.Enabled = true;
            this.CircleBox.Enabled = true;
            this.RectangleBox.Enabled = true;
            this.numberShapesTextBox.Enabled = true;
            this.isPaused = false;
            this.PauseResumeButton.Text = PauseButtonPause;
            this.PauseResumeButton.Enabled = false;
            this.ClearButton.Enabled = false;
            this.startButton.Enabled = true;
        }

        private void convertAndDisplayUpdatedList(IEnumerable<Shape> sortedShapes)
        {
            var tempShapes = new List<Shape>();
            foreach (Shape shape in sortedShapes)
            {
                tempShapes.Add(shape);
            }
            this.loadNewGrid(tempShapes);
        }

        #endregion
    }
}