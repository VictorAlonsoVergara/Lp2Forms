
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
    public partial class frmSearchSupplier : Form
    {
        private String nombreTextoAnterior = null;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;

        public frmSearchSupplier()
        {
            InitializeComponent();
            //dgvSearch.Rows.Insert(0, "Cod1", "Maestro", "8899889898", "Av.  Brasil", "Lima", "Perú", "4532345","a@mail.com");
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();

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

        private void BtnModify_Click(object sender, EventArgs e)
        {
           
                frmSupplier frm = new frmSupplier();
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
                        frm.txtCode.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                        frm.txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        frm.txtRuc.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                        frm.txtAddress.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
                        //Los combo box se rellenan diferente asi no   
                        //frm.cboCity.SelectedValue = dgvSearch.CurrentRow.Cells[4].Value.ToString();
                        //frm.cboCountry.SelectedValue = dgvSearch.CurrentRow.Cells[5].Value.ToString();
                        frm.txtPhone.Text = dgvSearch.CurrentRow.Cells[6].Value.ToString();
                        frm.txtEmail.Text = dgvSearch.CurrentRow.Cells[7].Value.ToString();
                        
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
            frmSupplier frm = new frmSupplier();
            frm.flag = true;
            OpenFormPanel(frm);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllSupplier();

            }
            else
            {
                String name = txtSearch.Text;

                //Insertar el codigo de busqueda por nombre

            }
        }
    }
}
