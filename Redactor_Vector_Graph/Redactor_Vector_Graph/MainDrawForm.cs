using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    public partial class MainDrawForm : Form
    {
        List<Figure> figureArray = new List<Figure>(20);
        ToolTip toolTipMain = new ToolTip();
        Pen penMain = new Pen(Color.Black);
        ToolPolyLine toolPolyLine;
        ToolLine toolLine;
        ToolReact toolRect;
        ToolEllipse toolCircle;

        public MainDrawForm()
        {
            InitializeComponent();
            toolTipMain.SetToolTip(btnToolPolyLine,"Pencil");
            toolTipMain.SetToolTip(btnToolLine, "Line");
            toolTipMain.SetToolTip(btnToolRect, "Rectangle");
            toolTipMain.SetToolTip(btnToolEllipse, "Ellipse");
            toolPolyLine = new ToolPolyLine(btnToolPolyLine, ref figureArray, penMain, paintBox);
            toolLine = new ToolLine(btnToolLine, ref figureArray, penMain, paintBox);
            toolRect = new ToolReact(btnToolRect, ref figureArray, penMain, paintBox);
            toolCircle = new ToolEllipse(btnToolEllipse, ref figureArray, penMain, paintBox);
            Tool.ActiveTool = toolPolyLine;
            paintBox.Paint += PaintBox_Paint;
            SetButtonColor(penMain.Color);
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure primitiv in figureArray)
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

        private void PaintBox_MouseMove(object sender, MouseEventArgs e) =>
            Tool.ActiveTool.MouseMove(sender, e);
 
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
            
            colorDialogMain.ShowDialog();
            penMain.Color = colorDialogMain.Color;
            SetButtonColor(penMain.Color);
        }

        private void numeric_width_pen_ValueChanged(object sender, EventArgs e)
        {
            penMain.Width = (float)numeric_width_pen.Value;
        }

        private void Main_Draw_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (figureArray.Count > 0)
                {
                    figureArray.RemoveAt(figureArray.Count - 1);
                    paintBox.Invalidate();
                }
            }
        }
        private void SetButtonColor(Color color)
        {
            Graphics bitmapGBtnMainColor;
            Bitmap bitmapBtnMainColor;
            bitmapBtnMainColor = new Bitmap(btnMainColor.Width, btnMainColor.Height);
            bitmapGBtnMainColor = Graphics.FromImage(bitmapBtnMainColor);       
            bitmapGBtnMainColor.Clear(color);
            btnMainColor.Image = bitmapBtnMainColor;
        }
    }
}