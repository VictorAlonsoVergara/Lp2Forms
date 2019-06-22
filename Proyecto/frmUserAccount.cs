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
   
    public partial class frmUserAccount : Form
    {
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        public frmUserAccount()
        {
            InitializeComponent();
        }


        private void reiniciar()
        {

        
            
           
            txtName.Clear();
            txtLastName1.Clear();
            txtLastName2.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
                  
         



        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName1.Text) || String.IsNullOrEmpty(txtLastName2.Text) ||
                  String.IsNullOrEmpty(txtEmail.Text))
            {
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();

            }
            else
            {
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    //Metodo de actulizar datos
                }

                else
                { //Metodo de actualizar datos con contraseña
                    serviceDA.ChangePassword("ADM001",txtPassword.Text);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {


                reiniciar();
            }
        }

      
    }
}
