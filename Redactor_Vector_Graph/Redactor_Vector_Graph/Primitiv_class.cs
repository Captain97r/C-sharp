using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Primitiv
    {
        Pen pen = new Pen(Color.Red);
        List<Point> points_array = new List<Point>(200);
      public  Primitiv(Pen set_pen,Point start)
        {
            pen = set_pen;
            points_array.Add(start);
        }
      public   void Drow(Graphics graphics)
        {
            Point last_point = points_array[0];
            foreach (Point point in points_array)
            {
                graphics.DrawLine(pen, last_point,point);
                last_point = point;
            }
        }
        public void Add_Point(Point point)
        {
            points_array.Add(point);
        }
       
    }
}
