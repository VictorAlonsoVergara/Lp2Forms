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

        private List<String> listas = new List<String>();
        private List<String> listas2 = new List<String>();
        public frmUser()
        {
            InitializeComponent();
            //txtCode.Enabled = false;
            // Bitmap img = new Bitmap(Application.StartupPath+@"\img\fondo.jpg");
            // this.BackgroundImage = img;
            // this.BackgroundImageLayout = ImageLayout.Stretch;
            txtCode.Enabled = false;
            btnDelete.Enabled = false;
            listas.Add("Perú");
            listas.Add("Ecuador");
          
            cboPrivilege.DataSource = listas;
            cboPrivilege.SelectedIndex = -1;


        }


        private void reiniciar() {

            flag = false;
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
         
     
            
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                
                reiniciar();
            }
          
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {

            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName1.Text) || String.IsNullOrEmpty(txtLastName2.Text) || 
                    String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtDNI.Text) || String.IsNullOrEmpty(txtSalary.Text) 
                  || cboPrivilege.SelectedIndex == -1 || (rbWoman.Checked==false && rbMan.Checked == false))
                {
                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();

                }
                else
                {


                    if (flag == true)
                    {
                        if (String.IsNullOrEmpty(txtCode.Text))
                        {

                           
                                frmMessageBoxSave frm = new frmMessageBoxSave();
                                if (frm.ShowDialog() == DialogResult.OK)
                                {

                                    String name = txtName.Text;
                                    //Category cat = new category(name,1);
                                    //Se llama al insert
                                    reiniciar();
                                }
                            

                        }
                        else
                        {

                            frmMessageBoxDataGeneral frm2 = new frmMessageBoxDataGeneral();
                            frm2.ShowDialog();

                        }

                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txtCode.Text))
                        {

                            frmMessageBoxFillNull frm2 = new frmMessageBoxFillNull();
                            frm2.ShowDialog();

                        }
                        else
                        {

                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {

                              //  int id = Int32.Parse(txtId.Text);
                                String name = txtName.Text;
                                //  Category cat = (Category)cboCategory.SelectedIndex;
                                //Category cat = new category(name,0);
                                //Se llama al update
                                reiniciar();
                            }
                        }

                    }
                }




            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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
                 //   int id = Int32.Parse(txtId.Text);
                    String name = txtName.Text;
                    ////Category cat = new category(name,0);
                    //Se llama al delete 
                    reiniciar();
                }


            }
        }

     
    }
}
