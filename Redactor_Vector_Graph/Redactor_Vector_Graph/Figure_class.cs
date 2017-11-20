using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;

namespace Redactor_Vector_Graph
{
    public class PointW
    {
	   public static  double zoom = 1;
	   public static  Point offset = new Point(0,0);
       public double X;
       public double Y;
	 
	   public PointW(double setX,double setY){
		   X = setX;
		   Y = setY;
	   }
	   public PointW(int setX,int setY){
            ToPointW(new Point(setX,setY));

       }
	   public PointW(){
		   X = 0;
		   Y = 0;
	   }
	   public void ToPointW(Point point){
	      X = (point.X - offset.X)/zoom;
		  Y = (point.Y - offset.Y)/zoom;
	   }
        public static PointW ScrnToPointW(Point point)
        {
            return new PointW((point.X - offset.X) / zoom, (point.Y - offset.Y) / zoom);
        }
        public Point ToScrPnt(){
		   return new Point((int)Math.Round(X*zoom)+offset.X,(int)Math.Round(Y*zoom) + offset.Y);
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
        public virtual bool SelectPoint(PointW pntwClick) { return false;}
    }

    public class PolyLine : Figure
    {
        public List<PointW> points_array = new List<PointW>(10);
        public PolyLine(Pen setPen, PointW start)
        {
            pen = (Pen)setPen.Clone();
            points_array.Add(start);
        }

        public override void AddPoint(PointW pointW)
        {
            points_array.Add(pointW);
        }
        public override void Draw(Graphics graphics)
        {
            PointW lastPointW = points_array[0];
            foreach (PointW pointW in points_array)
            {
                graphics.DrawLine(pen, pointW.ToScrPnt(), lastPointW.ToScrPnt());
                 lastPointW = pointW;
            }
           // graphics.DrawLines(pen, points_array.ToArray());
        }

    }

    public class Rect : Figure
    {
        PointW startPointW;
        PointW endPointW;
        public Rect(Pen setPen, PointW start,Color? setColorFill = null)
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
        public override bool SelectPoint(PointW pntwClick)
        {
            if (1<0)
            {
                isSelected = true;
                return true;
            }
            return false;
        }
        public override void AddPoint(PointW pointW)
        {
            endPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            int x, y;
            x = Math.Min(startPointW.ToScrPnt().X, endPointW.ToScrPnt().X);
            y = Math.Min(startPointW.ToScrPnt().Y, endPointW.ToScrPnt().Y);
            int width = Math.Abs(startPointW.ToScrPnt().X - endPointW.ToScrPnt().X);
            int height = Math.Abs(startPointW.ToScrPnt().Y - endPointW.ToScrPnt().Y);
            graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
            if (isFill)
                   graphics.FillRectangle(new SolidBrush(colorFill), new Rectangle(x + (int)Math.Round(pen.Width / 2,MidpointRounding.AwayFromZero), y + (int)Math.Round(pen.Width / 2, MidpointRounding.AwayFromZero), width - (int)(pen.Width), height - (int)(pen.Width)));
            
            }

    }
    public class RoundedRect : Figure
    {
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

            Rectangle bounds = new Rectangle(x, y, width, height);
            int diameter = radius * 2;
            if(diameter*2 > bounds.Width & bounds.Width <= bounds.Height)
            {
                diameter = bounds.Width+1;
            }
            if (diameter * 2 > bounds.Height & bounds.Width >= bounds.Height)
            {
                diameter = bounds.Height + 1;
            }
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
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
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            graphics.DrawPath(pen, path);
            if (isFill)
                graphics.FillPath(new SolidBrush(colorFill), path);
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

        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, startPointW.ToScrPnt(), lastPointW.ToScrPnt());
        }

    }
    public class Ellipse : Figure
    {
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
        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, new Rectangle(startPointW.ToScrPnt(), 
            new Size(lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X, lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y)));
            if (isFill)
                graphics.FillEllipse(new SolidBrush(colorFill), new Rectangle(startPointW.ToScrPnt(), 
                new Size(lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X, lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y)));
        }
    }
}
