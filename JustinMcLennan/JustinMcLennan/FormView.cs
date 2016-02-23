using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JustinMcLennan
{
    /// <summary>
    /// This will draw a moving square
    /// Author: Justin McLennan
    /// </summary>
    public partial class FormView : Form
    {
        /// <summary>
        /// Different directions that the box can move are marked here
        /// </summary>
        enum Position
        {
            DLeft, DRight, ULeft, URight
        }
        //all used variables are put here since they are used 
        //throughout multiple methods
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private Color color1 = rancolor();
        private Color color2 = rancolor();
        private Position _objPosition;

        public FormView()
        {
            InitializeComponent();
            _x = 50;
            _y = 50;
            _width = this.ClientRectangle.Width/10;
            _height = this.ClientRectangle.Width/10;
            _objPosition = Position.DLeft;
        }
        /// <summary>
        /// Used to generate 2 random colors for inside square
        /// </summary>
        /// <returns></returns>
        private static Color rancolor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            return randomColor;
        }
        /// <summary>
        /// Draws the box and creates the brush for it
        /// This is not a class noticed the requirement too late to implement properly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            //create a square for the path
            Rectangle myRec = new Rectangle(_x, _y, _width, _height);
            path.AddRectangle(myRec);
            //create a gradient brush
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            Color[] color = { Color.Orange, color1, color2 };
            float[] relativePositions = {
                0f,       
                0.4f,     
                1.0f};
            //creates a color blend with orange and 2 random colors
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = color;
            //marks positions of the colors
            colorBlend.Positions = relativePositions;
            //adds the colors to the path
            pthGrBrush.InterpolationColors = colorBlend;
            //paints the square
            e.Graphics.FillRectangle(pthGrBrush, _x, _y, _width, _height);
        }
        /// <summary>
        /// Called when the window is reisized
        /// will resize the moving square based on window size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromView_Resize(object sender, EventArgs e)
        {
            //Used the same side so it is kept a square
            //instead of a rectangle
            _width = this.ClientRectangle.Width / 10;
            _height = this.ClientRectangle.Width / 10;
        }
        /// <summary>
        /// Window timer allows for set window timer intervals
        /// to refresh the form and invalidate the new position
        /// of the rectangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //sends bounds for Down Right Movement
            if(_objPosition == Position.DRight){
                _x += 1;
                _y += 1;
                if(_x+_width > this.ClientRectangle.Width){
                    _objPosition = Position.DLeft;
                }
                if(_y+_height > this.ClientRectangle.Height){
                    _objPosition = Position.URight;
                }
                
            }
            //sets bounds for down left movement
            else if(_objPosition == Position.DLeft){
                _x -= 1;
                _y += 1;
                if (_x < 0)
                {
                    _objPosition = Position.DRight;
                }
                if (_y +_height > this.ClientRectangle.Height)
                {
                    _objPosition = Position.ULeft;
                }
            }
            //sets bounds for up right movement
            else if(_objPosition == Position.URight){
                _x += 1;
                _y -= 1;
                if (_x + _width > this.ClientRectangle.Width)
                {
                    _objPosition = Position.ULeft;
                }
                if (_y < 25)
                {
                    _objPosition = Position.DRight;
                }
            }
            //sets bounds for up left movement
            else if (_objPosition == Position.ULeft)
            {
                _x -= 1;
                _y -= 1;
                if (_x < 0)
                {
                    _objPosition = Position.URight;
                }
                if (_y < 25)
                {
                    _objPosition = Position.DLeft;
                }
            }
            Invalidate();
        }
        /// <summary>
        /// Initially draws the box but then allows movement by stopping
        /// and starting the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //marks the forms paint method on first use
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Square);
            //starts the timer
            this.timerMoving.Enabled = true;
        }
        /// <summary>
        /// Stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stops the timer
            this.timerMoving.Enabled = false;
        }
        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
