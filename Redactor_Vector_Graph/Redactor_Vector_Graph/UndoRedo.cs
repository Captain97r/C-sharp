using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor_Vector_Graph {
    class UndoRedo {
        const int bufferSize = 30000;
        static private bool firstSaveState = false;
        static private Button _btnUndo;
        static private Button _btnRedo;
        static private PaintBox _paintBox;
        static private List<Figure> _figureArray;
        static private RingBuffer<String> ringBuffer = new RingBuffer<string>(bufferSize);
        public static void Init(Button btnUndo, Button btnRedo, PaintBox paintBox, ref List<Figure> figureArray) {
            _btnUndo = btnUndo;
            _btnUndo.Click += Undo;
            _btnRedo = btnRedo;
            _btnRedo.Click += Redo;
            _paintBox = paintBox;
            _figureArray = figureArray;
            ringBuffer.Push(SerializerFigure.SerializeAllFigures(ref _figureArray));
        }

        public static void Redo(object sender, EventArgs e) {
            if (!firstSaveState) return;
            _btnUndo.Enabled = true;
            _btnRedo.Enabled = ringBuffer.Up(); ;
            for (int i = _figureArray.Count - 1; i >= 0; i--) {
                    _figureArray.Remove(_figureArray[i]);
                }
                _figureArray.AddRange(SerializerFigure.Parse(ringBuffer.Value));
                _paintBox.Invalidate();
            
        }

        public static void Undo(object sender, EventArgs e) {
            if (!firstSaveState) return;
                _btnRedo.Enabled = true;
                _btnUndo.Enabled = ringBuffer.Down();

            for (int i = _figureArray.Count - 1; i >= 0; i--) {
                _figureArray.Remove(_figureArray[i]);
            }
            _figureArray.AddRange(SerializerFigure.Parse(ringBuffer.Value));
            _paintBox.Invalidate();
        }
        public static void SaveState() {
            firstSaveState = true;
            ringBuffer.Push(SerializerFigure.SerializeAllFigures(ref _figureArray));
            _btnRedo.Enabled = false;
            _btnUndo.Enabled = true;
        }


    }
}
