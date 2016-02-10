using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace Lab4
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void openFromWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebForm frm = new WebForm();
            frm.Show();

        }

        private void box_click(object sender, EventArgs e) {

        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.InitialDirectory = @"X:\Wallpaper";
            openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|JPEG Files (*.jpeg)|*.jpeg|Bitmap Image(*.bmp)|*.bmp";
            openFileDialog1.Multiselect = true;
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form1 form = new Form1();
                form.MdiParent = this;
                Bitmap img = new Bitmap(openFileDialog1.FileName);
                Size size = new Size(img.Width, img.Height);
                form.Box.Size = size;
                form.Box.BackgroundImage = img;
                form.Text = openFileDialog1.FileName;
                form.Show();
            }
        }
    }
}
