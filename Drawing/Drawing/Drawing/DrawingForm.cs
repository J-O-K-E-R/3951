using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    /// <summary>
    /// Authors: Jason Burns and Justin McLennan.
    /// 
    /// Date: Feb 15, 2016.
    /// 
    /// This is a program that draws on a form, using a color picker and drawing rectangles with a tracer.  It uses inheritance
    /// to determine what to draw.
    /// </summary>
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
            box.Image = new Bitmap(box.Width, box.Height);
            g = Graphics.FromImage(box.Image);
            rectg = box.CreateGraphics();
            current = rect;
            current.adjustBrushes();
        }

        Graphics g, rectg;
        
        Shape circ = new Circle();
        Shape rect = new Rectangle();
        Shape square = new Square();
        Shape scribble = new Scribble();

        Shape current;
       
        ColorDialog color = new ColorDialog();

        private void box_mouseMove(object sender, MouseEventArgs e)
        {
            current.x2 = e.X;
            current.y2 = e.Y;
            
            if(e.Button == MouseButtons.Left)
            {
                current.draw(g, rectg);
                box.Refresh();
            }
        }

        private void box_mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current.x = e.X;
                current.y = e.Y;
            }
        }

        private void box_mouseUp(object sender, MouseEventArgs e)
        {
            if (current == rect)
            {
                if (current.x > current.x2)
                {
                    int temp = current.x2;
                    current.x2 = current.x;
                    current.x = temp;
                }
                if (current.y > current.y2)
                {
                    int temp = current.y2;
                    current.y2 = current.y;
                    current.y = temp;
                }
                current.drawRectangle(g);
                box.Refresh();
            }
        }
        

        /// <summary>
        /// Grouping of all the menu button functionality, they switch the current shape to be a different one
        /// </summary>
        
        // rectangle click and hold functionality
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = rect;
        }
        // draw circle at point
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = circ;
        }
        // draw square at point
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = square;
        }

        private void scribbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = scribble;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                box.BackColor = color.Color;
            }
        }
        //color pen changes the outside of the gradient
        private void colorPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                current.edgeColor.Dispose();
                current.edge.Dispose();
                current.edge = new Pen(color.Color);
                current.edgeColor = new SolidBrush(color.Color);
                current.eColor[0] = color.Color;
                current.adjustBrushes();
            }
        }
        //color brush changes the inside of the gradient, doesnt change pen
        private void colorBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                current.fillColor.Dispose();
                current.fillColor = new SolidBrush(color.Color);
                current.fColor = color.Color;
                current.adjustBrushes();
            }
        }

        private void FormResize(object sender, System.EventArgs e)
        {
            Image temp = box.Image;
            box.Image = new Bitmap(box.Width, box.Height);
            g = Graphics.FromImage(box.Image);
            g.DrawImage(temp, 0, 0);
            box.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
