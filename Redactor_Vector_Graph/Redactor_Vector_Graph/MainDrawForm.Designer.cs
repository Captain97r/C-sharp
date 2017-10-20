namespace Redactor_Vector_Graph
{
    partial class MainDrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDrawForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.btnMainColor = new System.Windows.Forms.Button();
            this.numeric_width_pen = new System.Windows.Forms.NumericUpDown();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.btnToolEllipse = new System.Windows.Forms.Button();
            this.btnToolRect = new System.Windows.Forms.Button();
            this.btnToolLine = new System.Windows.Forms.Button();
            this.btnToolPolyLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paintBox = new Redactor_Vector_Graph.PaintBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.btnMainColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainColor.FlatAppearance.BorderSize = 0;
            this.btnMainColor.Location = new System.Drawing.Point(5, 9);
            this.btnMainColor.Name = "but_main_color";
            this.btnMainColor.Size = new System.Drawing.Size(52, 24);
            this.btnMainColor.TabIndex = 2;
            this.btnMainColor.UseVisualStyleBackColor = false;
            this.btnMainColor.Click += new System.EventHandler(this.but_main_color_Click);
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
            this.toolPanel.Controls.Add(this.btnToolEllipse);
            this.toolPanel.Controls.Add(this.btnToolRect);
            this.toolPanel.Controls.Add(this.btnToolLine);
            this.toolPanel.Controls.Add(this.btnToolPolyLine);
            this.toolPanel.Controls.Add(this.numeric_width_pen);
            this.toolPanel.Controls.Add(this.btnMainColor);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 33);
            this.toolPanel.MinimumSize = new System.Drawing.Size(110, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(120, 603);
            this.toolPanel.TabIndex = 0;
            // 
            // buttonToolEllipse
            // 
            this.btnToolEllipse.Image = global::Redactor_Vector_Graph.Properties.Resources.CircleImage;
            this.btnToolEllipse.Location = new System.Drawing.Point(5, 115);
            this.btnToolEllipse.Name = "buttonToolEllipse";
            this.btnToolEllipse.Size = new System.Drawing.Size(54, 54);
            this.btnToolEllipse.TabIndex = 6;
            this.btnToolEllipse.UseVisualStyleBackColor = true;
            // 
            // buttonToolRect
            // 
            this.btnToolRect.Image = global::Redactor_Vector_Graph.Properties.Resources.RectImage;
            this.btnToolRect.Location = new System.Drawing.Point(63, 115);
            this.btnToolRect.Name = "buttonToolRect";
            this.btnToolRect.Size = new System.Drawing.Size(54, 54);
            this.btnToolRect.TabIndex = 5;
            this.btnToolRect.UseVisualStyleBackColor = true;
            // 
            // buttonToolLine
            // 
            this.btnToolLine.Image = global::Redactor_Vector_Graph.Properties.Resources.LineImage;
            this.btnToolLine.Location = new System.Drawing.Point(63, 55);
            this.btnToolLine.Name = "buttonToolLine";
            this.btnToolLine.Size = new System.Drawing.Size(54, 54);
            this.btnToolLine.TabIndex = 4;
            this.btnToolLine.UseVisualStyleBackColor = true;
            // 
            // buttonToolPolyLine
            // 
            this.btnToolPolyLine.Image = global::Redactor_Vector_Graph.Properties.Resources.PolyLineImage;
            this.btnToolPolyLine.Location = new System.Drawing.Point(5, 55);
            this.btnToolPolyLine.Name = "buttonToolPolyLine";
            this.btnToolPolyLine.Size = new System.Drawing.Size(54, 54);
            this.btnToolPolyLine.TabIndex = 0;
            this.btnToolPolyLine.UseVisualStyleBackColor = true;
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
            // PaintBox
            // 
            this.paintBox.AutoSize = true;
            this.paintBox.BackColor = System.Drawing.SystemColors.Window;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 33);
            this.paintBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.paintBox.MinimumSize = new System.Drawing.Size(960, 555);
            this.paintBox.Name = "PaintBox";
            this.paintBox.Size = new System.Drawing.Size(1078, 603);
            this.paintBox.TabIndex = 0;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // MainDrawForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 636);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainDrawForm";
            this.Text = "Super Vector Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Draw_Form_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width_pen)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintBox paintBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_exit;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_help;
        private System.Windows.Forms.ToolStripMenuItem tool_strip_about;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Button btnMainColor;
        private System.Windows.Forms.NumericUpDown numeric_width_pen;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToolEllipse;
        private System.Windows.Forms.Button btnToolRect;
        private System.Windows.Forms.Button btnToolLine;
        private System.Windows.Forms.Button btnToolPolyLine;
    }
}

