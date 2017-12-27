using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor_Vector_Graph {
    class UndoRedo {
        const int bufferSize = 5;
        static private Button _btnUndo;
        static private Button _btnRedo;
        static private PaintBox _paintBox;
        static private List<Figure> _figureArray;
        static private RingBuffer<String> ringBuffer = new RingBuffer<string>(30000);
       public static void Init(Button btnUndo, Button btnRedo, PaintBox paintBox, ref List<Figure> figureArray) {
            _btnUndo = btnUndo;
            _btnUndo.Click += Undo;
            _btnRedo = btnRedo;
            _btnRedo.Click += Redo;
            _paintBox = paintBox;
            _figureArray = figureArray;
            SaveState();
        }

        public static void Redo(object sender, EventArgs e) {//
            if (ringBuffer.Up()) {
                _btnUndo.Enabled = true;
                _btnRedo.Enabled = ringBuffer.isLastUp;
                for (int i = _figureArray.Count - 1; i >= 0; i--) {
                    _figureArray.Remove(_figureArray[i]);
                }
                _figureArray.AddRange(SerializerFigure.Parse(ringBuffer.Value));
                _paintBox.Invalidate();
            }
        }

        public static void Undo(object sender, EventArgs e) {
            if (ringBuffer.Down()) {
                _btnRedo.Enabled = true;
                _btnUndo.Enabled = ringBuffer.isLastDown;
                for (int i = _figureArray.Count - 1; i >= 0; i--) {
                    _figureArray.Remove(_figureArray[i]);
                }
                _figureArray.AddRange(SerializerFigure.Parse(ringBuffer.Value));
                _paintBox.Invalidate();
            }


        }
        public static void SaveState() {
            ringBuffer.Push(SerializerFigure.SerializeAllFigures(ref _figureArray));
            _btnRedo.Enabled = false;
            _btnUndo.Enabled = true;
        }


    }
}
