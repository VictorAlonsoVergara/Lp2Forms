
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
        private AlmacenDisecWS.DBControllerWSClient serviceDA;

     
           
            public frmSearchUser()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            btnModify.Enabled = false;
            txtSearch.CharacterCasing = CharacterCasing.Upper;


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
            frmUser frm = new frmUser();
            frm.flag = false;

            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.cboPrivilege.Enabled = false;

            String cod = dgvSearch.CurrentRow.Cells[0].Value.ToString();
            AlmacenDisecWS.employee emp = new AlmacenDisecWS.employee();
            emp = serviceDA.EmployeeByCode(cod);

            frm.lblId.Text = emp.employee_id.ToString();
            frm.txtCode.Text = emp.eployee_code;
            frm.txtName.Text = emp.employee_name;
            frm.txtLastName1.Text = emp.last_name;
            frm.txtLastName2.Text = emp.second_last_name;
            frm.txtEmail.Text = emp.email_employee;
            frm.txtDNI.Text = emp.dni;
            frm.txtPassword.Enabled = false;
            frm.txtSalary.Text = emp.salary.ToString();
            frm.cboPrivilege.Text= dgvSearch.CurrentRow.Cells[8].Value.ToString();
            frm.btnDelete.Enabled = true;
            if (emp.gender == "F")
            {

                frm.rbWoman.Checked = true;

            }
            else {

                frm.rbMan.Checked = true;
            }


            frm.BringToFront();
            frm.Show();           
          


        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.flag = true;

            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();



        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllEmployee();
               

            }
            else
            {
                String name = txtSearch.Text;

                //Insertar el codigo de busqueda por nombre

            }
            btnModify.Enabled = true;
        }
    }
}
