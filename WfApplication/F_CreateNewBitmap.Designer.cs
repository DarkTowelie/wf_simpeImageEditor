
namespace WfApplication
{
    partial class F_CreateNewBitmap
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
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.l_Width = new System.Windows.Forms.Label();
            this.l_Height = new System.Windows.Forms.Label();
            this.b_Ok = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(22, 49);
            this.nud_Width.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(120, 20);
            this.nud_Width.TabIndex = 0;
            this.nud_Width.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(199, 49);
            this.nud_Height.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nud_Height.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(120, 20);
            this.nud_Height.TabIndex = 1;
            this.nud_Height.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // l_Width
            // 
            this.l_Width.AutoSize = true;
            this.l_Width.Location = new System.Drawing.Point(57, 33);
            this.l_Width.Name = "l_Width";
            this.l_Width.Size = new System.Drawing.Size(46, 13);
            this.l_Width.TabIndex = 2;
            this.l_Width.Text = "Ширина";
            // 
            // l_Height
            // 
            this.l_Height.AutoSize = true;
            this.l_Height.Location = new System.Drawing.Point(235, 33);
            this.l_Height.Name = "l_Height";
            this.l_Height.Size = new System.Drawing.Size(45, 13);
            this.l_Height.TabIndex = 3;
            this.l_Height.Text = "Высота";
            // 
            // b_Ok
            // 
            this.b_Ok.Location = new System.Drawing.Point(82, 91);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(75, 23);
            this.b_Ok.TabIndex = 4;
            this.b_Ok.Text = "OK";
            this.b_Ok.UseVisualStyleBackColor = true;
            this.b_Ok.Click += new System.EventHandler(this.b_Ok_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(177, 91);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 5;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // F_CreateNewBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 126);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Ok);
            this.Controls.Add(this.l_Height);
            this.Controls.Add(this.l_Width);
            this.Controls.Add(this.nud_Height);
            this.Controls.Add(this.nud_Width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CreateNewBitmap";
            this.Text = "F_CreateNewBitmap";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.Label l_Width;
        private System.Windows.Forms.Label l_Height;
        private System.Windows.Forms.Button b_Ok;
        private System.Windows.Forms.Button b_Cancel;
    }
}