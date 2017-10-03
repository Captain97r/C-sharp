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
        string cal_action = "";
        bool flagDelNum = false;
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
            cal_action = "";
            mainTextBox.Text = "0";
            flagDelNum = false;
            mainTextBox.Font = new Font("Microsoft Sans Serif", 18.0f);
        }

        private void but_CE_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "0";
            mainTextBox.Font = new Font("Microsoft Sans Serif", 18.0f);
        }

        private void but_backspace_Click(object sender, EventArgs e)
        {
            string temp_text = mainTextBox.Text;
            mainTextBox.Text= temp_text.Remove(temp_text.Length-1);
            if (mainTextBox.Text == "")
            {
                mainTextBox.Text = "0";
            }
            if (mainTextBox.Text.Length <= 13)
            {
                mainTextBox.Font = new Font("Microsoft Sans Serif", 18.0f);
            }
        }

        private void but_num_click(object sender, EventArgs e)
        {
            if (flagDelNum) {
                mainTextBox.Text = "";
                flagDelNum = false;
            }
           

            if(mainTextBox.Text == "0") {
                    mainTextBox.Text = "";
                }
                if (mainTextBox.Text.Length < 16) {
                Button but_sender = (Button)sender;
              

                mainTextBox.Text += but_sender.Text;
                if (mainTextBox.Text.Length > 13) {
                    mainTextBox.Font = new Font("Microsoft Sans Serif", 14.7f);
                }
            }
        }

        private void but_coma_Click(object sender, EventArgs e)
        {
            
            if (mainTextBox.Text.IndexOf(",") < 0){
                mainTextBox.Text += ",";
            }
        }

        private void but_binar_actions_Click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
            if (cal_action == but_sender.Text && !flagDelNum)
            {
                compleat_Action(new object(),new EventArgs());
            }
            else
            {
                lastVal = mainTextBox.Text;
                cal_action = but_sender.Text;
                flagDelNum = true;
           //     mainTextBox.Text = "0";
            }
        }

        private void compleat_Action(object sender, EventArgs e)
        {
            int LastVal_int = int.Parse(lastVal);
            int Val_int = int.Parse(mainTextBox.Text);
            switch (cal_action) {
                case "+":
                    mainTextBox.Text = ""+(LastVal_int + Val_int);
                    break;

                case "-":
                    mainTextBox.Text = "" + (LastVal_int - Val_int);
                    break;
            }

           // cal_action = "";

            lastVal = mainTextBox.Text;
            flagDelNum = true;
        }

        private void but_MC_Click(object sender, EventArgs e)
        {

        }
    }
}
