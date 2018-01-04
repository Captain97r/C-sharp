using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Redactor_Vector_Graph {
    class Export {
        public static void ToSvg(string fileName, List<Figure> figureArray) {
            string text = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"1000\" height=\"1000\">";
            foreach (var figure in figureArray)
                text += figure.ToSvgFormat();
            text += "</svg>";
            using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
                using (StreamWriter sw = new StreamWriter(fs)) {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
