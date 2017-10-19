using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    public partial class Main_Draw_Form : Form
    {
        List<Figure> primitives_Array = new List<Figure>(20);
        ToolTip ToolTipMain = new ToolTip();
        Pen mainPen = new Pen(Color.Black);
        ToolPolyLine toolPolyLine;
        ToolLine toolLine;
        ToolReact toolRect;
        ToolCircle toolCircle;
      

        public Main_Draw_Form()
        {
            InitializeComponent();
            toolPolyLine = new ToolPolyLine(buttonToolPolyLine, ref primitives_Array, mainPen,PaintBox);
            toolLine = new ToolLine(buttonToolLine, ref primitives_Array, mainPen);
            toolRect = new ToolReact(buttonToolRect, ref primitives_Array, mainPen);
            toolCircle = new ToolCircle(buttonToolCircle, ref primitives_Array, mainPen);
            Tool.ActiveTool = toolPolyLine;
            Graphics but_main_color_bitmap_g;
            Bitmap but_main_color_bitmap;
            PaintBox.Paint += PaintBox_Paint;
            but_main_color_bitmap = new Bitmap(but_main_color.Width, but_main_color.Height);
            but_main_color_bitmap_g = Graphics.FromImage(but_main_color_bitmap);
            but_main_color_bitmap_g.Clear(mainPen.Color);
            but_main_color.Image = but_main_color_bitmap;
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure primitiv in primitives_Array)
            {
                primitiv.Draw(e.Graphics);
            }
        }


        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            Tool.ActiveTool.MouseDown(sender, e);
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            Tool.ActiveTool.MouseUp(sender, e);
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            Tool.ActiveTool.MouseMove(sender, e);
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
            Graphics but_main_color_bitmap_g;
            Bitmap but_main_color_bitmap;
            color_dialog_main.ShowDialog();
            but_main_color_bitmap = new Bitmap(but_main_color.Width, but_main_color.Height);
            but_main_color_bitmap_g = Graphics.FromImage(but_main_color_bitmap);
            mainPen.Color = color_dialog_main.Color;
            but_main_color_bitmap_g.Clear(mainPen.Color);
            but_main_color.Image = but_main_color_bitmap;
        }

        private void numeric_width_pen_ValueChanged(object sender, EventArgs e)
        {
            mainPen.Width = (float)numeric_width_pen.Value;
        }
    }
}
