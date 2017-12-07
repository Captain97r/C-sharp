using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Redactor_Vector_Graph {
    public class PointW {
        public static double zoom = 1;
        public static Point offset = new Point(0, 0);
        public double X;
        public double Y;
        public PointW(double setX, double setY) {
            X = setX;
            Y = setY;
        }
        public PointW(int setX, int setY) {
            ToPointW(new Point(setX, setY));

        }
        public PointW() {
            X = 0;
            Y = 0;
        }
        public void ToPointW(Point point) {
            X = (point.X - offset.X) / zoom;
            Y = (point.Y - offset.Y) / zoom;
        }
        public static PointW ScrnToPointW(Point point) {
            return new PointW((point.X - offset.X) / zoom, (point.Y - offset.Y) / zoom);
        }
        public Point ToScrPnt() {
            return new Point((int)Math.Round(X * zoom) + offset.X, (int)Math.Round(Y * zoom) + offset.Y);
        }
        public PointW Clone() {
            return new PointW(X, Y);
        }
    }

    public abstract class Figure {
        public List<Anchor> anchorArray = new List<Anchor>(8);
        public Pen pen = new Pen(Color.Black);
        public Color colorFill;
        public bool isFill = false;
        public bool isSelected = false;
        public Rectangle rectColider;
        public virtual void Draw(Graphics graphics) { }
        public virtual void AddPoint(PointW pointW) { }
        public virtual bool SelectPoint(Point pntClick) { return false; }
        public virtual void DrawColider(Graphics graphics) { }
        public virtual bool SelectArea(Rectangle area) { return false; }
    }

    public class PolyLine : Figure {
        PointW pntWmin;
        PointW pntWmax;
        public List<PointW> pointsArray = new List<PointW>(10);
        public PolyLine(Pen setPen, PointW start) {
            pen = (Pen)setPen.Clone();
            pointsArray.Add(start);
            anchorArray.Add(new Anchor(pointsArray,pointsArray.Count-1));
            pntWmin = start.Clone();
            pntWmax = new PointW(0.0, 0.0);
        }
        public override bool SelectPoint(Point pntClick) {
            const int dist = 20;
            foreach (PointW pointW in pointsArray) {
                if ((Math.Pow(pointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(pointW.ToScrPnt().Y - pntClick.Y, 2.0)) <= dist * dist) {
                    isSelected = true;
                    return true;
                }
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area) =>
            area.Contains(pntWmin.ToScrPnt()) && area.Contains(pntWmax.ToScrPnt());
 
        public override void AddPoint(PointW pointW) {
            pointsArray.Add(pointW);
            pntWmin.X = Math.Min(pntWmin.X, pointW.X);
            pntWmin.Y = Math.Min(pntWmin.Y, pointW.Y);
            pntWmax.X = Math.Max(pntWmax.X, pointW.X);
            pntWmax.Y = Math.Max(pntWmax.Y, pointW.Y);
            anchorArray.Add(new Anchor(pointsArray, pointsArray.Count - 1));
        }
        public override void Draw(Graphics graphics) {
            PointW lastPointW = pointsArray[0];
            foreach (PointW pointW in pointsArray) {
                graphics.DrawLine(pen, pointW.ToScrPnt(), lastPointW.ToScrPnt());
                lastPointW = pointW;
            }
        }
        public override void DrawColider(Graphics graphics) {
            if (isSelected) {
                foreach (Anchor anchor in anchorArray) {
                    anchor.Draw(graphics);
                }
            }
        }
    }
    public class Line : Figure {
        PointW startPointW;
        PointW endPointW;
        public Line(Pen setPen, PointW start) {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            anchorArray.Add(new Anchor(ref startPointW));
            anchorArray.Add(new Anchor(ref endPointW));
        }
        public override bool SelectPoint(Point pntClick) {
            const int dist = 20;
            double A, B, C, distToline, distToEndPoint, distToSatrtPoint, lineLength;
            A = startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y;
            B = endPointW.ToScrPnt().X - startPointW.ToScrPnt().X;
            C = -(startPointW.ToScrPnt().X * A + startPointW.ToScrPnt().Y * B);
            lineLength = Math.Sqrt(Math.Pow(startPointW.ToScrPnt().X - endPointW.ToScrPnt().X, 2.0) + Math.Pow(startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y, 2.0));
            distToline = (Math.Abs(A * pntClick.X + B * pntClick.Y + C) / (Math.Sqrt(A * A + B * B)));
            distToSatrtPoint = Math.Sqrt(Math.Pow(startPointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(startPointW.ToScrPnt().Y - pntClick.Y, 2.0)) - lineLength;
            distToEndPoint = Math.Sqrt(Math.Pow(endPointW.ToScrPnt().X - pntClick.X, 2.0) + Math.Pow(endPointW.ToScrPnt().Y - pntClick.Y, 2.0)) - lineLength;
            if (distToline <= dist && distToSatrtPoint < dist && distToEndPoint < dist) {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area) =>
            area.Contains(startPointW.ToScrPnt()) && area.Contains(endPointW.ToScrPnt());
        public override void AddPoint(PointW pointW) {
            endPointW = pointW;
            anchorArray[0] = new Anchor(ref startPointW);
            anchorArray[1] = new Anchor(ref endPointW);
        }
        public override void Draw(Graphics graphics) {
            graphics.DrawLine(pen, startPointW.ToScrPnt(), endPointW.ToScrPnt());
        }
        public override void DrawColider(Graphics graphics) {
            if (isSelected) {
                anchorArray[0].Draw(graphics);
                anchorArray[1].Draw(graphics);
            }
        }
    }
    public class RectangularFigure : Figure {
       public PointW startPointW;
       public PointW endPointW;
       protected void CreateAnchors() {
            anchorArray.Add(new Anchor(ref startPointW));
            anchorArray.Add(new Anchor(ref endPointW));
        }
        protected void SetAnchors() {
            
        }
        public override void AddPoint(PointW pointW) {
            endPointW = pointW;
            anchorArray[0] = new Anchor(ref startPointW);
            anchorArray[1] = new Anchor(ref endPointW);
        }
        protected void DrawColiderRect(Graphics g, Rectangle rect) {
            rectColider = rect;
            Pen penColider = new Pen(Color.Gray);
            penColider.Width = 3;
            penColider.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawRectangle(penColider, rect);
            anchorArray[0].Draw(g);
            //  anchorArray[1].Draw(g, new Point(rect.X+rect.Width, rect.Y + rect.Height));
            anchorArray[1].Draw(g);
        }

    }
    public class Rect : RectangularFigure {
        int x, y, width, height;
        public Rect(Pen setPen, PointW start, Color? setColorFill = null) {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            endPointW = start;
            if (setColorFill.HasValue) {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
            CreateAnchors();
        }
        public override bool SelectPoint(Point pntClick) {
            if (rectColider.Contains(pntClick)) {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area) =>
            area.Contains(startPointW.ToScrPnt()) && area.Contains(endPointW.ToScrPnt());
    
        public override void Draw(Graphics graphics) {
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
        public override void DrawColider(Graphics graphics) {
            if (isSelected)
                DrawColiderRect(graphics, new Rectangle(x, y, width, height));
        }
    }
    public class RoundedRect : RectangularFigure {
        int radius;
        public RoundedRect(Pen setPen, PointW start, int setRadius, Color? setColorFill = null) {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            endPointW = start;
            radius = setRadius;
            if (setColorFill.HasValue) {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
            CreateAnchors();
        }
        public override bool SelectPoint(Point pntClick) {
            if (rectColider.Contains(pntClick)) {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area) =>
            area.Contains(startPointW.ToScrPnt()) && area.Contains(endPointW.ToScrPnt());

        public override void Draw(Graphics graphics) {
            int x, y;
            x = Math.Min(startPointW.ToScrPnt().X, endPointW.ToScrPnt().X);
            y = Math.Min(startPointW.ToScrPnt().Y, endPointW.ToScrPnt().Y);
            int width = Math.Abs(startPointW.ToScrPnt().X - endPointW.ToScrPnt().X);
            int height = Math.Abs(startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y);
            rectColider = new Rectangle(x - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), y - (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero),
                        width + (int)(pen.Width), height + (int)(pen.Width));

            int diameter = radius * 2;
            if (diameter * 2 > rectColider.Width & rectColider.Width <= rectColider.Height) {
                diameter = rectColider.Width + 1;
            }
            if (diameter * 2 > rectColider.Height & rectColider.Width >= rectColider.Height) {
                diameter = rectColider.Height + 1;
            }
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectColider.Location, size);
            GraphicsPath path = new GraphicsPath();
            if (radius == 0) {
                graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
                if (isFill)
                    graphics.FillRectangle(new SolidBrush(colorFill), new Rectangle(x + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), y + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), width - (int)(pen.Width), height - (int)(pen.Width)));
                return;
            }
            path.AddArc(arc, 180, 90);
            arc.X = rectColider.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectColider.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectColider.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            graphics.DrawPath(pen, path);
            if (isFill)
                graphics.FillPath(new SolidBrush(colorFill), path);
        }
        public override void DrawColider(Graphics graphics) {
            if (isSelected)
                DrawColiderRect(graphics, rectColider);
        }
    }
    public class Ellipse : RectangularFigure {
        public Ellipse(Pen setPen, PointW start, Color? setColorFill = null) {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            endPointW = start;
            if (setColorFill.HasValue) {
                colorFill = (Color)setColorFill;
                isFill = true;
            }
            CreateAnchors();
        }

        public override bool SelectPoint(Point pntClick) {
            double A = (endPointW.ToScrPnt().X - startPointW.ToScrPnt().X) / 2;
            double B = (endPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y) / 2;
            if (((Math.Pow((pntClick.X - startPointW.ToScrPnt().X - A) / A, 2) + (Math.Pow((pntClick.Y - startPointW.ToScrPnt().Y - B) / B, 2))) <= 1)) {
                isSelected = true;
                return true;
            }
            isSelected = false;
            return false;
        }
        public override bool SelectArea(Rectangle area) =>
            area.Contains(startPointW.ToScrPnt()) && area.Contains(endPointW.ToScrPnt());

        public override void Draw(Graphics graphics) {
            rectColider = new Rectangle(startPointW.ToScrPnt(),
                    new Size(endPointW.ToScrPnt().X - startPointW.ToScrPnt().X, endPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y));
            graphics.DrawEllipse(pen, rectColider);
            if (isFill)
                graphics.FillEllipse(new SolidBrush(colorFill), rectColider);
        }
        public override void DrawColider(Graphics graphics) {
            if (isSelected)
                DrawColiderRect(graphics, new Rectangle(Math.Min(startPointW.ToScrPnt().X, endPointW.ToScrPnt().X), Math.Min(startPointW.ToScrPnt().Y, endPointW.ToScrPnt().Y),
                  Math.Abs(startPointW.ToScrPnt().X - endPointW.ToScrPnt().X), Math.Abs(startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y)));
        }
    }
    public class Anchor {
        public PointW editedPoint;
        public PointW anchorPoint;
        public Rectangle rect;
        public Anchor(ref PointW editedPointSet) {
            editedPoint = editedPointSet;
        }
        public Anchor(List<PointW> editedPointSet, int index) {
            editedPoint = editedPointSet[index];
        }
        public void EditPoint(Point pointTo) {
            PointW pointW = PointW.ScrnToPointW(pointTo);
            editedPoint.X = pointW.X;
            editedPoint.Y = pointW.Y;
        }
        public void Draw(Graphics g) {
            const int width = 4;
            Point point = editedPoint.ToScrPnt();
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            rect = new Rectangle(point.X - width, point.Y - width, width*2, width*2);
            g.DrawRectangle(pen, rect);
            g.FillRectangle(new SolidBrush(Color.White), rect);

        }

    }
}
