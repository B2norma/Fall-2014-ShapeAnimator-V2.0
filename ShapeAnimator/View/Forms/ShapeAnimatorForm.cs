using System;
using System.ComponentModel;
using System.Drawing;
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

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (this.isPaused == false)
            {
                this.updateGuiDataGrid();
                this.Refresh();
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

        private void loadInitialGrid()
        {
            this.dataGridForShapes.Rows.Clear();

            foreach (Shape currentShape in this.canvasManager.ShapesList)
            {
                this.dataGridForShapes.Rows.Add(currentShape.GetType().Name, this.formatColor(currentShape.Color),
                    currentShape.CalculatePerimeter(), currentShape.CalculateArea(), currentShape.HitCount,
                    currentShape.Id);

            }
        }

        private void sortButton_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn =
            dataGridForShapes.Columns.GetColumnCount(
            DataGridViewElementStates.Selected) == 1 ?
            dataGridForShapes.SelectedColumns[0] : null;

            if (newColumn.HeaderCell.ToString() == "Shape Type")
            {
                dataGridForShapes.Sort(dataGridForShapes.Columns[
                    "Shape Type"], ListSortDirection.Ascending);

                dataGridForShapes.Sort(dataGridForShapes.Columns[
                   "Color"], ListSortDirection.Ascending);
                
                
            }
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

        private void clearCanvas()
        {
            this.animationTimer.Stop();
            this.canvasManager.PlaceShapesOnCanvas(0, 0, 0, 0);
            this.animationTimer.Start();
        }

        #endregion

        private void ShapeAnimatorForm_Load(object sender, EventArgs e)
        {
            this.makeDataGridViewDoubleBuffered();
        }

        private void makeDataGridViewDoubleBuffered()
        {
            Type dgvType = this.dataGridForShapes.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridForShapes, true, null);
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

        private void AnimationSlider_Scroll(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void AnimationSlider_ValueChanged(object sender, EventArgs e)
        {
            this.animationTimer.Interval = (500 - this.AnimationSlider.Value + 1);
        }

        private void dataGridForShapes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sortButton_Click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}