
namespace WfApplication
{
    partial class F_Image
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tb_ImageY = new System.Windows.Forms.TextBox();
            this.tb_ImageX = new System.Windows.Forms.TextBox();
            this.p_Image = new System.Windows.Forms.Panel();
            this.l_X = new System.Windows.Forms.Label();
            this.l_Y = new System.Windows.Forms.Label();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.p_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(411, 392);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // tb_ImageY
            // 
            this.tb_ImageY.Location = new System.Drawing.Point(12, 130);
            this.tb_ImageY.Name = "tb_ImageY";
            this.tb_ImageY.Size = new System.Drawing.Size(100, 20);
            this.tb_ImageY.TabIndex = 1;
            this.tb_ImageY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ImageX
            // 
            this.tb_ImageX.Location = new System.Drawing.Point(12, 62);
            this.tb_ImageX.Name = "tb_ImageX";
            this.tb_ImageX.Size = new System.Drawing.Size(100, 20);
            this.tb_ImageX.TabIndex = 2;
            this.tb_ImageX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_Image
            // 
            this.p_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Image.Controls.Add(this.pictureBox);
            this.p_Image.Location = new System.Drawing.Point(122, 12);
            this.p_Image.Name = "p_Image";
            this.p_Image.Size = new System.Drawing.Size(411, 392);
            this.p_Image.TabIndex = 3;
            // 
            // l_X
            // 
            this.l_X.AutoSize = true;
            this.l_X.Location = new System.Drawing.Point(56, 46);
            this.l_X.Name = "l_X";
            this.l_X.Size = new System.Drawing.Size(14, 13);
            this.l_X.TabIndex = 1;
            this.l_X.Text = "X";
            // 
            // l_Y
            // 
            this.l_Y.AutoSize = true;
            this.l_Y.Location = new System.Drawing.Point(56, 114);
            this.l_Y.Name = "l_Y";
            this.l_Y.Size = new System.Drawing.Size(14, 13);
            this.l_Y.TabIndex = 4;
            this.l_Y.Text = "Y";
            // 
            // drawTimer
            // 
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // F_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 427);
            this.Controls.Add(this.l_Y);
            this.Controls.Add(this.l_X);
            this.Controls.Add(this.p_Image);
            this.Controls.Add(this.tb_ImageX);
            this.Controls.Add(this.tb_ImageY);
            this.Name = "F_Image";
            this.Text = "Холст";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Image_FormClosed);
            this.Shown += new System.EventHandler(this.F_Image_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_Image_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.p_Image.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tb_ImageY;
        private System.Windows.Forms.TextBox tb_ImageX;
        private System.Windows.Forms.Panel p_Image;
        private System.Windows.Forms.Label l_X;
        private System.Windows.Forms.Label l_Y;
        private System.Windows.Forms.Timer drawTimer;
    }
}