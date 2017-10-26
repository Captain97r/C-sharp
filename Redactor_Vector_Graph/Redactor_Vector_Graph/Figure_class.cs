using System.Collections.Generic;
using System.Drawing;
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
		   X = (setX - offset.X)/zoom;
		  Y = (setY - offset.X)/zoom;
	   }
	   public PointW(){
		   X = 0;
		   Y = 0;
	   }
	   public void ToPointW(Point point){
	      X = (point.X - offset.X)/zoom;
		  Y = (point.Y - offset.Y)/zoom;
	   }
	   public Point ToScrPnt(){
		   return new Point((int)Math.Round(X*zoom)+offset.X,(int)Math.Round(Y*zoom) + offset.Y);
	   }
    }

    public abstract class Figure
    {
        public Pen pen = new Pen(Color.Black);
        public abstract void Draw(Graphics graphics);
        public abstract void AddPoint(PointW pointW);
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
        PointW startPoint;
        PointW lastPointW;
        public Rect(Pen setPen, PointW start)
        {
            pen = (Pen)setPen.Clone();
            startPoint = start;
            lastPointW = start;
        }

        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;

        }
        public override void Draw(Graphics graphics)
        {
            int x, y;
            x = Math.Min(startPoint.ToScrPnt().X, lastPointW.ToScrPnt().X);
            y = Math.Min(startPoint.ToScrPnt().Y, lastPointW.ToScrPnt().Y);
            int width = Math.Abs(startPoint.ToScrPnt().X - lastPointW.ToScrPnt().X);
            int height = Math.Abs(startPoint.ToScrPnt().Y - lastPointW.ToScrPnt().Y);
            graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
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
        public Ellipse(Pen setPen, PointW start)
        {
            pen = (Pen)setPen.Clone();
            startPointW = start;
            lastPointW = start;
        }

        public override void AddPoint(PointW pointW)
        {
            lastPointW = pointW;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, new Rectangle(startPointW.ToScrPnt(), new Size(lastPointW.ToScrPnt().X - startPointW.ToScrPnt().X, lastPointW.ToScrPnt().Y - startPointW.ToScrPnt().Y)));
        }

    }


}
