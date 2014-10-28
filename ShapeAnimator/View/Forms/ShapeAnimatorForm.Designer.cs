using System.Windows.Forms;

namespace ShapeAnimator.View.Forms
{
    partial class ShapeAnimatorForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.numberOfShapesLabel = new System.Windows.Forms.Label();
            this.numberShapesTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.CircleBox = new System.Windows.Forms.TextBox();
            this.RectangleBox = new System.Windows.Forms.TextBox();
            this.SpottedRectangleBox = new System.Windows.Forms.TextBox();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.SpottedRectangleLabel = new System.Windows.Forms.Label();
            this.PauseResumeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AnimationSlider = new System.Windows.Forms.TrackBar();
            this.AnimationSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(12, 58);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(720, 480);
            this.canvasPictureBox.TabIndex = 0;
            this.canvasPictureBox.TabStop = false;
            this.canvasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.shapeCanvasPictureBox_Paint);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // numberOfShapesLabel
            // 
            this.numberOfShapesLabel.AutoSize = true;
            this.numberOfShapesLabel.Location = new System.Drawing.Point(11, 19);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(96, 13);
            this.numberOfShapesLabel.TabIndex = 1;
            this.numberOfShapesLabel.Text = "Number of shapes:";
            // 
            // numberShapesTextBox
            // 
            this.numberShapesTextBox.Location = new System.Drawing.Point(113, 16);
            this.numberShapesTextBox.Name = "numberShapesTextBox";
            this.numberShapesTextBox.Size = new System.Drawing.Size(47, 20);
            this.numberShapesTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(732, 14);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // CircleBox
            // 
            this.CircleBox.Location = new System.Drawing.Point(210, 16);
            this.CircleBox.Name = "CircleBox";
            this.CircleBox.Size = new System.Drawing.Size(100, 20);
            this.CircleBox.TabIndex = 4;
            // 
            // RectangleBox
            // 
            this.RectangleBox.Location = new System.Drawing.Point(383, 16);
            this.RectangleBox.Name = "RectangleBox";
            this.RectangleBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleBox.TabIndex = 5;
            // 
            // SpottedRectangleBox
            // 
            this.SpottedRectangleBox.Location = new System.Drawing.Point(596, 16);
            this.SpottedRectangleBox.Name = "SpottedRectangleBox";
            this.SpottedRectangleBox.Size = new System.Drawing.Size(100, 20);
            this.SpottedRectangleBox.TabIndex = 6;
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Location = new System.Drawing.Point(166, 19);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(38, 13);
            this.CircleLabel.TabIndex = 7;
            this.CircleLabel.Text = "Circles";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(316, 19);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(61, 13);
            this.RectanglesLabel.TabIndex = 8;
            this.RectanglesLabel.Text = "Rectangles";
            // 
            // SpottedRectangleLabel
            // 
            this.SpottedRectangleLabel.AutoSize = true;
            this.SpottedRectangleLabel.Location = new System.Drawing.Point(489, 19);
            this.SpottedRectangleLabel.Name = "SpottedRectangleLabel";
            this.SpottedRectangleLabel.Size = new System.Drawing.Size(101, 13);
            this.SpottedRectangleLabel.TabIndex = 9;
            this.SpottedRectangleLabel.Text = "Spotted Rectangles";
            // 
            // PauseResumeButton
            // 
            this.PauseResumeButton.Enabled = false;
            this.PauseResumeButton.Location = new System.Drawing.Point(813, 14);
            this.PauseResumeButton.Name = "PauseResumeButton";
            this.PauseResumeButton.Size = new System.Drawing.Size(75, 23);
            this.PauseResumeButton.TabIndex = 10;
            this.PauseResumeButton.Text = "Pause";
            this.PauseResumeButton.UseVisualStyleBackColor = true;
            this.PauseResumeButton.Click += new System.EventHandler(this.PauseResumeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(894, 14);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AnimationSlider
            // 
            this.AnimationSlider.LargeChange = 100;
            this.AnimationSlider.Location = new System.Drawing.Point(738, 122);
            this.AnimationSlider.Maximum = 500;
            this.AnimationSlider.Name = "AnimationSlider";
            this.AnimationSlider.Size = new System.Drawing.Size(231, 45);
            this.AnimationSlider.SmallChange = 10;
            this.AnimationSlider.TabIndex = 12;
            this.AnimationSlider.TickFrequency = 50;
            this.AnimationSlider.Value = 50;
            // 
            // AnimationSpeedLabel
            // 
            this.AnimationSpeedLabel.AutoSize = true;
            this.AnimationSpeedLabel.Location = new System.Drawing.Point(738, 106);
            this.AnimationSpeedLabel.Name = "AnimationSpeedLabel";
            this.AnimationSpeedLabel.Size = new System.Drawing.Size(90, 13);
            this.AnimationSpeedLabel.TabIndex = 13;
            this.AnimationSpeedLabel.Text = "Animation Speed:";
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 545);
            this.Controls.Add(this.AnimationSpeedLabel);
            this.Controls.Add(this.AnimationSlider);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PauseResumeButton);
            this.Controls.Add(this.SpottedRectangleLabel);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.CircleLabel);
            this.Controls.Add(this.SpottedRectangleBox);
            this.Controls.Add(this.RectangleBox);
            this.Controls.Add(this.CircleBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberShapesTextBox);
            this.Controls.Add(this.numberOfShapesLabel);
            this.Controls.Add(this.canvasPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Nestrick and Norman";
            this.Load += new System.EventHandler(this.ShapeAnimatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label numberOfShapesLabel;
        private System.Windows.Forms.TextBox numberShapesTextBox;
        private System.Windows.Forms.Button startButton;
        private TextBox CircleBox;
        private TextBox RectangleBox;
        private TextBox SpottedRectangleBox;
        private Label CircleLabel;
        private Label RectanglesLabel;
        private Label SpottedRectangleLabel;
        private Button PauseResumeButton;
        private Button ClearButton;
        private TrackBar AnimationSlider;
        private Label AnimationSpeedLabel;
    }
}

