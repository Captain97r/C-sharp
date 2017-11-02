using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Tool
    {
        public static VScrollBar vScrollBar;
        public static HScrollBar hScrollBar;
        public static PointW pntwMinReact = new PointW(Double.MaxValue, Double.MaxValue);
        public static PointW pntwMaxReact = new PointW(0.0, 0.0);
        public static Tool ActiveTool { get; set; }
        public Button toolButton;
        public List<Figure> figureArray;
        public Panel paintBox;
        public Cursor cursor = Cursors.Default;
        protected bool flagLeftMouseClick = false;
        protected bool flagRightMouseClick = false;
        protected ColorButton colorButton;
        protected Label labelColorButton;
        protected NumWidthPen numWidthPen;
        protected Label labelNumWidthPen;
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
        public virtual void MouseDown() { }
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
            vScrollBar.Minimum = (int)Math.Round(pntwMinReact.Y * PointW.zoom) - 10;
            vScrollBar.Maximum = (int)Math.Round(pntwMaxReact.Y * PointW.zoom);
            hScrollBar.Minimum = (int)Math.Round(pntwMinReact.X * PointW.zoom) - 150;
            hScrollBar.Maximum = (int)Math.Round(pntwMaxReact.X * PointW.zoom);
        }
    }

    class ToolRect : Tool
    {
        CheckBox checkBoxFill;
        Label labelCheckBoxFill;
        ColorButton colorButtonFill;
        Label labelColorButtonFill;


        public ToolRect(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
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
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                if(checkBoxFill.Checked)
                   figureArray.Add(new Rect(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y), colorButtonFill.color));
                else
                   figureArray.Add(new Rect(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y)));
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
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Rect";
            colorButton = new ColorButton(Color.Black);
            colorButton.Location = new Point(58, 15);
            colorButton.Size = new Size(52, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Size = new Size(52, 24);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(58, 45);
            numWidthPen.Size = new Size(52, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Size = new Size(52, 24);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

            checkBoxFill = new CheckBox();
            checkBoxFill.Location = new Point(58, 70);
            checkBoxFill.Size = new Size(52, 26);
            checkBoxFill.Text = "";
            panelProp.Controls.Add(checkBoxFill);
            labelCheckBoxFill = new Label();
            labelCheckBoxFill.Location = new Point(5, 75);
            labelCheckBoxFill.Size = new Size(52, 24);
            labelCheckBoxFill.Text = "Fill:";
            panelProp.Controls.Add(labelCheckBoxFill);

            colorButtonFill = new ColorButton(Color.Red);
            colorButtonFill.Location = new Point(58, 100);
            colorButtonFill.Size = new Size(52, 24);
            panelProp.Controls.Add(colorButtonFill);
            labelColorButtonFill = new Label();
            labelColorButtonFill.Location = new Point(5, 100);
            labelColorButtonFill.Size = new Size(52, 24);
            labelColorButtonFill.Text = "Color Fill:";
            panelProp.Controls.Add(labelColorButtonFill);
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
            CreatePanelProp();
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
                figureArray.Add(new PolyLine(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y)));
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
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Poly line";
            colorButton = new ColorButton(Color.Black);
            colorButton.Location = new Point(58, 15);
            colorButton.Size = new Size(52, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Size = new Size(52, 24);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(58, 45);
            numWidthPen.Size = new Size(52, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Size = new Size(52, 24);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

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
            CreatePanelProp();
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
                figureArray.Add(new Line(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y)));
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
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Line";
            colorButton = new ColorButton(Color.Black);
            colorButton.Location = new Point(58, 15);
            colorButton.Size = new Size(52, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Size = new Size(52, 24);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(58, 45);
            numWidthPen.Size = new Size(52, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Size = new Size(52, 24);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

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
        CheckBox checkBoxFill;
        Label labelCheckBoxFill;
        ColorButton colorButtonFill;
        Label labelColorButtonFill;
        public ToolEllipse(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
        {
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
                figureArray.Last().AddPoint(new PointW(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                if (checkBoxFill.Checked)
                    figureArray.Add(new Ellipse(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y),colorButtonFill.color));
                else
                    figureArray.Add(new Ellipse(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y)));
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
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Ellipse";
            colorButton = new ColorButton(Color.Black);
            colorButton.Location = new Point(58, 15);
            colorButton.Size = new Size(52, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Size = new Size(52, 24);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(58, 45);
            numWidthPen.Size = new Size(52, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Size = new Size(52, 24);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

            checkBoxFill = new CheckBox();
            checkBoxFill.Location = new Point(58, 70);
            checkBoxFill.Size = new Size(52, 26);
            checkBoxFill.Text = "";
            panelProp.Controls.Add(checkBoxFill);
            labelCheckBoxFill = new Label();
            labelCheckBoxFill.Location = new Point(5, 75);
            labelCheckBoxFill.Size = new Size(52, 24);
            labelCheckBoxFill.Text = "Fill:";
            panelProp.Controls.Add(labelCheckBoxFill);

            colorButtonFill = new ColorButton(Color.Red);
            colorButtonFill.Location = new Point(58, 100);
            colorButtonFill.Size = new Size(52, 24);
            panelProp.Controls.Add(colorButtonFill);
            labelColorButtonFill = new Label();
            labelColorButtonFill.Location = new Point(5, 100);
            labelColorButtonFill.Size = new Size(52, 24);
            labelColorButtonFill.Text = "Color Fill:";
            panelProp.Controls.Add(labelColorButtonFill);
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
        PointW pointWStart;
        PointW pointWEnd;
        NumericUpDown numZoom;
        public ToolZoom(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set, NumericUpDown numZoomSet)
        {
            numZoom = numZoomSet;
            paintBox = paintBox_set;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                pointWEnd = new PointW(e.X, e.Y);
                figureArray.Last().AddPoint(pointWEnd);
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                pointWStart = new PointW(e.X, e.Y);
                pointWEnd = new PointW(e.X + 1, e.Y + 1);
                figureArray.Add(new Rect(new Pen(Color.Black), pointWStart));
                figureArray.Last().AddPoint(pointWStart);

            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                decimal zoom = (decimal)(Math.Min((paintBox.Width - 200) / Math.Abs(pointWEnd.X - pointWStart.X), (paintBox.Height - 50) / Math.Abs(pointWEnd.Y - pointWStart.Y)) * 100);
                if (Math.Min(zoom, numZoom.Maximum) > numZoom.Minimum)
                {
                    numZoom.Value = Math.Min(zoom, numZoom.Maximum);
                }
                else
                {
                    numZoom.Value = numZoom.Minimum;
                }



                PointW.offset = new Point((int)Math.Round(-Math.Min(pointWEnd.X, pointWStart.X) * (double)(numZoom.Value / 100) + 150), (int)Math.Round(-Math.Min(pointWEnd.Y, pointWStart.Y) * (double)(numZoom.Value / 100)) + 10);
                figureArray.RemoveAt(figureArray.Count - 1);
                flagLeftMouseClick = false;
                paintBox.Invalidate();
            }
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


    public class NumWidthPen : NumericUpDown
    {
       public float penWidth;
        public NumWidthPen()
        {
            Minimum = new decimal(new int[] {1,0,0,0});
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
        public   class ColorButton : Button
    {
      public  Color color;
        private ColorDialog colorDialog = new ColorDialog();
        public  ColorButton(Color setColor)
        {
            this.Click += new EventHandler(ColorButton_Click);
            color = setColor;
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
 public   class PanelProp : GroupBox
    {
       public static Panel toolPanel;
       public PanelProp()
        {
           
            BackColor = SystemColors.ControlDark;
            Location = new Point(3, 355);
            Size = new Size(117, 147);
            TabIndex = 12;
            Anchor = AnchorStyles.Bottom |AnchorStyles.Right;
            toolPanel.Controls.Add(this);

            Visible = false;
        }

    }
}
