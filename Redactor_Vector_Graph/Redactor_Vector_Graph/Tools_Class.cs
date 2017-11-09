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
        protected PropColor propColor;
        protected PropWidth propWidth;
        protected PropFill PropFill;

        protected ColorButton colorButton;
        protected Label labelColorButton;
        protected NumWidthPen numWidthPen;
        protected Label labelNumWidthPen;

        protected PanelProp panelProp;
        public List<Prop> propArray = new List<Prop>();
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
            if ((int)Math.Round(pntwMaxReact.Y * PointW.zoom) - (int)Math.Round(pntwMinReact.Y * PointW.zoom) > paintBox.Height - 100)
            {
                vScrollBar.Minimum = (int)Math.Round(pntwMinReact.Y * PointW.zoom) - 25;
                vScrollBar.Maximum = (int)Math.Round(pntwMaxReact.Y * PointW.zoom) - paintBox.Height + 50;
            }
            if ((int)Math.Round(pntwMaxReact.X * PointW.zoom)-(int)Math.Round(pntwMinReact.X * PointW.zoom)>paintBox.Width-100) {
                hScrollBar.Minimum = (int)Math.Round(pntwMinReact.X * PointW.zoom) - 150;
                hScrollBar.Maximum = (int)Math.Round(pntwMaxReact.X * PointW.zoom) - (int)((paintBox.Width+50)* PointW.zoom);
            }
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
                if (PropFill.GetCheked())
                    figureArray.Add(new Rect(new Pen(propColor.GetColor(), propWidth.GetWidth()), new PointW(e.X, e.Y), PropFill.GetColor()));
                else
                    figureArray.Add(new Rect(new Pen(propColor.GetColor(), propWidth.GetWidth()), new PointW(e.X, e.Y)));
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
            propColor = new PropColor(new Point(5, 20), "Color:", panelProp);
            propWidth = new PropWidth(new Point(5, 45), "Width:", panelProp);
            PropFill = new PropFill(new Point(5, 45), "Fill:", panelProp);

            checkBoxFill = new CheckBox();
            checkBoxFill.Location = new Point(65, 70);
            checkBoxFill.Size = new Size(48, 26);
            checkBoxFill.Text = "";
            panelProp.Controls.Add(checkBoxFill);
            labelCheckBoxFill = new Label();
            labelCheckBoxFill.Location = new Point(5, 75);
            labelCheckBoxFill.Text = "Fill:";
            panelProp.Controls.Add(labelCheckBoxFill);

            colorButtonFill = new ColorButton(Color.Red);
            colorButtonFill.Location = new Point(65, 100);
            colorButtonFill.Size = new Size(48, 24);
            panelProp.Controls.Add(colorButtonFill);
            labelColorButtonFill = new Label();
            labelColorButtonFill.Location = new Point(5, 100);
            labelColorButtonFill.Text = "Clr Fill:";
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
    class ToolRoundedRect : Tool
    {
        CheckBox checkBoxFill;
        Label labelCheckBoxFill;
        ColorButton colorButtonFill;
        Label labelColorButtonFill;
        NumericUpDown numRadius;
        Label labelNumRadius;


        public ToolRoundedRect(Button button, ref List<Figure> figureArrayFrom, Panel paintBox_set)
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
                    figureArray.Add(new RoundedRect(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y), (int)numRadius.Value, colorButtonFill.color));
                else
                    figureArray.Add(new RoundedRect(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y), (int)numRadius.Value));
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
        private void CreatePanelProp()
        {
            panelProp = new PanelProp();
            panelProp.Text = "Rounded Rect";
            colorButton = new ColorButton(Color.Black);
            colorButton.Location = new Point(65, 15);
            colorButton.Size = new Size(48, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(65, 45);
            numWidthPen.Size = new Size(48, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

            checkBoxFill = new CheckBox();
            checkBoxFill.Location = new Point(65, 70);
            checkBoxFill.Size = new Size(48, 26);
            checkBoxFill.Text = "";
            panelProp.Controls.Add(checkBoxFill);
            labelCheckBoxFill = new Label();
            labelCheckBoxFill.Location = new Point(5, 75);
            labelCheckBoxFill.Text = "Fill:";
            panelProp.Controls.Add(labelCheckBoxFill);

            colorButtonFill = new ColorButton(Color.Red);
            colorButtonFill.Location = new Point(65, 100);
            colorButtonFill.Size = new Size(48, 24);
            panelProp.Controls.Add(colorButtonFill);
            labelColorButtonFill = new Label();
            labelColorButtonFill.Location = new Point(5, 100);

            labelColorButtonFill.Text = "Clr Fill:";
            panelProp.Controls.Add(labelColorButtonFill);

            numRadius = new NumericUpDown();
            numRadius.Location = new Point(65, 130);
            numRadius.Size = new Size(48, 26);
            numRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRadius.Value = new decimal(new int[] { 20, 0, 0, 0 });
            panelProp.Controls.Add(numRadius);
            labelNumRadius = new Label();
            labelNumRadius.Location = new Point(5, 130);

            labelNumRadius.Text = "Radius:";
            panelProp.Controls.Add(labelNumRadius);
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
            colorButton.Location = new Point(65, 15);
            colorButton.Size = new Size(48, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);

            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(65, 45);
            numWidthPen.Size = new Size(48, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);

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
            colorButton.Location = new Point(65, 15);
            colorButton.Size = new Size(48, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);

            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(65, 45);
            numWidthPen.Size = new Size(48, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);

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
                    figureArray.Add(new Ellipse(new Pen(colorButton.color, numWidthPen.penWidth), new PointW(e.X, e.Y), colorButtonFill.color));
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
            colorButton.Location = new Point(65, 15);
            colorButton.Size = new Size(48, 24);
            colorButton.TabIndex = 2;
            panelProp.Controls.Add(colorButton);
            labelColorButton = new Label();
            labelColorButton.Location = new Point(5, 20);
            labelColorButton.Text = "Color:";
            panelProp.Controls.Add(labelColorButton);

            numWidthPen = new NumWidthPen();
            numWidthPen.Location = new Point(65, 45);
            numWidthPen.Size = new Size(48, 26);
            panelProp.Controls.Add(numWidthPen);
            labelNumWidthPen = new Label();
            labelNumWidthPen.Location = new Point(5, 50);
            labelNumWidthPen.Text = "Width:";
            panelProp.Controls.Add(labelNumWidthPen);

            checkBoxFill = new CheckBox();
            checkBoxFill.Location = new Point(65, 70);
            checkBoxFill.Size = new Size(48, 26);
            checkBoxFill.Text = "";
            panelProp.Controls.Add(checkBoxFill);
            labelCheckBoxFill = new Label();
            labelCheckBoxFill.Location = new Point(5, 75);
            labelCheckBoxFill.Text = "Fill:";
            panelProp.Controls.Add(labelCheckBoxFill);

            colorButtonFill = new ColorButton(Color.Red);
            colorButtonFill.Location = new Point(65, 100);
            colorButtonFill.Size = new Size(48, 24);
            panelProp.Controls.Add(colorButtonFill);
            labelColorButtonFill = new Label();
            labelColorButtonFill.Location = new Point(5, 100);
            labelColorButtonFill.Text = "Clr Fill:";
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
        CheckBox checkBoxRegion;
        Label labelCheckBoxRegion;
        NumericUpDown stepZoom;
        Label labelStepZoom;
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
            CreatePanelProp();
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                if (checkBoxRegion.Checked)
                {
                    pointWEnd = new PointW(e.X, e.Y);
                    figureArray.Last().AddPoint(pointWEnd);
                }
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (checkBoxRegion.Checked) {
                    flagLeftMouseClick = true;
                    pointWStart = new PointW(e.X, e.Y);
                    pointWEnd = new PointW(e.X + 1, e.Y + 1);
                    figureArray.Add(new Rect(new Pen(Color.Black), pointWStart));
                    figureArray.Last().AddPoint(pointWStart);
                }
                else
                {
                    pointWStart = new PointW(e.X, e.Y);
                    pointWEnd = new PointW(e.X + 1, e.Y + 1);
                    numZoom.Value += stepZoom.Value;
                    PointW.offset = new Point(
                        (int)Math.Round((PointW.offset.X - e.X) * PointW.zoom / (PointW.zoom - (double)(stepZoom.Value / 100))) + e.X,
                        (int)Math.Round((PointW.offset.Y - e.Y) * PointW.zoom / (PointW.zoom - (double)(stepZoom.Value / 100))) + e.Y);
                }
                paintBox.Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                if (numZoom.Value > stepZoom.Value)
                {
                    numZoom.Value -= (int)stepZoom.Value;
                    PointW.offset = new Point(
                        (int)Math.Round((PointW.offset.X - e.X) * PointW.zoom / (PointW.zoom + (double)(stepZoom.Value / 100))) + e.X,
                        (int)Math.Round((PointW.offset.Y - e.Y) * PointW.zoom / (PointW.zoom + (double)(stepZoom.Value / 100))) + e.Y);
                }
                paintBox.Invalidate();
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (checkBoxRegion.Checked)
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
            panelProp.Controls.Add(stepZoom);
            labelStepZoom = new Label();
            labelStepZoom.Location = new Point(5, 20);
            labelStepZoom.Text = "Step:";
            panelProp.Controls.Add(labelStepZoom);

            checkBoxRegion = new CheckBox();
            checkBoxRegion.Location = new Point(65, 45);
            checkBoxRegion.Size = new Size(48, 24);
            panelProp.Controls.Add(checkBoxRegion);
            labelCheckBoxRegion = new Label();
            labelCheckBoxRegion.Location = new Point(5, 50);
            labelCheckBoxRegion.Text = "Region:";
            panelProp.Controls.Add(labelCheckBoxRegion);


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
      protected  Control control;
      protected Label label;

    }
    class PropColor : Prop
    {
      public  PropColor(Point position, String text ,PanelProp panelProp)
        {         
            control = new ColorButton(Color.Black); 
            control.Location = new Point(position.X+60, position.Y);
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
    class PropWidth : Prop
    {
        public PropWidth(Point position, String text, PanelProp panelProp)
        {
            control = new CheckBox();
            control.Location = new Point(position.X + 60, position.Y);
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
        }
        public int GetWidth()
        {
            NumWidthPen numWidthPen = (NumWidthPen)control;
            return numWidthPen.Width;
        }
    }
    class PropFill : Prop
    {
        PropColor propColor;
        public PropFill(Point position, String text, PanelProp panelProp)
        {

            control = new CheckBox();
            control.Location = new Point(position.X + 60, position.Y);
            panelProp.Controls.Add(control);
            label = new Label
            {
                Location = position,
                Text = text
            };
            panelProp.Controls.Add(label);
            propColor = new PropColor(new Point(position.X, position.Y+25), "Clr fill:", panelProp);
        }
        public bool GetCheked()
        {
            CheckBox checkBox = (CheckBox)control;
            return checkBox.Checked;
        }
        public Color GetColor()
        {
            return propColor.GetColor();
        }
    }
}
