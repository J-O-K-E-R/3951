using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Drawing
{
    class Shape
    {
        public Shape()
        {
            GraphicsPath p = new GraphicsPath();
            p.AddLine(new Point(0, 0), new Point(100, 100)); //memory error without this, unsure why
            PathGradientBrush brush = new PathGradientBrush(p);
            brush.CenterColor = fColor;
            brush.SurroundColors = eColor;
            gradient = brush;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public Brush edgeColor = new SolidBrush(Color.Red);
        public Brush fillColor = new SolidBrush(Color.Blue);
        public Color fColor = Color.Blue;
        public Color[] eColor = { Color.Red };
        
        public PathGradientBrush gradient;
        public Pen edge = new Pen(Color.Red);

        public void draw(Graphics g, Graphics rectg)
        {
            
            //draw is the generic method, and checks the object's type to determine what to do
            if (GetType().Equals(typeof(Rectangle)))
            {
                //some math magic, covers all four possibilities of the rectangle's points' locations.
                rectg.DrawRectangle(edge, Math.Min(x, x2), Math.Min(y, y2), Math.Abs(x - x2), Math.Abs(y - y2));
            }
            else if (GetType().Equals(typeof(Circle)))
            {
                GraphicsPath path = new GraphicsPath();
                PathGradientBrush pthGrBrush;
                System.Drawing.Rectangle pathRect = new System.Drawing.Rectangle(x, y, 50, 50);
                path.AddEllipse(pathRect);
                pthGrBrush = new PathGradientBrush(path);
                pthGrBrush.CenterColor = fColor;
                pthGrBrush.SurroundColors = eColor;
                g.FillEllipse(pthGrBrush, pathRect);
            }
            else if (GetType().Equals(typeof(Square)))
            {
                GraphicsPath path = new GraphicsPath();
                PathGradientBrush pthGrBrush;
                System.Drawing.Rectangle pathRect = new System.Drawing.Rectangle(x, y, 50, 50);
                path.AddRectangle(pathRect);
                pthGrBrush = new PathGradientBrush(path);
                pthGrBrush.CenterColor = fColor;
                pthGrBrush.SurroundColors = eColor;
                g.FillRectangle(pthGrBrush, pathRect);
            }
            else if (GetType().Equals(typeof(Scribble)))
            {//just draws a tiny rectangle!
                g.DrawRectangle(edge, x2, y2, 1, 1);
            }
        }
        //sets up some of the gradient brushes
        public void adjustBrushes()
        {
            GraphicsPath p = new GraphicsPath();
            p.AddLine(new Point(0, 0), new Point(100, 100)); //memory error without this, unsure why
            PathGradientBrush brush = new PathGradientBrush(p);
            brush.CenterColor = fColor;
            brush.SurroundColors = eColor;
            gradient = brush;
        }

        //special functionality for the rectangle, since it's on mouseup and has an edge
        public void drawRectangle(Graphics g)
        {
            g.DrawRectangle(edge, x, y, x2 - x, y2 - y);
            g.FillRectangle(fillColor, x + 1, y + 1, x2 - x - 1, y2 - y - 1);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            
        }
    }
    class Circle : Shape
    {
        public Circle()
        {

        }
    }
    class Square : Shape
    {
        public Square()
        {

        }
    }
    class Scribble : Shape
    {
        public Scribble()
        { 

        }
    }
}
