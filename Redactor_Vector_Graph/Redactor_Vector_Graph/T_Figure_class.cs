using System.Collections.Generic;
using System.Drawing;

namespace Redactor_Vector_Graph
{
 
   public abstract class T_Figure
    {
       public Pen pen = new Pen(Color.Black);
       public abstract void Draw(Graphics graphics);
       public abstract void Add_Point(Point point);
    }

    public class T_PolyLine : T_Figure
    {
        public List<Point> points_array = new List<Point>(50);
        public T_PolyLine(Pen set_pen, Point start)
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

    public class T_Rect : T_Figure
    {
        public List<Point> points_array = new List<Point>(50);
        public T_Rect(Pen set_pen, Point start)
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
            graphics.DrawRectangle(pen,new Rectangle());
        }

    }


}
