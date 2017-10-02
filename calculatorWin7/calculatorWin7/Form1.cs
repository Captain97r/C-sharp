using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWin7
{
    public partial class Form1 : Form
    {
        string lastVal = "0";
        public Form1()
        {
            InitializeComponent();
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_C_Click(object sender, EventArgs e)
        {
            lastVal = "0";
            mainTextBox.Text = "0";
        }

        private void but_CE_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "0";
        }

        private void but_backspace_Click(object sender, EventArgs e)
        {
            string temp_text = mainTextBox.Text;
            mainTextBox.Text= temp_text.Remove(temp_text.Length-1);
            if (mainTextBox.Text == "")
            {
                mainTextBox.Text = "0";
            }

        }

        private void but_num_click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
            if (mainTextBox.Text == "0")
            {
                mainTextBox.Text = "";
            }

            mainTextBox.Text += but_sender.Text;
        }

       
    }
}
