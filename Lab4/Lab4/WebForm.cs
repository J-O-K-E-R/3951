using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Lab4 {
    public partial class WebForm : Form {
        public WebForm() {
            InitializeComponent();
        }
        private void URL_Location(object sender, EventArgs e) {

        }

        public void Ok_Click(object sender, EventArgs e) {
            string url = Location_URL.Text;

            Stream str = null;
            HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse wRes = (HttpWebResponse)(wReq).GetResponse();
            str = wRes.GetResponseStream();

            var imageOrig = System.Drawing.Image.FromStream(str);
            int height = imageOrig.Height;
            int width = imageOrig.Width;

            Form1 form = new Form1();
            form.MdiParent = Program.window;

            Bitmap img = new Bitmap(imageOrig);
            Size size = new Size(img.Width, img.Height);
            form.Box.Size = size;
            form.Box.BackgroundImage = img;
            form.Text = url;
            form.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
