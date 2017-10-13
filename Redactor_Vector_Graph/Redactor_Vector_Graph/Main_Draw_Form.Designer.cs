namespace Redactor_Vector_Graph
{
    partial class Main_Draw_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Draw_Form));
            this.PaintBox = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.color_dialog_main = new System.Windows.Forms.ColorDialog();
            this.but_main_color = new System.Windows.Forms.Button();
            this.numeric_width_pen = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintBox
            // 
            this.PaintBox.AutoSize = true;
            this.PaintBox.BackColor = System.Drawing.SystemColors.Window;
            this.PaintBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaintBox.Location = new System.Drawing.Point(0, 75);
            this.PaintBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.PaintBox.MinimumSize = new System.Drawing.Size(954, 555);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(978, 555);
            this.PaintBox.TabIndex = 0;
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_file,
            this.tool_strip_help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(978, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tool_strip_file
            // 
            this.tool_strip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_exit});
            this.tool_strip_file.Name = "tool_strip_file";
            this.tool_strip_file.Size = new System.Drawing.Size(50, 29);
            this.tool_strip_file.Text = "File";
            // 
            // tool_strip_exit
            // 
            this.tool_strip_exit.Name = "tool_strip_exit";
            this.tool_strip_exit.Size = new System.Drawing.Size(123, 30);
            this.tool_strip_exit.Text = "Exit";
            this.tool_strip_exit.Click += new System.EventHandler(this.tool_strip_exit_Click);
            // 
            // tool_strip_help
            // 
            this.tool_strip_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_about});
            this.tool_strip_help.Name = "tool_strip_help";
            this.tool_strip_help.Size = new System.Drawing.Size(61, 29);
            this.tool_strip_help.Text = "Help";
            // 
            // tool_strip_about
            // 
            this.tool_strip_about.Name = "tool_strip_about";
            this.tool_strip_about.Size = new System.Drawing.Size(146, 30);
            this.tool_strip_about.Text = "About";
            this.tool_strip_about.Click += new System.EventHandler(this.tool_strip_about_Click);
            // 
            // but_main_color
            // 
            this.but_main_color.Location = new System.Drawing.Point(12, 36);
            this.but_main_color.Name = "but_main_color";
            this.but_main_color.Size = new System.Drawing.Size(75, 29);
            this.but_main_color.TabIndex = 2;
            this.but_main_color.UseVisualStyleBackColor = true;
            this.but_main_color.Click += new System.EventHandler(this.but_main_color_Click);
            // 
            // numeric_width_pen
            // 
            this.numeric_width_pen.Location = new System.Drawing.Point(94, 38);
            this.numeric_width_pen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_width_pen.Name = "numeric_width_pen";
            this.numeric_width_pen.Size = new System.Drawing.Size(52, 26);
            this.numeric_width_pen.TabIndex = 3;
            this.numeric_width_pen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_width_pen.ValueChanged += new System.EventHandler(this.numeric_width_pen_ValueChanged);
            // 
            // Main_Draw_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.numeric_width_pen);
            this.Controls.Add(this.but_main_color);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Draw_Form";
            this.Text = "Super Vector Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PaintBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_exit;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_help;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_about;
        private System.Windows.Forms.ColorDialog color_dialog_main;
        private System.Windows.Forms.Button but_main_color;
        private System.Windows.Forms.NumericUpDown numeric_width_pen;
    }
}

