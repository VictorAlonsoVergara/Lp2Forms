
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
    public partial class frmSearchUser : Form
    {
      
        public frmSearchUser()
        {
            InitializeComponent();
            dgvSearch.Rows.Insert( 0,"Cod1" ,"Juan", "Perez", "Jimenez", "23562389", "Femenino", "a@mail.com","2555","1");
          
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
           
                frmUser frm = new frmUser();
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
                        frm.txtLastName1.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                        frm.txtLastName2.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
                        frm.txtDNI.Text = dgvSearch.CurrentRow.Cells[4].Value.ToString();
                    if (dgvSearch.CurrentRow.Cells[5].Value.ToString() == "Femenino")
                    {
                        frm.rbWoman.Checked = true;
                    }
                    else {
                        frm.rbMan.Checked = true;
                    }

                        frm.txtEmail.Text = dgvSearch.CurrentRow.Cells[6].Value.ToString();
                        frm.txtSalary.Text = dgvSearch.CurrentRow.Cells[7].Value.ToString();

                    //Los combo box se rellenan diferente asi no     
                    //frm.cboPrivilege.SelectedValue = dgvSearch.CurrentRow.Cells[8].Value.ToString();
                    frm.txtPassword.Enabled = false;

                        /*La contraseña no deberia mostrarse en el grip por lo de la seguridad para capturarla se saca desde la base de datos
                        Worker w = new worker();
                        w= busquedadeempleado(cod);
                        frm.txtPassword.text= w.getPassword();
                        Seria algo asi
                     
                     */
                       
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
            frmUser frm = new frmUser();
            frm.flag = true;
            OpenFormPanel(frm);
        }
    }
}
