using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    public partial class Main_Drow_Form : Form
    {
        List<Primitiv> primitives_Array = new List<Primitiv>(100);
        Point[] point_array = {new  Point(12, 40), new Point(24,24), new Point(36,70) };
        bool flag_right_click = false;
        Graphics graph_PaintBox;
        Graphics but_main_color_bitmap_g;
        Bitmap but_main_color_bitmap;
        Point lastPoint = new Point(0,0);
        Pen main_pen = new Pen(Color.Blue);
        public Main_Drow_Form()
        {
            
          
          
            InitializeComponent();
            graph_PaintBox = PaintBox.CreateGraphics();
            PaintBox.Paint += PaintBox_Paint;
            but_main_color_bitmap = new Bitmap(but_main_color.Width, but_main_color.Height);
            but_main_color_bitmap_g = Graphics.FromImage(but_main_color_bitmap);
            but_main_color_bitmap_g.Clear(main_pen.Color);
            but_main_color.Image = but_main_color_bitmap;
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

        private void but_main_color_Click(object sender, EventArgs e)
        {
            color_dialog_main.ShowDialog();
            main_pen.Color = color_dialog_main.Color;
            but_main_color_bitmap_g.Clear(main_pen.Color);
            but_main_color.Image = but_main_color_bitmap;
        }

        private void numeric_width_pen_ValueChanged(object sender, EventArgs e)
        {
            main_pen.Width = (float)numeric_width_pen.Value;
        }
    }
}
