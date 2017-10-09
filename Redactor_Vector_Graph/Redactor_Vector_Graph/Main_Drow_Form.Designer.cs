namespace Redactor_Vector_Graph
{
    partial class Main_Drow_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaintBox = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaintBox
            // 
            this.PaintBox.BackColor = System.Drawing.SystemColors.Window;
            this.PaintBox.Location = new System.Drawing.Point(278, 12);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(680, 464);
            this.PaintBox.TabIndex = 0;
            this.PaintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PaintBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaintBox;
        private System.Windows.Forms.Button button1;
    }
}

