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
    public partial class F_CreateNewBitmap : Form
    {
        public F_CreateNewBitmap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            F_MainForm.diagRes.ready = false;
        }

        private void b_Ok_Click(object sender, EventArgs e)
        {
            F_MainForm.diagRes.width = Convert.ToInt32(nud_Width.Value);
            F_MainForm.diagRes.heidth = Convert.ToInt32(nud_Height.Value);
            F_MainForm.diagRes.ready = true;
            this.Close();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
