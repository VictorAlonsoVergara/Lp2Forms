using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenDisecForms
{
    public partial class frmMessageBoxCancel : Form
    {
        public frmMessageBoxCancel()
        {
            InitializeComponent();
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
