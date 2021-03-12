using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfApplication
{

    public struct CrNewDialogRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }

    public partial class F_MainForm : Form
    {
        F_Image imageField = null;
        public static bool ImageFieldOpened = false;

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();
        public F_MainForm()
        {
            InitializeComponent();

            p_Color.BackColor = Color.White;
            CreateField();
            openImageDialog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
            saveImageDialog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
        }
/*----------------------------------------------------------------------------------*/
        private void mb_Load_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openImageDialog.FileName;
                imageEditor.LoadImage(filePath);
                imageField.Refresh();
            }
        }

        private void mb_SaveAs_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveImageDialog.FileName;
                imageField.savePbImage(saveImageDialog.FileName);
            }
        }

        private void mb_CloseImageField_Click(object sender, EventArgs e)
        {
            if (ImageFieldOpened)
            {
                imageField.Close();
                ImageFieldOpened = false;
            }
        }

        private void mb_OpenImageField_Click(object sender, EventArgs e)
        {
            if (!ImageFieldOpened)
            {
                CreateField();
            }
        }

        private void mb_CreateNew_Click(object sender, EventArgs e)
        {
            F_CreateNewBitmap createNewBitmap = new F_CreateNewBitmap();
            createNewBitmap.ShowDialog();
            if (diagRes.ready)
            {
                imageEditor = new ImageEditor(diagRes.width, diagRes.heidth);
                imageField.Refresh();
                p_Color.BackColor = Color.White;
                nud_BrushRadius.Value = 30;
            }
        }
/*----------------------------------------------------------------------------------*/
        public void CreateField()
        {
            imageField = new F_Image();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void p_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_Color.BackColor = colorDialog.Color;
                imageEditor.SetBrushColor(colorDialog.Color);
            }
        }

        private void nud_BrushRadius_ValueChanged(object sender, EventArgs e)
        {
                imageEditor.SetBrushRadius(Convert.ToInt32(nud_BrushRadius.Value));
        }
    }
}
