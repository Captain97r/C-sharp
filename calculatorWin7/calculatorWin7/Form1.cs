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
    public partial class Calculator_form : Form
    {
        string lastVal = "0";
        string cal_action = "";
        bool flagDelNum = false;
        bool flagEndNum = false;
        bool flagOneEq = false;
        double memory = 0.0;
        double LastVal_double = 0.0;
        double Val_double = 0.0;

        public Calculator_form()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form_KeyDown);
            
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void but_C_Click(object sender, EventArgs e){
            lastVal = "0";
            cal_action = "";
            mainTextBox.Text = "0";
            flagDelNum = false;
            flagOneEq = false;
            LastVal_double = 0.0;
            Val_double = 0.0;
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
            if (mainTextBox.Text == "") {
                mainTextBox.Text = "0";
            }
            if (mainTextBox.Text.Length <= 13) {
                mainTextBox.Font = new Font("Microsoft Sans Serif", 18.0f);
            }
        }

        private void but_num_click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
            if (flagDelNum) {
                mainTextBox.Text = "0";
                flagDelNum = false;
            }
            if (flagEndNum) {

                but_C_Click(new object(), new EventArgs());
                flagEndNum = false;
            }
            if (mainTextBox.Text.IndexOf(",") < 0 && but_sender.Name == "but_coma") {
                mainTextBox.Text += ",";
            }
            else {
                if (mainTextBox.Text == "0"){
                    mainTextBox.Text = "";
                }
                if (mainTextBox.Text.Length < 16)
                {
                    mainTextBox.Text += but_sender.Text;
                    if (mainTextBox.Text.Length > 13){
                        mainTextBox.Font = new Font("Microsoft Sans Serif", 14.7f);
                    }
                }
            }
        }

        private void but_unar_actions_Click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
            double Val_double = Double.Parse(mainTextBox.Text);
            switch (but_sender.Text)
            {
                case "∓":
                    mainTextBox.Text = "" + (Val_double * -1);
                    break;
                case "√":
                    mainTextBox.Text = "" + (Math.Sqrt(Val_double));
                    break;
                case "1/x":
                    mainTextBox.Text = "" + (1 / Val_double);
                    break;
            }
            lastVal = mainTextBox.Text;
        }
        private void but_binar_actions_Click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
            if (cal_action == but_sender.Text && !flagDelNum)
            {
                flagOneEq = true;
                compleat_Action(new object(),new EventArgs()); 
            }
            else
            {
                lastVal = mainTextBox.Text;
                cal_action = but_sender.Text;
                flagDelNum = true;
                flagOneEq = true;
                flagEndNum = false;
            }
        }

        private void compleat_Action(object sender, EventArgs e)
        {
            LastVal_double = Double.Parse(lastVal);
            if (sender is Button)
            {
                flagEndNum = true;
            }
            if (flagOneEq)
            {
                Val_double = Double.Parse(mainTextBox.Text);             
                flagOneEq = false;
            }

            if (sender is Button)
            {
                Button but_sender = (Button)sender;
                if (but_sender.Name == "but_eq")
                {
                    flagEndNum = true;
                }
                if (but_sender.Name == "but_percent")
                {
                    Val_double = LastVal_double* Val_double/100;
                    mainTextBox.Text = "" + Val_double;
                    return;
                }
            }
            switch (cal_action) {
                case "+":
                    mainTextBox.Text = ""+(LastVal_double + Val_double);
                    break;

                case "-":
                    mainTextBox.Text = "" + (LastVal_double - Val_double);
                    break;
                case "*":
                    mainTextBox.Text = "" + (LastVal_double * Val_double);
                    break;
                case "/":
                    mainTextBox.Text = "" + (LastVal_double / Val_double);
                    break;
            }
            lastVal = mainTextBox.Text;
            flagDelNum = true;
        }

        private void but_memory_click(object sender, EventArgs e)
        {
            Button but_sender = (Button)sender;
          
            switch (but_sender.Text)
            {
                case "MS":
                    but_MC.Enabled = true;
                    but_MR.Enabled = true;
                    memory = Double.Parse(mainTextBox.Text);
                    label_M.Visible = true;
                    flagDelNum = true;
                    break;
                case "M+":
                    but_MC.Enabled = true;
                    but_MR.Enabled = true;
                    memory += Double.Parse(mainTextBox.Text);
                    label_M.Visible = true;
                    flagDelNum = true;
                    break;
                case "M-":
                    but_MC.Enabled = true;
                    but_MR.Enabled = true;
                    memory -= Double.Parse(mainTextBox.Text);
                    label_M.Visible = true;
                    flagDelNum = true;
                    break;
                case "MC":
                    but_MC.Enabled = false;
                    but_MR.Enabled = false;
                    memory = 0 ;
                    label_M.Visible = false;
                    break;
                case "MR":
                    mainTextBox.Text = "" + memory;
                    flagDelNum = true;
                    break;
            }

       }


        void Form_KeyDown(object o, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)//Ctrl+C
            {
                Clipboard.SetText(mainTextBox.Text);

            }
            if (e.Control && e.KeyCode == Keys.V)//Ctrl+V
            {
                mainTextBox.Text = Clipboard.GetText();

            }
            if (e.Shift && e.KeyCode == Keys.D8)//Shift + 8(*) (mul)
            {
                but_binar_actions_Click(but_mul, EventArgs.Empty);
                return;
            }
         
            switch (e.KeyValue)
            {
                case 48://Key 0 
                    but_num_click(but_num_0, EventArgs.Empty);
                    break;
                case 49://Key 1
                    but_num_click(but_num_1, EventArgs.Empty);
                    break;
                case 50://Key 2
                    but_num_click(but_num_2, EventArgs.Empty);
                    break;
                case 51://Key 3
                    but_num_click(but_num_3, EventArgs.Empty);
                    break;
                case 52://Key 4
                    but_num_click(but_num_4, EventArgs.Empty);
                    break;
                case 53://Key 5
                    but_num_click(but_num_5, EventArgs.Empty);
                    break;
                case 54://Key 6
                    but_num_click(but_num_6, EventArgs.Empty);
                    break;
                case 55://Key 7
                    but_num_click(but_num_7, EventArgs.Empty);
                    break;
                case 56://Key 8
                    but_num_click(but_num_8, EventArgs.Empty);
                    break;
                case 57://Key 9
                    but_num_click(but_num_9, EventArgs.Empty);
                    break;
                case 13:// press "Enter"
                    compleat_Action(but_eq, EventArgs.Empty);
                    break;
                case 187:// press "+"
                    but_binar_actions_Click(but_pluse, EventArgs.Empty);
                    break;
                case 189:// press "-"
                    but_binar_actions_Click(but_sub, EventArgs.Empty);
                    break;
                case 191:// press "-"
                    but_binar_actions_Click(but_div, EventArgs.Empty);
                    break;
                default:
                 //   mainTextBox.Text = ""+ e.KeyValue;
                    break;
            }
           

        }
        private void non_focus(object sender, EventArgs e)
        {
            non_focus_label.Focus();

        }
    }
}
