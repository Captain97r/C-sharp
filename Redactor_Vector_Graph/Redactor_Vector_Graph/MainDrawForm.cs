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
        ToolRect toolRect;
        ToolEllipse toolCircle;
        ToolHand toolHand;
        ToolZoom toolZoom;
        ToolRoundedRect toolRoundedRect;
        ToolSelection toolSelection;
        public MainDrawForm()
        {
            InitializeComponent();
            PanelProp.toolPanel = toolPanel;
            toolTipMain.SetToolTip(btnToolPolyLine,"Pencil");
            toolTipMain.SetToolTip(btnToolLine, "Line");
            toolTipMain.SetToolTip(btnToolRect, "Rectangle");
            toolTipMain.SetToolTip(btnToolEllipse, "Ellipse");
            toolTipMain.SetToolTip(btnToolZoom, "Zoom");
            toolTipMain.SetToolTip(btnToolHand, "Hand");
            toolTipMain.SetToolTip(btnToolRoundedRect, "Rounded Rect");
            toolTipMain.SetToolTip(btnToolRoundedRect, "Selection");

            toolPolyLine = new ToolPolyLine(btnToolPolyLine, ref figureArray, paintBox);
            toolLine = new ToolLine(btnToolLine, ref figureArray, paintBox);
            toolRect = new ToolRect(btnToolRect, ref figureArray, paintBox);
            toolRoundedRect = new ToolRoundedRect(btnToolRoundedRect, ref figureArray, paintBox);
            toolCircle = new ToolEllipse(btnToolEllipse, ref figureArray, paintBox);
            toolZoom = new ToolZoom(btnToolZoom, ref figureArray, paintBox, numZoom);
            toolHand = new ToolHand(btnToolHand,paintBox);
            toolSelection = new ToolSelection(btnToolSelection, ref figureArray, paintBox);

            Tool.ActiveTool = toolPolyLine;
            toolPolyLine.ToolButtonClick(null,null);
            paintBox.Paint += PaintBox_Paint;
          
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (Figure primitiv in figureArray)
            {
                primitiv.Draw(e.Graphics);
            }
            foreach (Figure primitiv in figureArray)
            {
                primitiv.DrawColider(e.Graphics);
            }
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e) =>
            Tool.ActiveTool.MouseDown(sender, e);

        private void PaintBox_MouseUp(object sender, MouseEventArgs e) =>
            Tool.ActiveTool.MouseUp(sender, e);
       
        private void PaintBox_MouseMove(object sender, MouseEventArgs e) =>
            Tool.ActiveTool.MouseMove(sender, e);
 
        private void ToolStripExit_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void ToolStripAbout_Click(object sender, EventArgs e) =>
            MessageBox.Show("Vector graph \nVersion: Alpha v0.1 \nMade by kenny5660(Liamaev Mikhail)");

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
    }
}