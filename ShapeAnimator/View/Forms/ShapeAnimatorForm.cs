using System;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Controller;

namespace ShapeAnimator.View.Forms
{
    /// <summary>
    ///     Manages the form that will display shapes.
    /// </summary>
    public partial class ShapeAnimatorForm
    {
        #region Constants

        private const int DefaultAnimationSpeed = 10;

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
                for (int i = 0; i < (this.AnimationSlider.Value/DefaultAnimationSpeed); i++)
                {
                    this.Refresh();
                }
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

        private void clearCanvas()
        {
            this.animationTimer.Stop();
            this.canvasManager.PlaceShapesOnCanvas(0, 0, 0, 0);
            this.animationTimer.Start();
        }

        #endregion

        private void ShapeAnimatorForm_Load(object sender, EventArgs e)
        {
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
    }
}