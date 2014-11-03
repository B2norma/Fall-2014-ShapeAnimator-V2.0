using System;
using System.Collections.Generic;
using System.Drawing;
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

        #endregion

        #region Instance variables

        private readonly ShapeController canvasManager;

        private bool isPaused;

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
            if (this.isPaused == false)
            {
                this.updateGuiDataGrid();
                this.Refresh();
            }
        }

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void animateButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();
            this.canvasManager.PlaceShapesOnCanvas(this.NumberShapes, this.NumberCircles, this.NumberRectangles,
                this.NumberSpottedRectangles);
            this.animationTimer.Start();
            this.loadInitialGrid();

            this.enableButtonsForAnimation();
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (this.isPaused == false)
            {
                this.PauseResumeButton.Text = PauseButtonResume;
                this.isPaused = true;
            }
            else
            {
                this.PauseResumeButton.Text = PauseButtonPause;
                this.isPaused = false;
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
            if (e.ColumnIndex == 0)
            {
                IOrderedEnumerable<Shape> sortedShapes =
                    this.canvasManager.ShapesList.OrderBy(shape => shape.GetType().Name)
                        .ThenBy(shape => shape.Color.ToArgb());
                this.convertAndDisplayUpdatedList(sortedShapes);
            }
            else if (e.ColumnIndex == 1)
            {
                IOrderedEnumerable<Shape> sortedShapes =
                    this.canvasManager.ShapesList.OrderBy(shape => shape.Color.ToArgb());
                this.convertAndDisplayUpdatedList(sortedShapes);
            }
            else if (e.ColumnIndex == 4)
            {
                IOrderedEnumerable<Shape> sortedShapes =
                    this.canvasManager.ShapesList.OrderBy(shape => shape.HitCount).ThenBy(shape => shape.GetType().Name);
                this.convertAndDisplayUpdatedList(sortedShapes);
            }
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
                    }
                }
            }
        }

        private object formatColor(Color color)
        {
            return "(" + color.R + ", " + color.G + ", " + color.B + ")";
        }

        private double formatNumber(double numberToBeFormatted)
        {
            return (int)(numberToBeFormatted / NumberDisplayScale) * NumberDisplayScale;
        }

        private void makeDataGridViewDoubleBuffered()
        {
            Type dgvType = this.dataGridForShapes.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridForShapes, true, null);
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
        }

        private void resetButtons()
        {
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