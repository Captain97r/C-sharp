using System.Collections.Generic;
using System.Drawing;
using System;
namespace Redactor_Vector_Graph
{

    public abstract class Figure
    {
        public Pen pen = new Pen(Color.Black);
        public abstract void Draw(Graphics graphics);
        public abstract void Add_Point(Point point);
    }

    public class PolyLine : Figure
    {
        public List<Point> points_array = new List<Point>(50);
        public PolyLine(Pen set_pen, Point start)
        {
            pen = (Pen)set_pen.Clone();
            points_array.Add(start);
        }

        public override void Add_Point(Point point)
        {
            points_array.Add(point);
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(pen, points_array.ToArray());
        }

    }

    public class Rect : Figure
    {
        Point startPoint;
        Rectangle rectangle;
        public Rect(Pen set_pen, Point start)
        {
            pen = (Pen)set_pen.Clone();
            startPoint = start;
        }

        public override void Add_Point(Point point)
        {
            int x, y;
            x = Math.Min(startPoint.X, point.X);
            y = Math.Min(startPoint.Y, point.Y);
            int width = Math.Max(startPoint.X, point.X) - Math.Min(startPoint.X, point.X);
            int height = Math.Max(startPoint.Y, point.Y) - Math.Min(startPoint.Y, point.Y);
            rectangle = new Rectangle(x, y, width, height);

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, rectangle);
        }

    }
    public class Line : Figure
    {
        Point startPoint;
        Point lastPoint;
        public Line(Pen set_pen, Point start)
        {
            pen = (Pen)set_pen.Clone();
            startPoint = start;
        }

        public override void Add_Point(Point point)
        {
            lastPoint = point;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, lastPoint);
        }

    }

    public class Ellipse : Figure
    {
        Point startPoint;
        Size size;
        public Ellipse(Pen set_pen, Point start)
        {
            pen = (Pen)set_pen.Clone();
            startPoint = start;
        }

        public override void Add_Point(Point point)
        {
            size = new Size(point.X - startPoint.X, point.Y - startPoint.Y);
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, new Rectangle(startPoint, size));
        }

    }


}
