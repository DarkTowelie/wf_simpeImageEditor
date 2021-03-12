
namespace WfApplication
{
    partial class F_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mb_ImageFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_OpenImageField = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_CloseImageField = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.sl_Tool = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_MainPanel = new System.Windows.Forms.Panel();
            this.gb_Brush = new System.Windows.Forms.GroupBox();
            this.l_BrushRadius = new System.Windows.Forms.Label();
            this.l_BrushColor = new System.Windows.Forms.Label();
            this.nud_BrushRadius = new System.Windows.Forms.NumericUpDown();
            this.p_Color = new System.Windows.Forms.Panel();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ms_MainMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.p_MainPanel.SuspendLayout();
            this.gb_Brush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_ImageFiles,
            this.видToolStripMenuItem});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(800, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "menuStrip1";
            // 
            // mb_ImageFiles
            // 
            this.mb_ImageFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_Load,
            this.mb_SaveAs,
            this.mb_CreateNew});
            this.mb_ImageFiles.Name = "mb_ImageFiles";
            this.mb_ImageFiles.Size = new System.Drawing.Size(48, 20);
            this.mb_ImageFiles.Text = "Файл";
            // 
            // mb_Load
            // 
            this.mb_Load.Name = "mb_Load";
            this.mb_Load.Size = new System.Drawing.Size(156, 22);
            this.mb_Load.Text = "Загрузить";
            this.mb_Load.Click += new System.EventHandler(this.mb_Load_Click);
            // 
            // mb_SaveAs
            // 
            this.mb_SaveAs.Name = "mb_SaveAs";
            this.mb_SaveAs.Size = new System.Drawing.Size(156, 22);
            this.mb_SaveAs.Text = "Сохранить как";
            this.mb_SaveAs.Click += new System.EventHandler(this.mb_SaveAs_Click);
            // 
            // mb_CreateNew
            // 
            this.mb_CreateNew.Name = "mb_CreateNew";
            this.mb_CreateNew.Size = new System.Drawing.Size(156, 22);
            this.mb_CreateNew.Text = "Создать новый";
            this.mb_CreateNew.Click += new System.EventHandler(this.mb_CreateNew_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_OpenImageField,
            this.mb_CloseImageField});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // mb_OpenImageField
            // 
            this.mb_OpenImageField.Name = "mb_OpenImageField";
            this.mb_OpenImageField.Size = new System.Drawing.Size(213, 22);
            this.mb_OpenImageField.Text = "Открыть окно рисования";
            this.mb_OpenImageField.Click += new System.EventHandler(this.mb_OpenImageField_Click);
            // 
            // mb_CloseImageField
            // 
            this.mb_CloseImageField.Name = "mb_CloseImageField";
            this.mb_CloseImageField.Size = new System.Drawing.Size(213, 22);
            this.mb_CloseImageField.Text = "Закрыть окно рисования";
            this.mb_CloseImageField.Click += new System.EventHandler(this.mb_CloseImageField_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl_Tool});
            this.StatusStrip.Location = new System.Drawing.Point(0, 463);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // sl_Tool
            // 
            this.sl_Tool.Name = "sl_Tool";
            this.sl_Tool.Size = new System.Drawing.Size(74, 17);
            this.sl_Tool.Text = "Инструмент";
            // 
            // p_MainPanel
            // 
            this.p_MainPanel.Controls.Add(this.gb_Brush);
            this.p_MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_MainPanel.Location = new System.Drawing.Point(0, 24);
            this.p_MainPanel.Name = "p_MainPanel";
            this.p_MainPanel.Size = new System.Drawing.Size(156, 439);
            this.p_MainPanel.TabIndex = 4;
            // 
            // gb_Brush
            // 
            this.gb_Brush.Controls.Add(this.l_BrushRadius);
            this.gb_Brush.Controls.Add(this.l_BrushColor);
            this.gb_Brush.Controls.Add(this.nud_BrushRadius);
            this.gb_Brush.Controls.Add(this.p_Color);
            this.gb_Brush.Location = new System.Drawing.Point(3, 14);
            this.gb_Brush.Name = "gb_Brush";
            this.gb_Brush.Size = new System.Drawing.Size(128, 123);
            this.gb_Brush.TabIndex = 6;
            this.gb_Brush.TabStop = false;
            this.gb_Brush.Text = "Кисть";
            // 
            // l_BrushRadius
            // 
            this.l_BrushRadius.AutoSize = true;
            this.l_BrushRadius.Location = new System.Drawing.Point(9, 81);
            this.l_BrushRadius.Name = "l_BrushRadius";
            this.l_BrushRadius.Size = new System.Drawing.Size(43, 13);
            this.l_BrushRadius.TabIndex = 7;
            this.l_BrushRadius.Text = "Радиус";
            // 
            // l_BrushColor
            // 
            this.l_BrushColor.AutoSize = true;
            this.l_BrushColor.Location = new System.Drawing.Point(9, 24);
            this.l_BrushColor.Name = "l_BrushColor";
            this.l_BrushColor.Size = new System.Drawing.Size(32, 13);
            this.l_BrushColor.TabIndex = 6;
            this.l_BrushColor.Text = "Цвет";
            // 
            // nud_BrushRadius
            // 
            this.nud_BrushRadius.Location = new System.Drawing.Point(6, 97);
            this.nud_BrushRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BrushRadius.Name = "nud_BrushRadius";
            this.nud_BrushRadius.Size = new System.Drawing.Size(70, 20);
            this.nud_BrushRadius.TabIndex = 6;
            this.nud_BrushRadius.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_BrushRadius.ValueChanged += new System.EventHandler(this.nud_BrushRadius_ValueChanged);
            // 
            // p_Color
            // 
            this.p_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_Color.Location = new System.Drawing.Point(6, 40);
            this.p_Color.Name = "p_Color";
            this.p_Color.Size = new System.Drawing.Size(70, 27);
            this.p_Color.TabIndex = 6;
            this.p_Color.Click += new System.EventHandler(this.p_Color_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openImageDialog";
            // 
            // F_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.p_MainPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ms_MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_MainMenu;
            this.MinimumSize = new System.Drawing.Size(816, 524);
            this.Name = "F_MainForm";
            this.Text = "Графический редактор";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.p_MainPanel.ResumeLayout(false);
            this.gb_Brush.ResumeLayout(false);
            this.gb_Brush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mb_ImageFiles;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Panel p_MainPanel;
        private System.Windows.Forms.ToolStripMenuItem mb_OpenImageField;
        private System.Windows.Forms.ToolStripMenuItem mb_CloseImageField;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ToolStripMenuItem mb_Load;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem mb_CreateNew;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.ToolStripStatusLabel sl_Tool;
        private System.Windows.Forms.Panel p_Color;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown nud_BrushRadius;
        private System.Windows.Forms.GroupBox gb_Brush;
        private System.Windows.Forms.Label l_BrushRadius;
        private System.Windows.Forms.Label l_BrushColor;
    }
}

