using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Tool
    {
        public static Tool ActiveTool { get; set; }
        public Button toolButton;
        public List<Figure> figureArray;
        public Pen toolPen;
        public Panel paintBox;
        protected bool flagLeftMouseClick = false;
        protected bool flagRightMouseClick = false;

        public void ToolButtonClick(object sender, EventArgs e)
        {
            ActiveTool = this;
        }
        public virtual void MouseMove(object sender, MouseEventArgs e) { }
        public virtual void MouseDown(object sender, MouseEventArgs e) { }
        public virtual void MouseUp(object sender, MouseEventArgs e) { }
    }

    class ToolReact : Tool
    {
        public ToolReact(Button button, ref List<Figure> figureArrayFrom, Pen pen, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            toolPen = pen;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new Point(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new Rect(toolPen, new Point(e.X, e.Y)));

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

    class ToolPolyLine : Tool
    {
        public ToolPolyLine(Button button, ref List<Figure> figureArrayFrom, Pen pen, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            toolPen = pen;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new Point(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new PolyLine(toolPen, new Point(e.X, e.Y)));
                figureArray.Last().AddPoint(new Point(e.X, e.Y));

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

    class ToolLine : Tool
    {
        public ToolLine(Button button, ref List<Figure> figureArrayFrom, Pen pen, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            toolPen = pen;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new Point(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new Line(toolPen, new Point(e.X, e.Y)));
                figureArray.Last().AddPoint(new Point(e.X, e.Y));

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

    class ToolEllipse : Tool
    {
        public ToolEllipse(Button button, ref List<Figure> figureArrayFrom, Pen pen, Panel paintBox_set)
        {
            paintBox = paintBox_set;
            toolPen = pen;
            figureArray = figureArrayFrom;
            toolButton = button;
            toolButton.Click += new EventHandler(ToolButtonClick);
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (flagLeftMouseClick)
            {
                figureArray.Last().AddPoint(new Point(e.X, e.Y));
                paintBox.Invalidate();
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagLeftMouseClick = true;
                figureArray.Add(new Ellipse(toolPen, new Point(e.X, e.Y)));
                figureArray.Last().AddPoint(new Point(e.X, e.Y));

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
}
