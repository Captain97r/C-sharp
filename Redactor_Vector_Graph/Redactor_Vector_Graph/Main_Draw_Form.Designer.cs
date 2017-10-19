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
            this.PaintBox = new PaintBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.color_dialog_main = new System.Windows.Forms.ColorDialog();
            this.but_main_color = new System.Windows.Forms.Button();
            this.numeric_width_pen = new System.Windows.Forms.NumericUpDown();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.buttonToolCircle = new System.Windows.Forms.Button();
            this.buttonToolRect = new System.Windows.Forms.Button();
            this.buttonToolLine = new System.Windows.Forms.Button();
            this.buttonToolPolyLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintBox
            // 
            this.PaintBox.AutoSize = true;
            this.PaintBox.BackColor = System.Drawing.SystemColors.Window;
            this.PaintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaintBox.Location = new System.Drawing.Point(0, 33);
            this.PaintBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.PaintBox.MinimumSize = new System.Drawing.Size(960, 555);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(1078, 603);
            this.PaintBox.TabIndex = 0;
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_file,
            this.tool_strip_help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1078, 33);
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
            this.but_main_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_main_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_main_color.FlatAppearance.BorderSize = 0;
            this.but_main_color.Location = new System.Drawing.Point(5, 9);
            this.but_main_color.Name = "but_main_color";
            this.but_main_color.Size = new System.Drawing.Size(52, 24);
            this.but_main_color.TabIndex = 2;
            this.but_main_color.UseVisualStyleBackColor = false;
            this.but_main_color.Click += new System.EventHandler(this.but_main_color_Click);
            // 
            // numeric_width_pen
            // 
            this.numeric_width_pen.Location = new System.Drawing.Point(63, 11);
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
            // toolPanel
            // 
            this.toolPanel.AutoSize = true;
            this.toolPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolPanel.Controls.Add(this.buttonToolCircle);
            this.toolPanel.Controls.Add(this.buttonToolRect);
            this.toolPanel.Controls.Add(this.buttonToolLine);
            this.toolPanel.Controls.Add(this.buttonToolPolyLine);
            this.toolPanel.Controls.Add(this.numeric_width_pen);
            this.toolPanel.Controls.Add(this.but_main_color);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 33);
            this.toolPanel.MinimumSize = new System.Drawing.Size(110, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(120, 603);
            this.toolPanel.TabIndex = 0;
            // 
            // buttonToolCircle
            // 
            this.buttonToolCircle.Image = global::Redactor_Vector_Graph.Properties.Resources.CircleImage;
            this.buttonToolCircle.Location = new System.Drawing.Point(5, 115);
            this.buttonToolCircle.Name = "buttonToolCircle";
            this.buttonToolCircle.Size = new System.Drawing.Size(54, 54);
            this.buttonToolCircle.TabIndex = 6;
            this.buttonToolCircle.UseVisualStyleBackColor = true;
            // 
            // buttonToolRect
            // 
            this.buttonToolRect.Image = global::Redactor_Vector_Graph.Properties.Resources.RectImage;
            this.buttonToolRect.Location = new System.Drawing.Point(63, 115);
            this.buttonToolRect.Name = "buttonToolRect";
            this.buttonToolRect.Size = new System.Drawing.Size(54, 54);
            this.buttonToolRect.TabIndex = 5;
            this.buttonToolRect.UseVisualStyleBackColor = true;
            // 
            // buttonToolLine
            // 
            this.buttonToolLine.Image = global::Redactor_Vector_Graph.Properties.Resources.LineImage;
            this.buttonToolLine.Location = new System.Drawing.Point(63, 55);
            this.buttonToolLine.Name = "buttonToolLine";
            this.buttonToolLine.Size = new System.Drawing.Size(54, 54);
            this.buttonToolLine.TabIndex = 4;
            this.buttonToolLine.UseVisualStyleBackColor = true;
            // 
            // buttonToolPolyLine
            // 
            this.buttonToolPolyLine.Image = global::Redactor_Vector_Graph.Properties.Resources.PolyLineImage;
            this.buttonToolPolyLine.Location = new System.Drawing.Point(5, 55);
            this.buttonToolPolyLine.Name = "buttonToolPolyLine";
            this.buttonToolPolyLine.Size = new System.Drawing.Size(54, 54);
            this.buttonToolPolyLine.TabIndex = 0;
            this.buttonToolPolyLine.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 0);
            this.panel2.TabIndex = 4;
            // 
            // Main_Draw_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 636);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Draw_Form";
            this.Text = "Super Vector Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintBox PaintBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_exit;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_help;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_about;
        private System.Windows.Forms.ColorDialog color_dialog_main;
        private System.Windows.Forms.Button but_main_color;
        private System.Windows.Forms.NumericUpDown numeric_width_pen;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonToolCircle;
        private System.Windows.Forms.Button buttonToolRect;
        private System.Windows.Forms.Button buttonToolLine;
        private System.Windows.Forms.Button buttonToolPolyLine;
    }
}

