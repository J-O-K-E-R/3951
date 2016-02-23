using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4 {
    public partial class NewForm : Form {
        public NewForm() {
            InitializeComponent();
        }
        private string isChecked;
        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rbtn = (RadioButton) sender;
            switch (rbtn.Name)
            {
                case "radioButton1":
                    isChecked = "radioButton1";
                    break;
                case "radioButton2":
                    isChecked = "radioButton2";
                    break;
                case "radioButton3":
                    isChecked = "radioButton3";
                    break;
            }
        }
        private void radioButton_Click(object sender, EventArgs e) {
            RadioButton rbtn = (RadioButton)sender;
            switch (rbtn.Name)
            {
                case "radioButton1":
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "radioButton2":
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case "radioButton3":
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
            }
        }


        private void ok_Button_Click(object sender, EventArgs e) {
            Form1 form = new Form1();
            form.MdiParent = Program.window;
            Size size;
            switch (isChecked)
            {
                case "radioButton1":
                    size = new Size(640, 480);
                    form.Box.Size = size;
                    break;
                case "radioButton2":
                    size = new Size(800, 600);
                    form.Box.Size = size;
                    break;
                case "radioButton3":
                    size = new Size(1024, 768);
                    form.Box.Size = size;
                    break;
            }
            form.Box.BackColor = Color.Blue;
            form.Text = "New Image";
            form.Show();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
