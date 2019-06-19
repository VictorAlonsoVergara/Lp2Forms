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
    public partial class frmSupplier : Form
    {
        public bool flag = false;

        private List<String> listas = new List<String>();
        private List<String> listas2 = new List<String>();
        public frmSupplier()
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
            listas2.Add("Lima");
            listas2.Add("Quitor");
            cboCountry.DataSource = listas;
            cboCity.DataSource = listas2;
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;

        }


        private void reiniciar() {

            flag = false;
            btnDelete.Enabled = false;
            txtAddress.Clear();
            txtCode.Clear();
            txtName.Clear();
            txtRuc.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
     
            
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

 

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            txtCode.Clear();
   
            /* txtAddress.Clear();

             txtName.Clear();
             txtRuc.Clear();
             txtEmail.Clear();
             txtPhone.Clear();
             cboCity.SelectedIndex = -1;
             cboCountry.SelectedIndex = -1;*/
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtRuc.Text) || String.IsNullOrEmpty(txtAddress.Text) || 
                    String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPhone.Text) ||cboCountry.SelectedIndex ==-1|| cboCity.SelectedIndex == -1)
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

        private void CboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llenamos ciudades
        }
    }
}
