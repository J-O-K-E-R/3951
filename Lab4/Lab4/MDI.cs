using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Lab4
{
    /// <summary>
    /// The Main class of the program
    /// </summary>
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create a child MDI panel
        /// The image is retrieved from the web
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void openFromWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebForm frm = new WebForm();
            frm.Show();

        }
        /// <summary>
        /// Creats a dialog for selecting the image size
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            NewForm nfrm = new NewForm();
            nfrm.Show();
        }
        /// <summary>
        /// Creates an open dialog
        /// if OK create Image of selected size
        /// if CANCEL close dialog
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
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
        /// <summary>
        /// Sets the window layout as Cascade
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        /// <summary>
        /// Sets the window layout as Horizontal
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// Sets the window layout as Vertical
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        /// <summary>
        /// Saves and/or overwrites an image in a choosen location
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            Form1 imageForm = (Form1)ActiveMdiChild;
            Image image = imageForm.BackgroundImage;
            if (image != null)
            {
                try
                {
                    image.Save(saveFileDialog1.FileName);
                    imageForm.IsSaved = true;
                }
                catch (System.ArgumentException ex)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|JPEG Files (*.jpeg)|*.jpeg|Bitmap Image(*.bmp)|*.bmp";
            saveFileDialog1.DefaultExt = "jpeg";
            if (saveFileDialog1.ShowDialog(ActiveMdiChild) == DialogResult.OK)
            {
                Form1 imageForm = (Form1)ActiveMdiChild;
                Image image = imageForm.BackgroundImage;
                if (image != null)
                {
                    image.Save(saveFileDialog1.FileName);
                    imageForm.IsSaved = true;
                }
            }
        }
        /// <summary>
        /// Ends the program 
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

            while (ActiveMdiChild != null)
            {
                Form1 imageForm = (Form1)ActiveMdiChild;
                if (imageForm.IsSaved == false)
                {
                    if (MessageBox.Show("Save your changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        saveAsToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        imageForm.Close();
                    }
                }
                imageForm.Close();
            }
            this.Close();
        }
        /// <summary>
        /// Selects the state of the "Save" or "Save As" button.
        /// If an MDIchild is open the buttons are enabled
        /// If no MDIchildren are open the buttons are disabled
        /// </summary>
        /// <param name="sender"> Object calling the event </param>
        /// <param name="e"> The event argument</param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
            if ((Form)this.ActiveMdiChild != null)
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
            }
        }
    }
}
