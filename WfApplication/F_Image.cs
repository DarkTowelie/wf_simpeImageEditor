using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfApplication
{
    public partial class F_Image : Form
    {
        Point currentPoint;
        public F_Image()
        {
            InitializeComponent();
            drawTimer.Interval = 1;
        }

        private void F_Image_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Image_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image = F_MainForm.imageEditor.Image;
        }

        public void savePbImage(string filePath)
        {
            try
            {
                pictureBox.Image.Save(filePath, getFormat(filePath));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public System.Drawing.Imaging.ImageFormat getFormat (string filePath)
        {
            string extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case (".jpg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("jpeg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case (".png"):
                    return System.Drawing.Imaging.ImageFormat.Png;
                default:
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }
        private void F_Image_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_MainForm.ImageFieldOpened = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = F_MainForm.imageEditor.ConvertCoordinates(pictureBox, e.X, e.Y);
            tb_ImageX.Text = Convert.ToString(currentPoint.X);
            tb_ImageY.Text = Convert.ToString(currentPoint.Y);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
           
            drawTimer.Start();
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawTimer.Stop();
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            int brushRadius = F_MainForm.imageEditor.BrushRadius;
            for (int i = currentPoint.X - brushRadius; i <= currentPoint.X + brushRadius; i++)
            {
                for (int j = currentPoint.Y - brushRadius; j <= currentPoint.Y + brushRadius; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - currentPoint.X, 2) + Math.Pow( j - currentPoint.Y, 2));
                    if (dist <= brushRadius && i >= 0 && j>=0 
                        && i < F_MainForm.imageEditor.Image.Width 
                        && j < F_MainForm.imageEditor.Image.Height)

                        F_MainForm.imageEditor.Image.SetPixel(i, j, F_MainForm.imageEditor.BrushColor);
                }
            }
            
            Invalidate();
        }
    }
}
