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
            this.numWidthPen = new System.Windows.Forms.NumericUpDown();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnToolEllipse = new System.Windows.Forms.Button();
            this.btnToolRect = new System.Windows.Forms.Button();
            this.btnToolLine = new System.Windows.Forms.Button();
            this.btnToolPolyLine = new System.Windows.Forms.Button();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.paintBox = new Redactor_Vector_Graph.PaintBox();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthPen)).BeginInit();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1037, 33);
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
            // btnMainColor
            // 
            this.btnMainColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainColor.FlatAppearance.BorderSize = 0;
            this.btnMainColor.Location = new System.Drawing.Point(5, 9);
            this.btnMainColor.Name = "btnMainColor";
            this.btnMainColor.Size = new System.Drawing.Size(52, 24);
            this.btnMainColor.TabIndex = 2;
            this.btnMainColor.UseVisualStyleBackColor = false;
            this.btnMainColor.Click += new System.EventHandler(this.but_main_color_Click);
            // 
            // numWidthPen
            // 
            this.numWidthPen.Location = new System.Drawing.Point(63, 11);
            this.numWidthPen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidthPen.Name = "numWidthPen";
            this.numWidthPen.Size = new System.Drawing.Size(52, 26);
            this.numWidthPen.TabIndex = 3;
            this.numWidthPen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidthPen.ValueChanged += new System.EventHandler(this.numeric_width_pen_ValueChanged);
            // 
            // toolPanel
            // 
            this.toolPanel.AutoSize = true;
            this.toolPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolPanel.Controls.Add(this.btnResetZoom);
            this.toolPanel.Controls.Add(this.lblZoom);
            this.toolPanel.Controls.Add(this.numZoom);
            this.toolPanel.Controls.Add(this.btnZoom);
            this.toolPanel.Controls.Add(this.btnHand);
            this.toolPanel.Controls.Add(this.btnToolEllipse);
            this.toolPanel.Controls.Add(this.btnToolRect);
            this.toolPanel.Controls.Add(this.btnToolLine);
            this.toolPanel.Controls.Add(this.btnToolPolyLine);
            this.toolPanel.Controls.Add(this.numWidthPen);
            this.toolPanel.Controls.Add(this.btnMainColor);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 33);
            this.toolPanel.MinimumSize = new System.Drawing.Size(110, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(120, 493);
            this.toolPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 0);
            this.panel2.TabIndex = 4;
            // 
            // btnZoom
            // 
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.Location = new System.Drawing.Point(5, 175);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(54, 54);
            this.btnZoom.TabIndex = 8;
            this.btnZoom.UseVisualStyleBackColor = true;
            // 
            // btnHand
            // 
            this.btnHand.Image = global::Redactor_Vector_Graph.Properties.Resources.handImage;
            this.btnHand.Location = new System.Drawing.Point(63, 175);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(54, 54);
            this.btnHand.TabIndex = 7;
            this.btnHand.UseVisualStyleBackColor = true;
            // 
            // btnToolEllipse
            // 
            this.btnToolEllipse.Image = global::Redactor_Vector_Graph.Properties.Resources.CircleImage;
            this.btnToolEllipse.Location = new System.Drawing.Point(5, 115);
            this.btnToolEllipse.Name = "btnToolEllipse";
            this.btnToolEllipse.Size = new System.Drawing.Size(54, 54);
            this.btnToolEllipse.TabIndex = 6;
            this.btnToolEllipse.UseVisualStyleBackColor = true;
            // 
            // btnToolRect
            // 
            this.btnToolRect.Image = global::Redactor_Vector_Graph.Properties.Resources.RectImage;
            this.btnToolRect.Location = new System.Drawing.Point(63, 115);
            this.btnToolRect.Name = "btnToolRect";
            this.btnToolRect.Size = new System.Drawing.Size(54, 54);
            this.btnToolRect.TabIndex = 5;
            this.btnToolRect.UseVisualStyleBackColor = true;
            // 
            // btnToolLine
            // 
            this.btnToolLine.Image = global::Redactor_Vector_Graph.Properties.Resources.LineImage;
            this.btnToolLine.Location = new System.Drawing.Point(63, 55);
            this.btnToolLine.Name = "btnToolLine";
            this.btnToolLine.Size = new System.Drawing.Size(54, 54);
            this.btnToolLine.TabIndex = 4;
            this.btnToolLine.UseVisualStyleBackColor = true;
            // 
            // btnToolPolyLine
            // 
            this.btnToolPolyLine.Image = global::Redactor_Vector_Graph.Properties.Resources.PolyLineImage;
            this.btnToolPolyLine.Location = new System.Drawing.Point(5, 55);
            this.btnToolPolyLine.Name = "btnToolPolyLine";
            this.btnToolPolyLine.Size = new System.Drawing.Size(54, 54);
            this.btnToolPolyLine.TabIndex = 0;
            this.btnToolPolyLine.UseVisualStyleBackColor = true;
            // 
            // numZoom
            // 
            this.numZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numZoom.Location = new System.Drawing.Point(61, 464);
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(54, 26);
            this.numZoom.TabIndex = 9;
            // 
            // paintBox
            // 
            this.paintBox.AutoSize = true;
            this.paintBox.BackColor = System.Drawing.SystemColors.Window;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 33);
            this.paintBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.paintBox.MinimumSize = new System.Drawing.Size(960, 555);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1037, 555);
            this.paintBox.TabIndex = 0;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(3, 466);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(54, 20);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom:";
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetZoom.Location = new System.Drawing.Point(61, 430);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(54, 28);
            this.btnResetZoom.TabIndex = 11;
            this.btnResetZoom.Text = "reset";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            // 
            // MainDrawForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 526);
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
            ((System.ComponentModel.ISupportInitialize)(this.numWidthPen)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numWidthPen;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToolEllipse;
        private System.Windows.Forms.Button btnToolRect;
        private System.Windows.Forms.Button btnToolLine;
        private System.Windows.Forms.Button btnToolPolyLine;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnHand;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnResetZoom;
    }
}

