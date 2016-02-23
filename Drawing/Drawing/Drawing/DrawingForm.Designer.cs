namespace Drawing
{
    partial class DrawingForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scribbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorGradientBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insideColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outsideColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawingToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // drawingToolStripMenuItem
            // 
            this.drawingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.scribbleToolStripMenuItem});
            this.drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            this.drawingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.drawingToolStripMenuItem.Text = "Drawing";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // scribbleToolStripMenuItem
            // 
            this.scribbleToolStripMenuItem.Name = "scribbleToolStripMenuItem";
            this.scribbleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.scribbleToolStripMenuItem.Text = "Scribble";
            this.scribbleToolStripMenuItem.Click += new System.EventHandler(this.scribbleToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.colorPenToolStripMenuItem,
            this.colorBrushToolStripMenuItem,
            this.colorGradientBrushToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // colorPenToolStripMenuItem
            // 
            this.colorPenToolStripMenuItem.Name = "colorPenToolStripMenuItem";
            this.colorPenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.colorPenToolStripMenuItem.Text = "Color Pen";
            this.colorPenToolStripMenuItem.Click += new System.EventHandler(this.colorPenToolStripMenuItem_Click);
            // 
            // colorBrushToolStripMenuItem
            // 
            this.colorBrushToolStripMenuItem.Name = "colorBrushToolStripMenuItem";
            this.colorBrushToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.colorBrushToolStripMenuItem.Text = "Color Brush";
            this.colorBrushToolStripMenuItem.Click += new System.EventHandler(this.colorBrushToolStripMenuItem_Click);
            // 
            // colorGradientBrushToolStripMenuItem
            // 
            this.colorGradientBrushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insideColorToolStripMenuItem,
            this.outsideColorToolStripMenuItem});
            this.colorGradientBrushToolStripMenuItem.Name = "colorGradientBrushToolStripMenuItem";
            this.colorGradientBrushToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.colorGradientBrushToolStripMenuItem.Text = "Color Gradient Brush";
            // 
            // insideColorToolStripMenuItem
            // 
            this.insideColorToolStripMenuItem.Name = "insideColorToolStripMenuItem";
            this.insideColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.insideColorToolStripMenuItem.Text = "Inside Color";
            this.insideColorToolStripMenuItem.Click += new System.EventHandler(this.colorBrushToolStripMenuItem_Click);
            // 
            // outsideColorToolStripMenuItem
            // 
            this.outsideColorToolStripMenuItem.Name = "outsideColorToolStripMenuItem";
            this.outsideColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.outsideColorToolStripMenuItem.Text = "Outside Color";
            this.outsideColorToolStripMenuItem.Click += new System.EventHandler(this.colorPenToolStripMenuItem_Click);
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box.BackColor = System.Drawing.Color.White;
            this.box.Location = new System.Drawing.Point(0, 27);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(1920, 1080);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box.TabIndex = 1;
            this.box.TabStop = false;
            this.box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_mouseDown);
            this.box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.box_mouseMove);
            this.box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.box_mouseUp);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 411);
            this.Controls.Add(this.box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawingForm";
            this.Text = "Draw";
            this.Resize += new System.EventHandler(this.FormResize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scribbleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorGradientBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insideColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outsideColorToolStripMenuItem;
        private System.Windows.Forms.PictureBox box;
    }
}

