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
            pen = (Pen)set_pen.Clone();
            points_array.Add(start);
        }
      public   void Drow(Graphics graphics)
        {
            graphics.DrawLines(pen,points_array.ToArray());
        }
        public void Add_Point(Point point)
        {
            points_array.Add(point);
        }
       
    }
}
