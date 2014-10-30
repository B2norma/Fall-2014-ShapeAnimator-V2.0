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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridForShapes = new System.Windows.Forms.DataGridView();
            this.shapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorForShape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerimiterForShape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaForShape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollisionsForShape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForShapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(4, 43);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(869, 429);
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
            this.numberOfShapesLabel.Location = new System.Drawing.Point(1, 24);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(96, 13);
            this.numberOfShapesLabel.TabIndex = 1;
            this.numberOfShapesLabel.Text = "Number of shapes:";
            // 
            // numberShapesTextBox
            // 
            this.numberShapesTextBox.Location = new System.Drawing.Point(103, 17);
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
            this.CircleLabel.Size = new System.Drawing.Size(41, 13);
            this.CircleLabel.TabIndex = 7;
            this.CircleLabel.Text = "Circles:";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(316, 19);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 8;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // SpottedRectangleLabel
            // 
            this.SpottedRectangleLabel.AutoSize = true;
            this.SpottedRectangleLabel.Location = new System.Drawing.Point(489, 19);
            this.SpottedRectangleLabel.Name = "SpottedRectangleLabel";
            this.SpottedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SpottedRectangleLabel.TabIndex = 9;
            this.SpottedRectangleLabel.Text = "Spotted Rectangles:";
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
            this.AnimationSlider.Location = new System.Drawing.Point(891, 163);
            this.AnimationSlider.Maximum = 500;
            this.AnimationSlider.Name = "AnimationSlider";
            this.AnimationSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.AnimationSlider.Size = new System.Drawing.Size(45, 231);
            this.AnimationSlider.SmallChange = 10;
            this.AnimationSlider.TabIndex = 12;
            this.AnimationSlider.TickFrequency = 50;
            this.AnimationSlider.Value = 10;
            this.AnimationSlider.Scroll += new System.EventHandler(this.AnimationSlider_Scroll);
            // 
            // AnimationSpeedLabel
            // 
            this.AnimationSpeedLabel.AutoSize = true;
            this.AnimationSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AnimationSpeedLabel.Location = new System.Drawing.Point(879, 134);
            this.AnimationSpeedLabel.Name = "AnimationSpeedLabel";
            this.AnimationSpeedLabel.Size = new System.Drawing.Size(90, 13);
            this.AnimationSpeedLabel.TabIndex = 13;
            this.AnimationSpeedLabel.Text = "Animation Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Slower";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(891, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Faster";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "x0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "x1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(916, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "x5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "x4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(916, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "x3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(916, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "x2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(915, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "x9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(916, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "x8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(916, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "x7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(915, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "x10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(915, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "x6";
            // 
            // dataGridForShapes
            // 
            this.dataGridForShapes.AllowUserToAddRows = false;
            this.dataGridForShapes.AllowUserToDeleteRows = false;
            this.dataGridForShapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridForShapes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShapeType,
            this.ColorForShape,
            this.PerimiterForShape,
            this.AreaForShape,
            this.CollisionsForShape});
            this.dataGridForShapes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridForShapes.Location = new System.Drawing.Point(4, 479);
            this.dataGridForShapes.MultiSelect = false;
            this.dataGridForShapes.Name = "dataGridForShapes";
            this.dataGridForShapes.Size = new System.Drawing.Size(869, 315);
            this.dataGridForShapes.TabIndex = 27;
            // 
            // shapeBindingSource
            // 
            this.shapeBindingSource.DataSource = typeof(ShapeAnimator.Model.Shapes.Shape);
            // 
            // ShapeType
            // 
            this.ShapeType.HeaderText = "Shape Type";
            this.ShapeType.Name = "ShapeType";
            // 
            // ColorForShape
            // 
            this.ColorForShape.HeaderText = "Color";
            this.ColorForShape.Name = "ColorForShape";
            // 
            // PerimiterForShape
            // 
            this.PerimiterForShape.HeaderText = "Perimiter";
            this.PerimiterForShape.Name = "PerimiterForShape";
            // 
            // AreaForShape
            // 
            this.AreaForShape.HeaderText = "Area";
            this.AreaForShape.Name = "AreaForShape";
            // 
            // CollisionsForShape
            // 
            this.CollisionsForShape.HeaderText = "Collision Count";
            this.CollisionsForShape.Name = "CollisionsForShape";
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 806);
            this.Controls.Add(this.dataGridForShapes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForShapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).EndInit();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridForShapes;
        private BindingSource shapeBindingSource;
        private DataGridViewTextBoxColumn ShapeType;
        private DataGridViewTextBoxColumn ColorForShape;
        private DataGridViewTextBoxColumn PerimiterForShape;
        private DataGridViewTextBoxColumn AreaForShape;
        private DataGridViewTextBoxColumn CollisionsForShape;
    }
}

