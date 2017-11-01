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
        ToolHand toolHand;
        ToolZoom toolZoom;

        public MainDrawForm()
        {
            InitializeComponent();
            Tool.vScrollBar = vScrollBarOffset;
            Tool.hScrollBar = hScrollBarOffset;
            toolTipMain.SetToolTip(btnToolPolyLine,"Pencil");
            toolTipMain.SetToolTip(btnToolLine, "Line");
            toolTipMain.SetToolTip(btnToolRect, "Rectangle");
            toolTipMain.SetToolTip(btnToolEllipse, "Ellipse");
            toolTipMain.SetToolTip(btnZoom, "Zoom");
            toolTipMain.SetToolTip(btnHand, "Hand");
          
            toolPolyLine = new ToolPolyLine(btnToolPolyLine, ref figureArray, penMain, paintBox);
            toolLine = new ToolLine(btnToolLine, ref figureArray, penMain, paintBox);
            toolRect = new ToolReact(btnToolRect, ref figureArray, penMain, paintBox);
            toolCircle = new ToolEllipse(btnToolEllipse, ref figureArray, penMain, paintBox);
            toolZoom = new ToolZoom(btnZoom, ref figureArray, paintBox, numZoom);
            toolHand = new ToolHand(btnHand,paintBox);
            Tool.ActiveTool = toolPolyLine;
            paintBox.Paint += PaintBox_Paint;
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
 
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vector graph \nVersion: Alpha v0.1 \nMade by kenny5660(Liamaev Mikhail)");
        }

        private void btnMainColor_Click(object sender, EventArgs e)
        {
        }

        private void numeric_width_pen_ValueChanged(object sender, EventArgs e)
        {
            penMain.Width = (float)numWidthPen.Value;
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
   

        private void numZoom_ValueChanged(object sender, EventArgs e)
        {
            PointW.zoom = (double)(numZoom.Value/100);
            paintBox.Invalidate();
        }

        private void btnResetZoom_Click(object sender, EventArgs e)
        {
            if (Tool.pntwMaxReact.X>0) { 
                numZoom.Value = (decimal)(Math.Min((paintBox.Width - 200) / (Tool.pntwMaxReact.X - Tool.pntwMinReact.X), (paintBox.Height - 50) / (Tool.pntwMaxReact.Y - Tool.pntwMinReact.Y)) * 100);
            PointW.offset = new Point((int)Math.Round(-Tool.pntwMinReact.X * (double)(numZoom.Value / 100) + 150), (int)Math.Round(-Tool.pntwMinReact.Y * (double)(numZoom.Value / 100)) + 10);
                    }
            paintBox.Invalidate();
        }

        private void vScrollBarOffset_ValueChanged(object sender, EventArgs e)
        {
            PointW.offset.Y = -vScrollBarOffset.Value;
            paintBox.Invalidate();
        }

        private void hScrollBarOffset_ValueChanged(object sender, EventArgs e)
        {
            PointW.offset.X = -hScrollBarOffset.Value;
            paintBox.Invalidate();
        }
    }
}