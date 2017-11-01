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
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.btnMainColor = new System.Windows.Forms.Button();
            this.numWidthPen = new System.Windows.Forms.NumericUpDown();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnToolEllipse = new System.Windows.Forms.Button();
            this.btnToolRect = new System.Windows.Forms.Button();
            this.btnToolLine = new System.Windows.Forms.Button();
            this.btnToolPolyLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paintBox = new Redactor_Vector_Graph.PaintBox();
            this.vScrollBarOffset = new System.Windows.Forms.VScrollBar();
            this.hScrollBarOffset = new System.Windows.Forms.HScrollBar();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthPen)).BeginInit();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.paintBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1085, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExit});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(50, 29);
            this.toolStripFile.Text = "File";
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(123, 30);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAbout});
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(61, 29);
            this.toolStripHelp.Text = "Help";
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(146, 30);
            this.toolStripAbout.Text = "About";
            this.toolStripAbout.Click += new System.EventHandler(this.ToolStripAbout_Click);
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
            this.btnMainColor.Click += new System.EventHandler(this.btnMainColor_Click);
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
            this.toolPanel.Size = new System.Drawing.Size(120, 571);
            this.toolPanel.TabIndex = 0;
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetZoom.Location = new System.Drawing.Point(61, 508);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(54, 28);
            this.btnResetZoom.TabIndex = 11;
            this.btnResetZoom.Text = "reset";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(3, 544);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(54, 20);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom:";
            // 
            // numZoom
            // 
            this.numZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numZoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZoom.Location = new System.Drawing.Point(61, 542);
            this.numZoom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(54, 26);
            this.numZoom.TabIndex = 9;
            this.numZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numZoom.ValueChanged += new System.EventHandler(this.numZoom_ValueChanged);
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 0);
            this.panel2.TabIndex = 4;
            // 
            // paintBox
            // 
            this.paintBox.AutoSize = true;
            this.paintBox.BackColor = System.Drawing.SystemColors.Window;
            this.paintBox.Controls.Add(this.vScrollBarOffset);
            this.paintBox.Controls.Add(this.hScrollBarOffset);
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 33);
            this.paintBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.paintBox.MinimumSize = new System.Drawing.Size(960, 555);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1085, 571);
            this.paintBox.TabIndex = 0;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // vScrollBarOffset
            // 
            this.vScrollBarOffset.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBarOffset.LargeChange = 1;
            this.vScrollBarOffset.Location = new System.Drawing.Point(1059, 0);
            this.vScrollBarOffset.Maximum = 0;
            this.vScrollBarOffset.Name = "vScrollBarOffset";
            this.vScrollBarOffset.Size = new System.Drawing.Size(26, 571);
            this.vScrollBarOffset.TabIndex = 1;
            this.vScrollBarOffset.ValueChanged += new System.EventHandler(this.vScrollBarOffset_ValueChanged);
            // 
            // hScrollBarOffset
            // 
            this.hScrollBarOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarOffset.LargeChange = 1;
            this.hScrollBarOffset.Location = new System.Drawing.Point(118, 541);
            this.hScrollBarOffset.Maximum = 150;
            this.hScrollBarOffset.Minimum = 150;
            this.hScrollBarOffset.Name = "hScrollBarOffset";
            this.hScrollBarOffset.Size = new System.Drawing.Size(941, 30);
            this.hScrollBarOffset.TabIndex = 0;
            this.hScrollBarOffset.Value = 150;
            this.hScrollBarOffset.ValueChanged += new System.EventHandler(this.hScrollBarOffset_ValueChanged);
            // 
            // MainDrawForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1085, 604);
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
            this.paintBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintBox paintBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
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
        private System.Windows.Forms.HScrollBar hScrollBarOffset;
        private System.Windows.Forms.VScrollBar vScrollBarOffset;
    }
}

