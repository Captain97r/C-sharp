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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintBox
            // 
            this.PaintBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PaintBox.BackColor = System.Drawing.SystemColors.Window;
            this.PaintBox.Location = new System.Drawing.Point(12, 42);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(1246, 568);
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
            this.menuStrip.Size = new System.Drawing.Size(1278, 33);
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
            this.tool_strip_exit.Size = new System.Drawing.Size(210, 30);
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
            this.tool_strip_about.Size = new System.Drawing.Size(210, 30);
            this.tool_strip_about.Text = "About";
            this.tool_strip_about.Click += new System.EventHandler(this.tool_strip_about_Click);
            // 
            // Main_Drow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Drow_Form";
            this.Text = "Super Vector Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}

