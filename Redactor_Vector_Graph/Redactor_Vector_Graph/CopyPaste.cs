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
