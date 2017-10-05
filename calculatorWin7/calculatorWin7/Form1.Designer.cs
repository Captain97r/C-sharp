namespace calculatorWin7
{
    partial class Calculator_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator_form));
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.but_MC = new System.Windows.Forms.Button();
            this.but_MR = new System.Windows.Forms.Button();
            this.but_MS = new System.Windows.Forms.Button();
            this.but_M_pluse = new System.Windows.Forms.Button();
            this.but_M_div = new System.Windows.Forms.Button();
            this.but_sqrt = new System.Windows.Forms.Button();
            this.but_obr = new System.Windows.Forms.Button();
            this.but_C = new System.Windows.Forms.Button();
            this.but_CE = new System.Windows.Forms.Button();
            this.but_backspace = new System.Windows.Forms.Button();
            this.but_percent = new System.Windows.Forms.Button();
            this.but_div = new System.Windows.Forms.Button();
            this.but_num_9 = new System.Windows.Forms.Button();
            this.but_num_8 = new System.Windows.Forms.Button();
            this.but_num_7 = new System.Windows.Forms.Button();
            this.but_invert = new System.Windows.Forms.Button();
            this.but_mul = new System.Windows.Forms.Button();
            this.but_num_6 = new System.Windows.Forms.Button();
            this.but_num_5 = new System.Windows.Forms.Button();
            this.but_num_4 = new System.Windows.Forms.Button();
            this.but_sub = new System.Windows.Forms.Button();
            this.but_num_3 = new System.Windows.Forms.Button();
            this.but_num_2 = new System.Windows.Forms.Button();
            this.but_num_1 = new System.Windows.Forms.Button();
            this.but_eq = new System.Windows.Forms.Button();
            this.but_pluse = new System.Windows.Forms.Button();
            this.but_coma = new System.Windows.Forms.Button();
            this.but_num_0 = new System.Windows.Forms.Button();
            this.label_M = new System.Windows.Forms.Label();
            this.non_focus_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mainTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox.MaxLength = 15;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(294, 48);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TabStop = false;
            this.mainTextBox.Text = "0";
            this.mainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mainTextBox.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_MC
            // 
            this.but_MC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_MC.Enabled = false;
            this.but_MC.FlatAppearance.BorderSize = 0;
            this.but_MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.but_MC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_MC.Location = new System.Drawing.Point(12, 66);
            this.but_MC.Name = "but_MC";
            this.but_MC.Size = new System.Drawing.Size(54, 54);
            this.but_MC.TabIndex = 1;
            this.but_MC.TabStop = false;
            this.but_MC.Text = "MC";
            this.but_MC.UseVisualStyleBackColor = false;
            this.but_MC.Click += new System.EventHandler(this.but_memory_click);
            this.but_MC.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_MR
            // 
            this.but_MR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_MR.Enabled = false;
            this.but_MR.FlatAppearance.BorderSize = 0;
            this.but_MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.but_MR.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_MR.Location = new System.Drawing.Point(72, 66);
            this.but_MR.Name = "but_MR";
            this.but_MR.Size = new System.Drawing.Size(54, 54);
            this.but_MR.TabIndex = 2;
            this.but_MR.TabStop = false;
            this.but_MR.Text = "MR";
            this.but_MR.UseVisualStyleBackColor = false;
            this.but_MR.Click += new System.EventHandler(this.but_memory_click);
            this.but_MR.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_MS
            // 
            this.but_MS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_MS.FlatAppearance.BorderSize = 0;
            this.but_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_MS.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_MS.Location = new System.Drawing.Point(132, 66);
            this.but_MS.Name = "but_MS";
            this.but_MS.Size = new System.Drawing.Size(54, 54);
            this.but_MS.TabIndex = 3;
            this.but_MS.TabStop = false;
            this.but_MS.Text = "MS";
            this.but_MS.UseVisualStyleBackColor = false;
            this.but_MS.Click += new System.EventHandler(this.but_memory_click);
            this.but_MS.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_M_pluse
            // 
            this.but_M_pluse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_M_pluse.FlatAppearance.BorderSize = 0;
            this.but_M_pluse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_M_pluse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_M_pluse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_M_pluse.Location = new System.Drawing.Point(192, 66);
            this.but_M_pluse.Name = "but_M_pluse";
            this.but_M_pluse.Size = new System.Drawing.Size(54, 54);
            this.but_M_pluse.TabIndex = 4;
            this.but_M_pluse.TabStop = false;
            this.but_M_pluse.Text = "M+";
            this.but_M_pluse.UseVisualStyleBackColor = false;
            this.but_M_pluse.Click += new System.EventHandler(this.but_memory_click);
            this.but_M_pluse.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_M_div
            // 
            this.but_M_div.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_M_div.FlatAppearance.BorderSize = 0;
            this.but_M_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_M_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_M_div.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_M_div.Location = new System.Drawing.Point(252, 66);
            this.but_M_div.Name = "but_M_div";
            this.but_M_div.Size = new System.Drawing.Size(54, 54);
            this.but_M_div.TabIndex = 5;
            this.but_M_div.TabStop = false;
            this.but_M_div.Text = "M-";
            this.but_M_div.UseVisualStyleBackColor = false;
            this.but_M_div.Click += new System.EventHandler(this.but_memory_click);
            this.but_M_div.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_sqrt
            // 
            this.but_sqrt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_sqrt.FlatAppearance.BorderSize = 0;
            this.but_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_sqrt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_sqrt.Location = new System.Drawing.Point(252, 126);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(54, 54);
            this.but_sqrt.TabIndex = 10;
            this.but_sqrt.TabStop = false;
            this.but_sqrt.Text = "√";
            this.but_sqrt.UseVisualStyleBackColor = false;
            this.but_sqrt.Click += new System.EventHandler(this.but_unar_actions_Click);
            this.but_sqrt.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_obr
            // 
            this.but_obr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_obr.FlatAppearance.BorderSize = 0;
            this.but_obr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_obr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.but_obr.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_obr.Location = new System.Drawing.Point(192, 126);
            this.but_obr.Name = "but_obr";
            this.but_obr.Size = new System.Drawing.Size(54, 54);
            this.but_obr.TabIndex = 9;
            this.but_obr.TabStop = false;
            this.but_obr.Text = "∓";
            this.but_obr.UseVisualStyleBackColor = false;
            this.but_obr.Click += new System.EventHandler(this.but_unar_actions_Click);
            this.but_obr.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_C
            // 
            this.but_C.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_C.FlatAppearance.BorderSize = 0;
            this.but_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_C.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_C.Location = new System.Drawing.Point(132, 126);
            this.but_C.Name = "but_C";
            this.but_C.Size = new System.Drawing.Size(54, 54);
            this.but_C.TabIndex = 8;
            this.but_C.TabStop = false;
            this.but_C.Text = "C";
            this.but_C.UseVisualStyleBackColor = false;
            this.but_C.Click += new System.EventHandler(this.but_C_Click);
            this.but_C.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_CE
            // 
            this.but_CE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_CE.FlatAppearance.BorderSize = 0;
            this.but_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_CE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_CE.Location = new System.Drawing.Point(72, 126);
            this.but_CE.Name = "but_CE";
            this.but_CE.Size = new System.Drawing.Size(54, 54);
            this.but_CE.TabIndex = 7;
            this.but_CE.TabStop = false;
            this.but_CE.Text = "CE";
            this.but_CE.UseVisualStyleBackColor = false;
            this.but_CE.Click += new System.EventHandler(this.but_CE_Click);
            this.but_CE.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_backspace
            // 
            this.but_backspace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_backspace.FlatAppearance.BorderSize = 0;
            this.but_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_backspace.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_backspace.Location = new System.Drawing.Point(12, 126);
            this.but_backspace.Name = "but_backspace";
            this.but_backspace.Size = new System.Drawing.Size(54, 54);
            this.but_backspace.TabIndex = 6;
            this.but_backspace.TabStop = false;
            this.but_backspace.Text = "←";
            this.but_backspace.UseVisualStyleBackColor = false;
            this.but_backspace.Click += new System.EventHandler(this.but_backspace_Click);
            this.but_backspace.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_percent
            // 
            this.but_percent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_percent.FlatAppearance.BorderSize = 0;
            this.but_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_percent.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_percent.Location = new System.Drawing.Point(252, 186);
            this.but_percent.Name = "but_percent";
            this.but_percent.Size = new System.Drawing.Size(54, 54);
            this.but_percent.TabIndex = 15;
            this.but_percent.TabStop = false;
            this.but_percent.Text = "%";
            this.but_percent.UseVisualStyleBackColor = false;
            this.but_percent.Click += new System.EventHandler(this.compleat_Action);
            this.but_percent.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_div
            // 
            this.but_div.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_div.FlatAppearance.BorderSize = 0;
            this.but_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_div.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_div.Location = new System.Drawing.Point(192, 186);
            this.but_div.Name = "but_div";
            this.but_div.Size = new System.Drawing.Size(54, 54);
            this.but_div.TabIndex = 14;
            this.but_div.TabStop = false;
            this.but_div.Text = "/";
            this.but_div.UseVisualStyleBackColor = false;
            this.but_div.Click += new System.EventHandler(this.but_binar_actions_Click);
            this.but_div.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_9
            // 
            this.but_num_9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_num_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_9.FlatAppearance.BorderSize = 0;
            this.but_num_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_9.Location = new System.Drawing.Point(132, 186);
            this.but_num_9.Name = "but_num_9";
            this.but_num_9.Size = new System.Drawing.Size(54, 54);
            this.but_num_9.TabIndex = 13;
            this.but_num_9.TabStop = false;
            this.but_num_9.Text = "9";
            this.but_num_9.UseVisualStyleBackColor = false;
            this.but_num_9.Click += new System.EventHandler(this.but_num_click);
            this.but_num_9.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_8
            // 
            this.but_num_8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_8.FlatAppearance.BorderSize = 0;
            this.but_num_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_8.Location = new System.Drawing.Point(72, 186);
            this.but_num_8.Name = "but_num_8";
            this.but_num_8.Size = new System.Drawing.Size(54, 54);
            this.but_num_8.TabIndex = 12;
            this.but_num_8.TabStop = false;
            this.but_num_8.Text = "8";
            this.but_num_8.UseVisualStyleBackColor = false;
            this.but_num_8.Click += new System.EventHandler(this.but_num_click);
            this.but_num_8.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_7
            // 
            this.but_num_7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_7.FlatAppearance.BorderSize = 0;
            this.but_num_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_7.Location = new System.Drawing.Point(12, 186);
            this.but_num_7.Name = "but_num_7";
            this.but_num_7.Size = new System.Drawing.Size(54, 54);
            this.but_num_7.TabIndex = 11;
            this.but_num_7.TabStop = false;
            this.but_num_7.Text = "7";
            this.but_num_7.UseVisualStyleBackColor = false;
            this.but_num_7.Click += new System.EventHandler(this.but_num_click);
            this.but_num_7.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_invert
            // 
            this.but_invert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_invert.FlatAppearance.BorderSize = 0;
            this.but_invert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_invert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_invert.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_invert.Location = new System.Drawing.Point(252, 246);
            this.but_invert.Name = "but_invert";
            this.but_invert.Size = new System.Drawing.Size(54, 54);
            this.but_invert.TabIndex = 20;
            this.but_invert.TabStop = false;
            this.but_invert.Text = "1/x";
            this.but_invert.UseVisualStyleBackColor = false;
            this.but_invert.Click += new System.EventHandler(this.but_unar_actions_Click);
            this.but_invert.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_mul
            // 
            this.but_mul.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_mul.FlatAppearance.BorderSize = 0;
            this.but_mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_mul.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_mul.Location = new System.Drawing.Point(192, 246);
            this.but_mul.Name = "but_mul";
            this.but_mul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_mul.Size = new System.Drawing.Size(54, 54);
            this.but_mul.TabIndex = 19;
            this.but_mul.TabStop = false;
            this.but_mul.Text = "*";
            this.but_mul.UseVisualStyleBackColor = false;
            this.but_mul.Click += new System.EventHandler(this.but_binar_actions_Click);
            this.but_mul.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_6
            // 
            this.but_num_6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_6.FlatAppearance.BorderSize = 0;
            this.but_num_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_6.Location = new System.Drawing.Point(132, 246);
            this.but_num_6.Name = "but_num_6";
            this.but_num_6.Size = new System.Drawing.Size(54, 54);
            this.but_num_6.TabIndex = 18;
            this.but_num_6.TabStop = false;
            this.but_num_6.Text = "6";
            this.but_num_6.UseVisualStyleBackColor = false;
            this.but_num_6.Click += new System.EventHandler(this.but_num_click);
            this.but_num_6.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_5
            // 
            this.but_num_5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_5.FlatAppearance.BorderSize = 0;
            this.but_num_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_5.Location = new System.Drawing.Point(72, 246);
            this.but_num_5.Name = "but_num_5";
            this.but_num_5.Size = new System.Drawing.Size(54, 54);
            this.but_num_5.TabIndex = 17;
            this.but_num_5.TabStop = false;
            this.but_num_5.Text = "5";
            this.but_num_5.UseVisualStyleBackColor = false;
            this.but_num_5.Click += new System.EventHandler(this.but_num_click);
            this.but_num_5.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_4
            // 
            this.but_num_4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_4.FlatAppearance.BorderSize = 0;
            this.but_num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_4.Location = new System.Drawing.Point(12, 246);
            this.but_num_4.Name = "but_num_4";
            this.but_num_4.Size = new System.Drawing.Size(54, 54);
            this.but_num_4.TabIndex = 16;
            this.but_num_4.TabStop = false;
            this.but_num_4.Text = "4";
            this.but_num_4.UseVisualStyleBackColor = false;
            this.but_num_4.Click += new System.EventHandler(this.but_num_click);
            this.but_num_4.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_sub
            // 
            this.but_sub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_sub.FlatAppearance.BorderSize = 0;
            this.but_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_sub.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_sub.Location = new System.Drawing.Point(192, 306);
            this.but_sub.Name = "but_sub";
            this.but_sub.Size = new System.Drawing.Size(54, 54);
            this.but_sub.TabIndex = 24;
            this.but_sub.TabStop = false;
            this.but_sub.Text = "-";
            this.but_sub.UseVisualStyleBackColor = false;
            this.but_sub.Click += new System.EventHandler(this.but_binar_actions_Click);
            this.but_sub.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_3
            // 
            this.but_num_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_3.FlatAppearance.BorderSize = 0;
            this.but_num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_3.Location = new System.Drawing.Point(132, 306);
            this.but_num_3.Name = "but_num_3";
            this.but_num_3.Size = new System.Drawing.Size(54, 54);
            this.but_num_3.TabIndex = 23;
            this.but_num_3.TabStop = false;
            this.but_num_3.Text = "3";
            this.but_num_3.UseVisualStyleBackColor = false;
            this.but_num_3.Click += new System.EventHandler(this.but_num_click);
            this.but_num_3.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_2
            // 
            this.but_num_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_2.FlatAppearance.BorderSize = 0;
            this.but_num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_2.Location = new System.Drawing.Point(72, 306);
            this.but_num_2.Name = "but_num_2";
            this.but_num_2.Size = new System.Drawing.Size(54, 54);
            this.but_num_2.TabIndex = 22;
            this.but_num_2.TabStop = false;
            this.but_num_2.Text = "2";
            this.but_num_2.UseVisualStyleBackColor = false;
            this.but_num_2.Click += new System.EventHandler(this.but_num_click);
            this.but_num_2.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_1
            // 
            this.but_num_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_1.FlatAppearance.BorderSize = 0;
            this.but_num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_1.Location = new System.Drawing.Point(12, 306);
            this.but_num_1.Name = "but_num_1";
            this.but_num_1.Size = new System.Drawing.Size(54, 54);
            this.but_num_1.TabIndex = 21;
            this.but_num_1.TabStop = false;
            this.but_num_1.Text = "1";
            this.but_num_1.UseVisualStyleBackColor = false;
            this.but_num_1.Click += new System.EventHandler(this.but_num_click);
            this.but_num_1.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_eq
            // 
            this.but_eq.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_eq.FlatAppearance.BorderSize = 0;
            this.but_eq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_eq.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_eq.Location = new System.Drawing.Point(252, 306);
            this.but_eq.Name = "but_eq";
            this.but_eq.Size = new System.Drawing.Size(54, 114);
            this.but_eq.TabIndex = 30;
            this.but_eq.TabStop = false;
            this.but_eq.Text = "=";
            this.but_eq.UseVisualStyleBackColor = false;
            this.but_eq.Click += new System.EventHandler(this.compleat_Action);
            this.but_eq.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_pluse
            // 
            this.but_pluse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_pluse.FlatAppearance.BorderSize = 0;
            this.but_pluse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_pluse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_pluse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_pluse.Location = new System.Drawing.Point(192, 366);
            this.but_pluse.Name = "but_pluse";
            this.but_pluse.Size = new System.Drawing.Size(54, 54);
            this.but_pluse.TabIndex = 29;
            this.but_pluse.TabStop = false;
            this.but_pluse.Text = "+";
            this.but_pluse.UseVisualStyleBackColor = false;
            this.but_pluse.Click += new System.EventHandler(this.but_binar_actions_Click);
            this.but_pluse.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_coma
            // 
            this.but_coma.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_coma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_coma.FlatAppearance.BorderSize = 0;
            this.but_coma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_coma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_coma.Location = new System.Drawing.Point(132, 366);
            this.but_coma.Name = "but_coma";
            this.but_coma.Size = new System.Drawing.Size(54, 54);
            this.but_coma.TabIndex = 28;
            this.but_coma.TabStop = false;
            this.but_coma.Text = ",";
            this.but_coma.UseVisualStyleBackColor = false;
            this.but_coma.Click += new System.EventHandler(this.but_num_click);
            this.but_coma.Enter += new System.EventHandler(this.non_focus);
            // 
            // but_num_0
            // 
            this.but_num_0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.but_num_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_num_0.FlatAppearance.BorderSize = 0;
            this.but_num_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_num_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_num_0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_num_0.Location = new System.Drawing.Point(12, 366);
            this.but_num_0.Name = "but_num_0";
            this.but_num_0.Size = new System.Drawing.Size(114, 54);
            this.but_num_0.TabIndex = 27;
            this.but_num_0.TabStop = false;
            this.but_num_0.Text = "0";
            this.but_num_0.UseVisualStyleBackColor = false;
            this.but_num_0.Click += new System.EventHandler(this.but_num_click);
            this.but_num_0.Enter += new System.EventHandler(this.non_focus);
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_M.Location = new System.Drawing.Point(14, 14);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(24, 22);
            this.label_M.TabIndex = 31;
            this.label_M.Text = "M";
            this.label_M.Visible = false;
            // 
            // non_focus_label
            // 
            this.non_focus_label.AutoSize = true;
            this.non_focus_label.Location = new System.Drawing.Point(278, 2);
            this.non_focus_label.Name = "non_focus_label";
            this.non_focus_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.non_focus_label.Size = new System.Drawing.Size(0, 20);
            this.non_focus_label.TabIndex = 32;
            // 
            // Calculator_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(318, 432);
            this.Controls.Add(this.non_focus_label);
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.but_eq);
            this.Controls.Add(this.but_pluse);
            this.Controls.Add(this.but_coma);
            this.Controls.Add(this.but_num_0);
            this.Controls.Add(this.but_sub);
            this.Controls.Add(this.but_num_3);
            this.Controls.Add(this.but_num_2);
            this.Controls.Add(this.but_num_1);
            this.Controls.Add(this.but_invert);
            this.Controls.Add(this.but_mul);
            this.Controls.Add(this.but_num_6);
            this.Controls.Add(this.but_num_5);
            this.Controls.Add(this.but_num_4);
            this.Controls.Add(this.but_percent);
            this.Controls.Add(this.but_div);
            this.Controls.Add(this.but_num_9);
            this.Controls.Add(this.but_num_8);
            this.Controls.Add(this.but_num_7);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_obr);
            this.Controls.Add(this.but_C);
            this.Controls.Add(this.but_CE);
            this.Controls.Add(this.but_backspace);
            this.Controls.Add(this.but_M_div);
            this.Controls.Add(this.but_M_pluse);
            this.Controls.Add(this.but_MS);
            this.Controls.Add(this.but_MR);
            this.Controls.Add(this.but_MC);
            this.Controls.Add(this.mainTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calculator_form";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button but_MC;
        private System.Windows.Forms.Button but_MR;
        private System.Windows.Forms.Button but_MS;
        private System.Windows.Forms.Button but_M_pluse;
        private System.Windows.Forms.Button but_M_div;
        private System.Windows.Forms.Button but_sqrt;
        private System.Windows.Forms.Button but_obr;
        private System.Windows.Forms.Button but_C;
        private System.Windows.Forms.Button but_CE;
        private System.Windows.Forms.Button but_backspace;
        private System.Windows.Forms.Button but_percent;
        private System.Windows.Forms.Button but_div;
        private System.Windows.Forms.Button but_num_9;
        private System.Windows.Forms.Button but_num_8;
        private System.Windows.Forms.Button but_num_7;
        private System.Windows.Forms.Button but_invert;
        private System.Windows.Forms.Button but_mul;
        private System.Windows.Forms.Button but_num_5;
        private System.Windows.Forms.Button but_num_4;
        private System.Windows.Forms.Button but_sub;
        private System.Windows.Forms.Button but_num_3;
        private System.Windows.Forms.Button but_num_2;
        private System.Windows.Forms.Button but_num_1;
        private System.Windows.Forms.Button but_eq;
        private System.Windows.Forms.Button but_pluse;
        private System.Windows.Forms.Button but_coma;
        private System.Windows.Forms.Button but_num_0;
        private System.Windows.Forms.Button but_num_6;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Label non_focus_label;
    }
}

