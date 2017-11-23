using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Tool
    {
        public static PointW pntwMinReact = new PointW(Double.MaxValue, Double.MaxValue);
        public static PointW pntwMaxReact = new PointW(0.0, 0.0);
        public static Tool ActiveTool { get; set; }
        public Button toolButton;
        public List<Figure> figureArray;
        public Panel paintBox;
        public Cursor cursor = Cursors.Default;
        protected bool flagLeftMouseClick = false;
        protected bool flagRightMouseClick = false;
        protected PropColor propColor;
        protected PropPenWidth propPenWidth;
        protected PanelProp panelProp;
        public void ToolButtonClick(object sender, EventArgs e)
        {
            ActiveTool.HidePanelProp();
            ActiveTool = this;
            ActiveTool.ShowPanelProp();
            paintBox.Cursor = this.cursor;
        }
        public virtual void HidePanelProp() { }
        public virtual void ShowPanelProp() { }
        public virtual void MouseMove(object sender, MouseEventArgs e) { }
        public virtual void MouseDown(object sender, MouseEventArgs e) { }
        public virtual void MouseUp(object sender, MouseEventArgs e) { }
        public void SetResetReact(int X, int Y)
        {
            PointW pointW = new PointW(X, Y);
            pntwMinReact.X = Math.Min(pointW.X, pntwMinReact.X);
            pntwMinReact.Y = Math.Min(pointW.Y, pntwMinReact.Y);
            pntwMaxReact.X = Math.Max(pointW.X, pntwMaxReact.X);
            pntwMaxReact.Y = Math.Max(pointW.Y, pntwMaxReact.Y);
        }
    }

    class ToolRect : Tool
    {
        PropFill propFill;

        public ToolRect(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Rect";
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propPenWidth = new PropPenWidth(new Point(5, 50), "Width:", panelProp);
            propFill = new PropFill(new Point(5, 80), "Fill:", panelProp);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                if (propFill.GetCheked())
                    figureArray.Add(new Rect(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y), propFill.GetColor()));
                else
                    figureArray.Add(new Rect(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y)));
                SetResetReact(e.X, e.Y);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
                SetResetReact(e.X, e.Y);
            }
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
    class ToolRoundedRect : Tool
    {
        PropFill propFill;
        PropRadius propRadius;

        public ToolRoundedRect(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Rounded Rect";
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propPenWidth = new PropPenWidth(new Point(5, 50), "Width:", panelProp);
            propFill = new PropFill(new Point(5, 80), "Fill:", panelProp);
            propRadius = new PropRadius(new Point(5, 140), "Radius:", panelProp);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                if (propFill.GetCheked())
                    figureArray.Add(new RoundedRect(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y), propRadius.GetRadius(), propFill.GetColor()));
                else
                    figureArray.Add(new RoundedRect(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y), propRadius.GetRadius()));
                SetResetReact(e.X, e.Y);
                paintBox.Invalidate();
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
                SetResetReact(e.X, e.Y);
            }
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
    class ToolPolyLine : Tool
    {
        public ToolPolyLine(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Poly line";
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propPenWidth = new PropPenWidth(new Point(5, 50), "Width:", panelProp);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
                SetResetReact(e.X, e.Y);
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new PolyLine(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y)));
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                SetResetReact(e.X, e.Y);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
                SetResetReact(e.X, e.Y);
            }
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }

    }
    class ToolLine : Tool
    {

        public ToolLine(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Line";
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propPenWidth = new PropPenWidth(new Point(5, 50), "Width:", panelProp);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new Line(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y)));
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                SetResetReact(e.X, e.Y);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
                SetResetReact(e.X, e.Y);
            }
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
    class ToolEllipse : Tool
    {
        PropFill propFill;
        public ToolEllipse(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Ellipse";
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propPenWidth = new PropPenWidth(new Point(5, 50), "Width:", panelProp);
            propFill = new PropFill(new Point(5, 80), "Fill:", panelProp);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                if (propFill.GetCheked())
                    figureArray.Add(new Ellipse(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y), propFill.GetColor()));
                else
                    figureArray.Add(new Ellipse(new Pen(propColor.GetColor(), propPenWidth.GetPenWidth()), new PointW(e.X, e.Y)));
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                SetResetReact(e.X, e.Y);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
                SetResetReact(e.X, e.Y);
            }
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
    class ToolZoom : Tool
    {
        NumericUpDown stepZoom;
        Label labelStepZoom;
        PointW pointWStart;
        PointW pointWEnd;
        Point pointStart;
        Point pointEnd;
        NumericUpDown numZoom;
        public ToolZoom(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set, NumericUpDown numZoomSet)
        {
            numZoom = numZoomSet;
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            CreatePanelProp();
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                pointWEnd = new PointW(e.X, e.Y);
                pointEnd = new Point(e.X, e.Y);
                figureArray.Last().AddPoint(pointWEnd);
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                    flagLeftMouseClick = true;
                    pointStart = new Point(e.X, e.Y);
                    pointEnd = new Point(e.X + 1, e.Y + 1);
                    pointWStart = new PointW(e.X, e.Y);
                    pointWEnd = new PointW(e.X + 1, e.Y + 1);
                    figureArray.Add(new Rect(new Pen(Color.Black), pointWStart));
                    figureArray.Last().AddPoint(pointWStart);
                    paintBox.Invalidate();
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            int stepZoomValue = (int)stepZoom.Value;
            if (e.Button == MouseButtons.Left)
            {
                if ((pointEnd.X -pointStart.X + pointEnd.Y - pointStart.Y)>10)
                {
                    decimal zoom = (decimal)(Math.Min((paintBox.Width - 200) / Math.Abs(pointWEnd.X - pointWStart.X), 
                                            (paintBox.Height - 50) / Math.Abs(pointWEnd.Y - pointWStart.Y)) * 100);
                    if (Math.Min(zoom, numZoom.Maximum) > numZoom.Minimum)
                        numZoom.Value = Math.Min(zoom, numZoom.Maximum);
                    else
                        numZoom.Value = numZoom.Minimum;
                    PointW.offset = new Point((int)Math.Round(-Math.Min(pointWEnd.X, pointWStart.X) * (double)(numZoom.Value / 100) + 150),
                                              (int)Math.Round(-Math.Min(pointWEnd.Y, pointWStart.Y) * (double)(numZoom.Value / 100)) + 10);
                }
                else
                {
                    if ((numZoom.Value + stepZoom.Value) >= 1000)
                        stepZoomValue = 1000-(int)numZoom.Value;
                    else
                        stepZoomValue = (int)stepZoom.Value;
                    numZoom.Value += stepZoomValue;
                        PointW.offset = new Point(
                            (int)Math.Round((PointW.offset.X - e.X) * PointW.zoom / (PointW.zoom - (stepZoomValue / 100.0))) + e.X,
                            (int)Math.Round((PointW.offset.Y - e.Y) * PointW.zoom / (PointW.zoom - (stepZoomValue / 100.0))) + e.Y);
                }
                figureArray.RemoveAt(figureArray.Count - 1);
                flagLeftMouseClick = false;
                paintBox.Invalidate();
            }
            if (e.Button == MouseButtons.Right && (pointEnd.X - pointStart.X + pointEnd.Y - pointStart.Y) < 10)
            {
                if (numZoom.Value <= stepZoom.Value)
                    stepZoomValue = (int)numZoom.Value - 1;
                else
                    stepZoomValue = (int)stepZoom.Value;
                numZoom.Value -= stepZoomValue;
                PointW.offset = new Point(
                      (int)Math.Round((PointW.offset.X - e.X) * PointW.zoom / (PointW.zoom + (stepZoomValue / 100.0))) + e.X,
                      (int)Math.Round((PointW.offset.Y - e.Y) * PointW.zoom / (PointW.zoom + (stepZoomValue / 100.0))) + e.Y);
                
                paintBox.Invalidate();
            }
        }
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Zoom";
            stepZoom = new NumericUpDown();
            stepZoom.Location = new Point(65, 15);
            stepZoom.Size = new Size(48, 24);
            stepZoom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stepZoom.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            stepZoom.Value = new decimal(new int[] { 20, 0, 0, 0 });
            stepZoom.Increment = 10;
            panelProp.Controls.Add(stepZoom);
            labelStepZoom = new Label();
            labelStepZoom.Location = new Point(5, 20);
            labelStepZoom.Text = "Step:";
            panelProp.Controls.Add(labelStepZoom);
        }
        public override void HidePanelProp()
        {
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
 class ToolHand : Tool
    {
        Point pntLastMause = new Point(0, 0);
        public ToolHand(Button button, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            cursor = Cursors.Hand;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                PointW.offset.X += e.X - pntLastMause.X;
                PointW.offset.Y += e.Y - pntLastMause.Y;
                paintBox.Invalidate();
                pntLastMause.X = e.X;
                pntLastMause.Y = e.Y;
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                flagLeftMouseClick = true;
                pntLastMause.X = e.X;
                pntLastMause.Y = e.Y;
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = false;
            }
        }
    }
    class ToolSelection : Tool
    {
        PointW pointWStart;
        PointW pointWEnd;
        Point pointStart;
        Point pointEnd;
        public ToolSelection(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
            panelProp = new PanelProp();
            panelProp.Text = "Selection";
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {

                pointEnd = new Point(e.X, e.Y);
                pointWEnd = new PointW(e.X, e.Y);
                figureArray.Last().AddPoint(pointWEnd);
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointStart = new Point(e.X, e.Y);
                pointEnd = new Point(e.X + 1, e.Y + 1);
                Pen pen = new Pen(Color.Gray);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                pen.DashOffset = 15;
                pen.Width = 2;
                flagLeftMouseClick = true;
                pointWStart = new PointW(e.X, e.Y);
                pointWEnd = new PointW(e.X + 1, e.Y + 1);
                figureArray.Add(new Rect(pen, pointWStart));          
                paintBox.Invalidate();
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                figureArray.RemoveAt(figureArray.Count - 1);
                if ((pointEnd.X - pointStart.X + pointEnd.Y - pointStart.Y) < 10)
                {
                    int i = figureArray.Count - 1;
                    for (; i >= 0; --i )
                        if (figureArray[i].SelectPoint(e.Location))
                        {
                            i--;
                            break;
                        }
                    for (; i >= 0; --i)
                        figureArray[i].isSelected = false;
                }
              
              flagLeftMouseClick = false;
              paintBox.Invalidate();
            }
        }
        public override void HidePanelProp()
        {
            foreach (Figure primitiv in figureArray)
            {
                primitiv.isSelected = false;
            }
            paintBox.Invalidate();
            panelProp.Visible = false;
        }
        public override void ShowPanelProp()
        {
            panelProp.Visible = true;
        }
    }
    public class NumWidthPen : NumericUpDown
    {
        public float penWidth;
        public NumWidthPen()
        {
            Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            Value = new decimal(new int[] { 1, 0, 0, 0 });
            ValueChanged += new EventHandler(NumWidthPen_ValueChanged);
            penWidth = (float)Value;
        }
        private void NumWidthPen_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)Value;
        }
    }
 public class ColorButton : Button
    {
        public Color color;
        private ColorDialog colorDialog = new ColorDialog();
        public ColorButton(Color setColor)
        {
            this.Click += new EventHandler(ColorButton_Click);
            color = setColor;
            Size = new Size(48, 24);
            SetButtonColor(setColor);
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            color = colorDialog.Color;
            SetButtonColor(colorDialog.Color);
        }
        private void SetButtonColor(Color color)
        {
            Graphics bitmapGBtnMainColor;
            Bitmap bitmapBtnMainColor;
            bitmapBtnMainColor = new Bitmap(this.Width, this.Height);
            bitmapGBtnMainColor = Graphics.FromImage(bitmapBtnMainColor);
            bitmapGBtnMainColor.Clear(color);
            this.Image = bitmapBtnMainColor;
        }
    }
 public class PanelProp : GroupBox
    {
        public static Panel toolPanel;
        public PanelProp()
        {
            BackColor = SystemColors.ControlDark;
            Location = new Point(3, 322);
            Size = new Size(120, 180);
            TabIndex = 12;
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toolPanel.Controls.Add(this);
            Visible = false;
        }
    }
