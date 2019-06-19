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
    public partial class frmSearchInventoryMaterial : Form
    {
        public frmSearchInventoryMaterial()
        {
            InitializeComponent();
            btnAddMaterial.Visible = false;
            dgvSearch.Rows.Insert(0, "Tornillo", "Maestro", "20", "cajas");
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                if (dgvSearch.CurrentRow.Cells[0].Value == null)
                {

                    frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                    frm3.ShowDialog();
                }
                else
                {
                    frmWorkOrder fm = Owner as frmWorkOrder;
                    //se rellena el grip con magia :v

                    this.Close();
                }

            }
            else
            {
                frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                frm2.ShowDialog();
            }

        
    }
    }
}
