using System.Collections.Generic;
using System.Drawing;

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
             graphics.DrawLines(pen,points_array.ToArray());
        }

    }

    public class Rect : Figure
    {
        Point start_point;
        Size size;
        public Rect(Pen set_pen, Point start)
        {
            pen = (Pen)set_pen.Clone();
            start_point = start;
        }

        public override void Add_Point(Point point)
        {
            if (point.X < start_point.X) ;
             start_point.X = point.X;

            
            size = new Size(point.X - start_point.X, point.Y - start_point.Y);
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen,new Rectangle(start_point, size));
        }

    }


}