class Prop
    {
        protected Control control;
        protected Label label;

    }
    class PropColor : Prop
    {
        public PropColor(Point position, String text, PanelProp panelProp)
        {
            control = new ColorButton(Color.Black);
            control.Location = new Point(position.X + 60, position.Y);
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
        }
        public Color GetColor()
        {
            ColorButton colorButton = (ColorButton)control;
            return colorButton.color;
        }
    }
    class PropPenWidth : Prop
    {
        public PropPenWidth(Point position, String text, PanelProp panelProp)
        {
            control = new NumWidthPen();
            control.Location = new Point(position.X + 60, position.Y);
            control.Size = new Size(48, 26);
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
        }
        public float GetPenWidth()
        {
            NumWidthPen numWidthPen = (NumWidthPen)control;
            return numWidthPen.penWidth;
        }
    }
    class PropFill : Prop
    {
        PropColor propColor ;
        public PropFill(Point position, String text, PanelProp panelProp)
        {

            control = new CheckBox();
            control.Location = new Point(position.X + 60, position.Y);
            control.Size = new Size(48, 26);
            control.Text = "";
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
            propColor = new PropColor(new Point(position.X, position.Y + 25), "Clr fill:", panelProp);
        }
        public bool GetCheked()
        {
            return ((CheckBox)control).Checked;
        }
        public Color color => propColor.GetColor();
        public Color GetColor()
        {
            return propColor.GetColor();
        }
    }
    class PropRadius : Prop
    {
        NumericUpDown numeric;
        public PropRadius(Point position, String text, PanelProp panelProp)
        {
            control = new NumericUpDown();
            control.Location = new Point(position.X + 60, position.Y);
            control.Size = new Size(48, 26);
            numeric = (NumericUpDown)control;
            numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
        }
        public int GetRadius()
        {
            return (int)numeric.Value;
        }
    }

}
