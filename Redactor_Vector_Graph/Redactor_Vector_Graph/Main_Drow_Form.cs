using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    public partial class Main_Drow_Form : Form
    {

        bool Flag_Right_CLick = false;
        Graphics graph_PaintBox;
        Point lastPoint = new Point(0,0);
        Pen pen1 = new Pen(Color.Blue);
        public Main_Drow_Form()
        {
            InitializeComponent();
            graph_PaintBox = PaintBox.CreateGraphics();
            this.Paint += Form1_Paint;
        
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graph_PaintBox.DrawLine(pen1, 0, 0, 120, 120);

        
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            graph_PaintBox.Clear(Color.White);
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              
                Flag_Right_CLick = true;
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               Flag_Right_CLick = false;

            }
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Flag_Right_CLick)
            {
                graph_PaintBox.DrawLine(pen1, lastPoint, new Point(e.X,e.Y));
                lastPoint = new Point(e.X, e.Y);
            }
        }
    }
}
