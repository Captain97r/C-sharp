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
    public partial class Main_Drow_Form : Form
    {
        List<Primitiv> primitives_Array = new List<Primitiv>(100);
        Point[] point_array = {new  Point(12, 40), new Point(24,24), new Point(36,70) };
        bool flag_right_click = false;
        Graphics graph_PaintBox;
        Point lastPoint = new Point(0,0);
        Pen main_pen = new Pen(Color.Blue);
        public Main_Drow_Form()
        {
            InitializeComponent();
            graph_PaintBox = PaintBox.CreateGraphics();
            PaintBox.Paint += PaintBox_Paint;
        
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Primitiv primitiv in primitives_Array)
            {
                primitiv.Drow(graph_PaintBox);
            }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
         
            graph_PaintBox.Clear(Color.White);
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
              
                flag_right_click = true;
                lastPoint = new Point(e.X, e.Y);
                primitives_Array.Add(new Primitiv(main_pen, new Point(e.X, e.Y)));
                
            }
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               flag_right_click = false;

            }
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag_right_click)
            {

                primitives_Array.Last().Add_Point(new Point(e.X,e.Y));
                primitives_Array.Last().Drow(graph_PaintBox);
                //    PaintBox.Invalidate(new Rectangle(new Point(e.X - 2,e.Y-2),new Size(3,3)));

            }
        }

        private void tool_strip_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tool_strip_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vector graph \nVersion: Alpha v0.1 \nMade by kenny5660(Liamaev Mikhail)");
        }
    }
}
