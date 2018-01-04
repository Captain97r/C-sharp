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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUpLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDownLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnToolMoveFigure = new System.Windows.Forms.Button();
            this.btnToolSelection = new System.Windows.Forms.Button();
            this.btnToolRoundedRect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.btnToolZoom = new System.Windows.Forms.Button();
            this.btnToolHand = new System.Windows.Forms.Button();
            this.btnToolEllipse = new System.Windows.Forms.Button();
            this.btnToolRect = new System.Windows.Forms.Button();
            this.btnToolLine = new System.Windows.Forms.Button();
            this.btnToolPolyLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.fileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.paintBox = new Redactor_Vector_Graph.PaintBox();
            this.menuStrip.SuspendLayout();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripEdit,
            this.toolStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1085, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.ToolStripOpen,
            this.ToolStripSave,
            this.toolStripSaveAs,
            this.exportToolStripMenuItem,
            this.toolStripExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripNew
            // 
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(210, 30);
            this.toolStripNew.Text = "New";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(210, 30);
            this.ToolStripOpen.Text = "Open...";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(210, 30);
            this.ToolStripSave.Text = "Save";
            this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // toolStripSaveAs
            // 
            this.toolStripSaveAs.Name = "toolStripSaveAs";
            this.toolStripSaveAs.Size = new System.Drawing.Size(210, 30);
            this.toolStripSaveAs.Text = "Save as...";
            this.toolStripSaveAs.Click += new System.EventHandler(this.toolStripSaveAs_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(210, 30);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click_1);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDelSelected,
            this.toolStripUpLayer,
            this.toolStripDownLayer});
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(54, 29);
            this.toolStripEdit.Text = "Edit";
            // 
            // toolStripDelSelected
            // 
            this.toolStripDelSelected.Name = "toolStripDelSelected";
            this.toolStripDelSelected.Size = new System.Drawing.Size(217, 30);
            this.toolStripDelSelected.Text = "Delete Selected";
            this.toolStripDelSelected.Click += new System.EventHandler(this.toolStripDelSelected_Click);
            // 
            // toolStripUpLayer
            // 
            this.toolStripUpLayer.Name = "toolStripUpLayer";
            this.toolStripUpLayer.Size = new System.Drawing.Size(217, 30);
            this.toolStripUpLayer.Text = "Up Layer";
            this.toolStripUpLayer.Click += new System.EventHandler(this.toolStripUpLayer_Click);
            // 
            // toolStripDownLayer
            // 
            this.toolStripDownLayer.Name = "toolStripDownLayer";
            this.toolStripDownLayer.Size = new System.Drawing.Size(217, 30);
            this.toolStripDownLayer.Text = "Down Layer";
            this.toolStripDownLayer.Click += new System.EventHandler(this.toolStripDownLayer_Click);
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
            // toolPanel
            // 
            this.toolPanel.AutoSize = true;
            this.toolPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolPanel.Controls.Add(this.btnRedo);
            this.toolPanel.Controls.Add(this.btnUndo);
            this.toolPanel.Controls.Add(this.btnToolMoveFigure);
            this.toolPanel.Controls.Add(this.btnToolSelection);
            this.toolPanel.Controls.Add(this.btnToolRoundedRect);
            this.toolPanel.Controls.Add(this.panel1);
            this.toolPanel.Controls.Add(this.btnResetZoom);
            this.toolPanel.Controls.Add(this.lblZoom);
            this.toolPanel.Controls.Add(this.numZoom);
            this.toolPanel.Controls.Add(this.btnToolZoom);
            this.toolPanel.Controls.Add(this.btnToolHand);
            this.toolPanel.Controls.Add(this.btnToolEllipse);
            this.toolPanel.Controls.Add(this.btnToolRect);
            this.toolPanel.Controls.Add(this.btnToolLine);
            this.toolPanel.Controls.Add(this.btnToolPolyLine);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 33);
            this.toolPanel.MinimumSize = new System.Drawing.Size(110, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(126, 571);
            this.toolPanel.TabIndex = 0;
            // 
            // btnRedo
            // 
            this.btnRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRedo.Enabled = false;
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRedo.Location = new System.Drawing.Point(36, 512);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(30, 30);
            this.btnRedo.TabIndex = 17;
            this.btnRedo.Text = "↷";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUndo.Location = new System.Drawing.Point(2, 512);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(30, 30);
            this.btnUndo.TabIndex = 18;
            this.btnUndo.Text = "↶";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnToolMoveFigure
            // 
            this.btnToolMoveFigure.Image = global::Redactor_Vector_Graph.Properties.Resources.move;
            this.btnToolMoveFigure.Location = new System.Drawing.Point(7, 243);
            this.btnToolMoveFigure.Name = "btnToolMoveFigure";
            this.btnToolMoveFigure.Size = new System.Drawing.Size(54, 54);
            this.btnToolMoveFigure.TabIndex = 15;
            this.btnToolMoveFigure.UseVisualStyleBackColor = true;
            // 
            // btnToolSelection
            // 
            this.btnToolSelection.Image = global::Redactor_Vector_Graph.Properties.Resources.dashRect;
            this.btnToolSelection.Location = new System.Drawing.Point(67, 123);
            this.btnToolSelection.Name = "btnToolSelection";
            this.btnToolSelection.Size = new System.Drawing.Size(54, 54);
            this.btnToolSelection.TabIndex = 14;
            this.btnToolSelection.UseVisualStyleBackColor = true;
            // 
            // btnToolRoundedRect
            // 
            this.btnToolRoundedRect.Image = global::Redactor_Vector_Graph.Properties.Resources.RoundedRect;
            this.btnToolRoundedRect.Location = new System.Drawing.Point(7, 123);
            this.btnToolRoundedRect.Name = "btnToolRoundedRect";
            this.btnToolRoundedRect.Size = new System.Drawing.Size(54, 54);
            this.btnToolRoundedRect.TabIndex = 13;
            this.btnToolRoundedRect.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(6, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 205);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetZoom.Location = new System.Drawing.Point(67, 512);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(54, 30);
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
            this.numZoom.Location = new System.Drawing.Point(67, 542);
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
            // btnToolZoom
            // 
            this.btnToolZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnToolZoom.Image")));
            this.btnToolZoom.Location = new System.Drawing.Point(7, 183);
            this.btnToolZoom.Name = "btnToolZoom";
            this.btnToolZoom.Size = new System.Drawing.Size(54, 54);
            this.btnToolZoom.TabIndex = 8;
            this.btnToolZoom.UseVisualStyleBackColor = true;
            // 
            // btnToolHand
            // 
            this.btnToolHand.Image = global::Redactor_Vector_Graph.Properties.Resources.handImage;
            this.btnToolHand.Location = new System.Drawing.Point(67, 183);
            this.btnToolHand.Name = "btnToolHand";
            this.btnToolHand.Size = new System.Drawing.Size(54, 54);
            this.btnToolHand.TabIndex = 7;
            this.btnToolHand.UseVisualStyleBackColor = true;
            // 
            // btnToolEllipse
            // 
            this.btnToolEllipse.Image = global::Redactor_Vector_Graph.Properties.Resources.CircleImage;
            this.btnToolEllipse.Location = new System.Drawing.Point(7, 63);
            this.btnToolEllipse.Name = "btnToolEllipse";
            this.btnToolEllipse.Size = new System.Drawing.Size(54, 54);
            this.btnToolEllipse.TabIndex = 6;
            this.btnToolEllipse.UseVisualStyleBackColor = true;
            // 
            // btnToolRect
            // 
            this.btnToolRect.Image = global::Redactor_Vector_Graph.Properties.Resources.RectImage;
            this.btnToolRect.Location = new System.Drawing.Point(67, 63);
            this.btnToolRect.Name = "btnToolRect";
            this.btnToolRect.Size = new System.Drawing.Size(54, 54);
            this.btnToolRect.TabIndex = 5;
            this.btnToolRect.UseVisualStyleBackColor = true;
            // 
            // btnToolLine
            // 
            this.btnToolLine.Image = global::Redactor_Vector_Graph.Properties.Resources.LineImage;
            this.btnToolLine.Location = new System.Drawing.Point(67, 3);
            this.btnToolLine.Name = "btnToolLine";
            this.btnToolLine.Size = new System.Drawing.Size(54, 54);
            this.btnToolLine.TabIndex = 4;
            this.btnToolLine.UseVisualStyleBackColor = true;
            // 
            // btnToolPolyLine
            // 
            this.btnToolPolyLine.Image = global::Redactor_Vector_Graph.Properties.Resources.PolyLineImage;
            this.btnToolPolyLine.Location = new System.Drawing.Point(7, 3);
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
            // fileDialogOpen
            // 
            this.fileDialogOpen.Filter = "Project File(.svp)|*.svp";
            this.fileDialogOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialogOpen_FileOk);
            // 
            // fileDialogSave
            // 
            this.fileDialogSave.DefaultExt = "json";
            this.fileDialogSave.FileName = "new.svp";
            this.fileDialogSave.Filter = "Project File(.svp)|*.svp";
            this.fileDialogSave.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialogSave_FileOk);
            // 
            // fileDialogExport
            // 
            this.fileDialogExport.Filter = "Vector(*.svg)|*.svg|Raster graphics(*.png)|*.png";
            this.fileDialogExport.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialogExport_FileOk);
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
            this.paintBox.Size = new System.Drawing.Size(1085, 571);
            this.paintBox.TabIndex = 0;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDrawForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Draw_Form_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintBox paintBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelSelected;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToolEllipse;
        private System.Windows.Forms.Button btnToolRect;
        private System.Windows.Forms.Button btnToolLine;
        private System.Windows.Forms.Button btnToolPolyLine;
        private System.Windows.Forms.Button btnToolZoom;
        private System.Windows.Forms.Button btnToolHand;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToolRoundedRect;
        private System.Windows.Forms.Button btnToolSelection;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripUpLayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripDownLayer;
        private System.Windows.Forms.Button btnToolMoveFigure;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
        private System.Windows.Forms.OpenFileDialog fileDialogOpen;
        private System.Windows.Forms.SaveFileDialog fileDialogSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripNew;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.SaveFileDialog fileDialogExport;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

