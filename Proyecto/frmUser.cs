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
    public partial class frmUser : Form
    {
        public bool flag = false;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        private List<AlmacenDisecWS.privilege> userTypes = Enum.GetValues(typeof(AlmacenDisecWS.privilege)).Cast<AlmacenDisecWS.privilege>().ToList();
        public frmUser()
        {
            InitializeComponent();
            txtCode.Enabled = false;
            btnDelete.Enabled = false;
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            cboPrivilege.DataSource = userTypes;
            cboPrivilege.SelectedIndex = -1;
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtLastName1.CharacterCasing = CharacterCasing.Upper;
            txtLastName2.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Upper;

          

        }


  
            private void reiniciar()
            {

                flag = true;
                btnDelete.Enabled = false;
                txtCode.Clear();
                txtName.Clear();
                txtLastName1.Clear();
                txtLastName2.Clear();
                txtEmail.Clear();
                txtDNI.Clear();
                txtSalary.Clear();
                txtPassword.Clear();
                rbMan.Checked = false;
                rbWoman.Checked = false;
                cboPrivilege.SelectedIndex = -1;
                txtPassword.Enabled = true;
                cboPrivilege.Enabled = true;


            }

        private void reiniciar2()
        {

            flag = false;
            btnDelete.Enabled = true;

            txtName.Clear();
            txtLastName1.Clear();
            txtLastName2.Clear();
            txtEmail.Clear();
            txtDNI.Clear();
            txtSalary.Clear();

            rbMan.Checked = false;
            rbWoman.Checked = false;

            txtPassword.Enabled = false;
            cboPrivilege.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (flag == true)
                {

                    reiniciar();
                }
                else {


                    reiniciar2();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flag == true)
            {



                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName1.Text) || String.IsNullOrEmpty(txtLastName2.Text) ||
                    String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtDNI.Text) || String.IsNullOrEmpty(txtSalary.Text) || String.IsNullOrEmpty(txtPassword.Text)
                  || cboPrivilege.SelectedIndex == -1 || (rbWoman.Checked == false && rbMan.Checked == false))
                {
                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();

                }
                else
                {
                    AlmacenDisecWS.employee emp = new AlmacenDisecWS.employee();

                    frmMessageBoxSave frm = new frmMessageBoxSave();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        string name = txtName.Text;
                        string apP = txtLastName1.Text;
                        string apM = txtLastName2.Text;
                        string DNI = txtDNI.Text;
                        string email = txtEmail.Text;
                        string pass = txtPassword.Text;
                        Double sueldo = Double.Parse(txtSalary.Text);

                        emp.employee_name = name;
                        emp.last_name = apP;
                        emp.second_last_name = apM;
                        emp.dni = DNI;
                        emp.email_employee = email;
                        emp.salary = sueldo;
                        emp.password = pass;
                        int a = 0;

                        if (cboPrivilege.SelectedValue.ToString() == "MANAGER")
                        {
                            a = 1;

                        }
                        else if (cboPrivilege.SelectedValue.ToString() == "STOREKEEPER")
                        {
                            a = 2;
                        }
                        else
                        {
                            a = 3;
                        }

                        if (rbMan.Checked == true)
                        {
                            emp.gender = "M";
                        }
                        else
                        {
                            emp.gender = "F";

                        }
                        int result = serviceDA.insertEmployee(emp, a);
                    }
                    frmSearchUser fm = Owner as frmSearchUser;
                    fm.dgvSearch.AutoGenerateColumns = false;
                    fm.dgvSearch.DataSource = serviceDA.queryAllEmployee();
         
                    this.Close();



                }


            }
            else
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName1.Text) || String.IsNullOrEmpty(txtLastName2.Text) ||
                   String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtDNI.Text) || String.IsNullOrEmpty(txtSalary.Text)
                || (rbWoman.Checked == false && rbMan.Checked == false))
                {

                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();


                }
                else
                {
                    
                    AlmacenDisecWS.employee emp = new AlmacenDisecWS.employee();

                    frmMessageBoxSave frm = new frmMessageBoxSave();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        string name = txtName.Text;
                        string apP = txtLastName1.Text;
                        string apM = txtLastName2.Text;
                        string DNI = txtDNI.Text;
                        string email = txtEmail.Text;

                        Double sueldo = Double.Parse(txtSalary.Text);
                        emp.employee_id = Int32.Parse(lblId.Text);
                        emp.employee_name = name;
                        emp.last_name = apP;
                        emp.second_last_name = apM;
                        emp.dni = DNI;
                        emp.salary = sueldo;
                        emp.email_employee = email;                  
                        if (rbMan.Checked == true)
                        {
                            emp.gender = "M";
                        }
                        else
                        {
                            emp.gender = "F";

                        }
                        int result = serviceDA.updateEmployee(emp);
                        

                    }




                }
                frmSearchUser fm = Owner as frmSearchUser;
                fm.dgvSearch.AutoGenerateColumns = false;
                fm.dgvSearch.DataSource = serviceDA.queryAllEmployee();

                this.Close();


            }


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();

            }
            else
            {
                frmMessageBoxDelete frm = new frmMessageBoxDelete();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    String cod = txtCode.Text;
                    serviceDA.deleteEmployee(cod);
                    frmSearchUser fm = Owner as frmSearchUser;
                    fm.dgvSearch.AutoGenerateColumns = false;
                    fm.dgvSearch.DataSource = serviceDA.queryAllEmployee();
        
                    this.Close();

                }


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMessageBoxBack frm = new frmMessageBoxBack();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                frmSearchUser fm = Owner as frmSearchUser;
                //fm.dgvSearch.AutoGenerateColumns = false;
                //fm.dgvSearch.DataSource = serviceDA.queryAllEmployee();
              

                this.Close();
            }
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                frmMessageBoxNumber frm = new frmMessageBoxNumber();
                frm.ShowDialog();
                e.Handled = true;
              //  return;
            }
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                frmMessageBoxNumber frm = new frmMessageBoxNumber();
                frm.ShowDialog();
                e.Handled = true;
               // return;
            }
        }
    }
    }



