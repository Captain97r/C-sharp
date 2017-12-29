using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor_Vector_Graph {
    class CopyPaste {
        const int Offeset = 50;
        static void Cut(List<Figure> selectedFigureArray, ref List<Figure> figureArray) {
            Clipboard.SetText(MainDrawForm.Signature + SerializerFigure.SerializeAllFigures(ref selectedFigureArray));
        }

      public  static void Copy(List<Figure> selectedFigureArray) {
            if (selectedFigureArray == null) return;
            Clipboard.SetText(MainDrawForm.Signature + SerializerFigure.SerializeAllFigures(ref selectedFigureArray));
            const int imgOffsetX = 200;
            const int border = 100;
            PointW.offset.X -= imgOffsetX;
            Point min = selectedFigureArray[0].startPointW.ToScrPnt();
            Point max = selectedFigureArray[0].endPointW.ToScrPnt();
            foreach (var figure in selectedFigureArray) {
                min.X = Math.Min(figure.startPointW.ToScrPnt().X,min.X);
                min.Y = Math.Min(figure.startPointW.ToScrPnt().Y, min.Y);
                min.X = Math.Min(figure.endPointW.ToScrPnt().X, min.X);
                min.Y = Math.Min(figure.endPointW.ToScrPnt().Y, min.Y);
                max.X = Math.Max(figure.startPointW.ToScrPnt().X, max.X);
                max.Y = Math.Max(figure.startPointW.ToScrPnt().Y, max.Y);
                max.X = Math.Max(figure.endPointW.ToScrPnt().X, max.X);
                max.Y = Math.Max(figure.endPointW.ToScrPnt().Y, max.Y);
            }
            Bitmap bitmap = new Bitmap(Math.Abs(max.X-min.X)+border, Math.Abs(max.Y -min.Y) + border);
            Graphics g = Graphics.FromImage(bitmap);
            foreach (var figure in selectedFigureArray) {
                figure.Draw(g);
            }
            PointW.offset.X += imgOffsetX;
            Clipboard.SetImage(bitmap);
        }

      public  static void Paste(ref List<Figure> figureArray) {
            if (Clipboard.ContainsText()) {
                string str = Clipboard.GetText();
                if (str.Substring(0, MainDrawForm.Signature.Length) == MainDrawForm.Signature) {
                    str = str.Remove(0, MainDrawForm.Signature.Length);
                    Figure[] figures = SerializerFigure.Parse(str);
                    foreach (var figure in figures)
                        figure.Move(PointW.ScrnToPointW(new Point(Offeset, Offeset)));
                    figureArray.AddRange(figures);
                }
            }
        }
    }
}
