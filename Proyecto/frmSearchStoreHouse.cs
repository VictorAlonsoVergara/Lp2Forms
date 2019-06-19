
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
    public partial class frmSearchStoreHouse : Form
    {
      
        public frmSearchStoreHouse()
        {
            InitializeComponent();
            dgvSearch.Rows.Insert(0, "Cod1", "Brasil", "Av.  Brasil", "Lima",  "4532345");
          
        }

        private void OpenFormPanel(object formHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }




       

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {

            frmStoreHouse frm = new frmStoreHouse();
                if (dgvSearch.SelectedRows.Count > 0)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value == null)
                    {

                        frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                        frm3.ShowDialog();
                    }
                    else
                    {
                        frm.flag = false;
              
                        frm.btnDelete.Enabled = true;
                        frm.txtId.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                        frm.txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        
                        frm.txtAddress.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    //Los combo box se rellenan diferente asi no         
                    //frm.cboCity.SelectedValue = dgvSearch.CurrentRow.Cells[3].Value.ToString();

                    frm.txtPhone.Text = dgvSearch.CurrentRow.Cells[4].Value.ToString();
    
                        
                        OpenFormPanel(frm);
                    }

                }
                else
                {
                    frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                    frm2.ShowDialog();
                }
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmStoreHouse frm = new frmStoreHouse();
            frm.flag = true;
            OpenFormPanel(frm);
        }
    }
}
