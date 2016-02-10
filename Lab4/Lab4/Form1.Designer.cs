namespace Lab4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(283, 262);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Box);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Box;
    }
}