using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.Windows.Forms;
namespace Redactor_Vector_Graph
{
    public class PointW
    {
        public static double zoom = 1;
        public static Point offset = new Point(0, 0);
        public double X;
        public double Y;
        public PointW(double setX, double setY)
        {
            X = setX;
            Y = setY;
        }
        public PointW(int setX, int setY)
        {
            ToPointW(new Point(setX, setY));

        }
        public PointW()
        {
            X = 0;
            Y = 0;
        }
        public void ToPointW(Point point)
        {
            X = (point.X - offset.X) / zoom;
            Y = (point.Y - offset.Y) / zoom;
        }
        public static PointW ScrnToPointW(Point point)
        {
            return new PointW((point.X - offset.X) / zoom, (point.Y - offset.Y) / zoom);
        }
        public Point ToScrPnt()
        {
            return new Point((int)Math.Round(X * zoom) + offset.X, (int)Math.Round(Y * zoom) + offset.Y);
        }
        public PointW Clone()
        {
            return new PointW(X, Y);
        }
    }

    public abstract class Figure
    {

        public Pen pen = new Pen(Color.Black);
        public Color colorFill;
        public bool isFill = false;
        public bool isSelected = false;
        public abstract void Draw(Graphics graphics);
        public abstract void AddPoint(PointW pointW);
        public abstract bool SelectPoint(Point pntClick);
        public abstract void DrawColider(Graphics graphics);
        public virtual bool SelectArea(Rectangle area) { return false; }
        protected void DrawColiderRect(Graphics g, Rectangle rect)
        {
            const int offset = 10;
            rect.X -= offset;
            rect.Y -= offset;
            rect.Width += offset * 2;
            rect.Height += offset * 2;
            Pen penColider = new Pen(Color.Gray);
            penColider.Width = 3;
            penColider.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawRectangle(penColider, rect);
        }
    }

    public class PolyLine : Figure
    {
        PointW pntWmin;
        PointW pntWmax;
        public List<PointW> points_array = new List<PointW>(10);
        public PolyLine(Pen setPen, PointW start)
        {
            pen = (Pen)setPen.Clone();
            points_array.Add(start);
            pntWmin = start.Clone();
            pntWmax = new PointW(0.0, 0.0);
        }
        public override bool SelectPoint(Point pntClick)
        {
            const int dist = 20;
            foreach (PointW pointW in points_array)
            {
                if ((Math.Pow(pointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(pointW.ToScrPnt().Y - pntClick.Y, 2.0)) <= dist * dist)
                {
                    isSelected = true;
                    return true;
                }
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area)
        {
            if(area.Contains(pntWmin.ToScrPnt()) && area.Contains(pntWmax.ToScrPnt()))
            {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            points_array.Add(pointW);
            pntWmin.X = Math.Min(pntWmin.X, pointW.X);
            pntWmin.Y = Math.Min(pntWmin.Y, pointW.Y);
            pntWmax.X = Math.Max(pntWmax.X, pointW.X);
            pntWmax.Y = Math.Max(pntWmax.Y, pointW.Y);
        }
        public override void Draw(Graphics graphics)
        {
            PointW lastPointW = points_array[0];
            foreach (PointW pointW in points_array)
            {
                graphics.DrawLine(pen, pointW.ToScrPnt(), lastPointW.ToScrPnt());
                lastPointW = pointW;
            }
        }
        public override void DrawColider(Graphics graphics)
        {
            if (isSelected)
                DrawColiderRect(graphics, new Rectangle(pntWmin.ToScrPnt().X, pntWmin.ToScrPnt().Y, pntWmax.ToScrPnt().X - pntWmin.ToScrPnt().X, pntWmax.ToScrPnt().Y - pntWmin.ToScrPnt().Y));
        }

    }
    public class Rect : Figure
    {
        Rectangle rectColider;
        PointW startPointW;
        PointW endPointW;
        int x, y, width, height;
        public Rect(Pen setPen, PointW start, Color? setColorFill = null)
        {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            endPointW = start;
            if (setColorFill.HasValue)
            {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
        }
        public override bool SelectPoint(Point pntClick)
        {
            if (rectColider.Contains(pntClick))
            {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            endPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            x = Math.Min(startPointW.ToScrPnt().X, endPointW.ToScrPnt().X);
            y = Math.Min(startPointW.ToScrPnt().Y, endPointW.ToScrPnt().Y);
            width = Math.Abs(startPointW.ToScrPnt().X - endPointW.ToScrPnt().X);
            height = Math.Abs(startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y);
            graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
            if (isFill)
                graphics.FillRectangle(new SolidBrush(colorFill), new Rectangle(x + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero),
                                          y + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), width - (int)(pen.Width), height - (int)(pen.Width)));

            rectColider = new Rectangle(x - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), y - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero),
                             width + (int)(pen.Width), height + (int)(pen.Width));
        }
        public override void DrawColider(Graphics graphics)
        {
            if (isSelected)
                DrawColiderRect(graphics, rectColider);
        }
    }
    public class RoundedRect : Figure
    {
        Rectangle rectColider;
        PointW startPointW;
        PointW lastPointW;
        int radius;
        public RoundedRect(Pen setPen, PointW start, int setRadius, Color? setColorFill = null)
        {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            lastPointW = start;
            radius = setRadius;
            if (setColorFill.HasValue)
            {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
        }
        public override bool SelectPoint(Point pntClick)
        {

            if (rectColider.Contains(pntClick))
            {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;

        }
        public override void Draw(Graphics graphics)
        {
            int x, y;
            x = Math.Min(startPointW.ToScrPnt().X, lastPointW.ToScrPnt().X);
            y = Math.Min(startPointW.ToScrPnt().Y, lastPointW.ToScrPnt().Y);
            int width = Math.Abs(startPointW.ToScrPnt().X - lastPointW.ToScrPnt().X);
            int height = Math.Abs(startPointW.ToScrPnt().Y - lastPointW.ToScrPnt().Y);
            rectColider = new Rectangle(x - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), y - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero),
                        width + (int)(pen.Width), height + (int)(pen.Width));

            int diameter = radius * 2;
            if (diameter * 2 > rectColider.Width & rectColider.Width <= rectColider.Height)
            {
                diameter = rectColider.Width + 1;
            }
            if (diameter * 2 > rectColider.Height & rectColider.Width >= rectColider.Height)
            {
                diameter = rectColider.Height + 1;
            }
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectColider.Location, size);
            GraphicsPath path = new GraphicsPath();
            if (radius == 0)
            {
                graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
                if (isFill)
                    graphics.FillRectangle(new SolidBrush(colorFill), new Rectangle(x + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), y + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), width - (int)(pen.Width), height - (int)(pen.Width)));
                return;
            }
            // top left arc  
            path.AddArc(arc, 180, 90);
            // top right arc  
            arc.X = rectColider.Right - diameter;
            path.AddArc(arc, 270, 90);
            // bottom right arc  
            arc.Y = rectColider.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // bottom left arc 
            arc.X = rectColider.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            graphics.DrawPath(pen, path);
            if (isFill)
                graphics.FillPath(new SolidBrush(colorFill), path);
        }
        public override void DrawColider(Graphics graphics)
        {
            if (isSelected)
                DrawColiderRect(graphics, rectColider);
        }
    }
    public class Line : Figure
    {
        PointW startPointW;
        PointW lastPointW;
        public Line(Pen setPen, PointW start)
        {
            pen = (Pen)setPen.Clone();
            startPointW = start;
        }
        public override bool SelectPoint(Point pntClick)
        {
            const int dist = 20;
            double A, B, C, distToline, distToLastPoint, distToSatrtPoint, lineLength;
            A = startPointW.ToScrPnt().Y - lastPointW.ToScrPnt().Y;
            B = lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X;
            C = -(startPointW.ToScrPnt().X * A + startPointW.ToScrPnt().Y * B);
            lineLength = Math.Sqrt(Math.Pow(startPointW.ToScrPnt().X - lastPointW.ToScrPnt().X, 2.0) + Math.Pow(startPointW.ToScrPnt().Y - lastPointW.ToScrPnt().Y, 2.0));
            distToline = (Math.Abs(A * pntClick.X + B * pntClick.Y + C) / (Math.Sqrt(A * A + B * B)));
            distToSatrtPoint = Math.Sqrt(Math.Pow(startPointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(startPointW.ToScrPnt().Y - pntClick.Y, 2.0)) - lineLength;
            distToLastPoint = Math.Sqrt(Math.Pow(lastPointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(lastPointW.ToScrPnt().Y - pntClick.Y, 2.0)) - lineLength;
            if (distToline <= dist && distToSatrtPoint < dist && distToLastPoint < dist)
            {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, startPointW.ToScrPnt(), lastPointW.ToScrPnt());
        }
        public override void DrawColider(Graphics graphics)
        {
            if (isSelected)
                DrawColiderRect(graphics, new Rectangle(startPointW.ToScrPnt(),
                    new Size(lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X, lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y)));
        }

    }
    public class Ellipse : Figure
    {
        Rectangle rectColider;
        PointW startPointW;
        PointW lastPointW;
        public Ellipse(Pen setPen, PointW start, Color? setColorFill = null)
        {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            lastPointW = start;
            if (setColorFill.HasValue)
            {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
        }
        public override bool SelectPoint(Point pntClick)
        {
            double A = (lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X) / 2;
            double B = (lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y) / 2;
            if (((Math.Pow((pntClick.X - startPointW.ToScrPnt().X - A) / A, 2) + (Math.Pow((pntClick.Y - startPointW.ToScrPnt().Y - B) / B, 2))) <= 1))
            {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            rectColider = new Rectangle(startPointW.ToScrPnt(),
                    new Size(lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X, lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y));
            graphics.DrawEllipse(pen, rectColider);
            if (isFill)
                graphics.FillEllipse(new SolidBrush(colorFill), rectColider);
        }
        public override void DrawColider(Graphics graphics)
        {
            if (isSelected)
                DrawColiderRect(graphics, rectColider);
        }
    }
}
