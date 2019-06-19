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
    public partial class frmMaterial : Form
    {
        public int flag = 0;
        private List<String> listas = new List<String>();
        private List<String> listas2 = new List<String>();
        public frmMaterial()
        {
            InitializeComponent();
            //txtCode.Enabled = false;
            // Bitmap img = new Bitmap(Application.StartupPath+@"\img\fondo.jpg");
            // this.BackgroundImage = img;
            // this.BackgroundImageLayout = ImageLayout.Stretch;
            listas.Add("Perú");
            listas.Add("Ecuador");
            listas2.Add("Bolivia");
            listas2.Add("Colombia");
            cboBrand.DataSource = listas;
            cboCategory.DataSource = listas2;
            cboFamily.DataSource = listas;
            cboUnit.DataSource = listas;
            cboStatus.DataSource = listas;
            cboSupplier.DataSource = listas;
            cboMoney.DataSource = listas;


            cboBrand.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cboUnit.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboMoney.SelectedIndex = -1;
             txtCode.Enabled = false;
            btnDelete.Enabled = false;
            btnDataG.Enabled = false;
        }


        private void reiniciar()
        {

            flag = 0;
            btnDelete.Enabled = false;
      
            btnDataG.Enabled = true;

            cboBrand.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cboUnit.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboMoney.SelectedIndex = -1;
            txtCode.Clear();
            txtMinQuantity.Clear();
            txtPrice.Clear();
            txtSerie.Clear();
            txtName.Clear();

            cboCategory.Enabled = true;
            cboFamily.Enabled = true;
            cboBrand.Enabled = true;
            cboUnit.Enabled = true;
            cboSupplier.Enabled = true;
            cboMoney.Enabled = true;

            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtMinQuantity.Enabled = true;


        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            reiniciar();
        }




     

        private void BtnSave_Click(object sender, EventArgs e)
        {
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtMinQuantity.Text) || String.IsNullOrEmpty(txtSerie.Text) ||
                    String.IsNullOrEmpty(txtPrice.Text) || cboBrand.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 ||
                    cboFamily.SelectedIndex == -1 || cboUnit.SelectedIndex == -1 || cboStatus.SelectedIndex == -1 ||
                    cboSupplier.SelectedIndex == -1 || cboMoney.SelectedIndex == -1)
                {
                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();

                }
                else
                {


                    if (flag == 2)
                    {
                        if (String.IsNullOrEmpty(txtCode.Text))
                        {


                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                
                                String name = txtName.Text;
                            //Category cat = new category(name,1);
                            //Se llama al insert

                            frmMessageBoxAdd frm2 = new frmMessageBoxAdd();
                            if (frm2.ShowDialog() == DialogResult.OK) {
                                txtCode.Clear();
                                txtSerie.Clear();
                                cboStatus.SelectedIndex = -1;

                            }
                            else {
                                reiniciar();
                            }

                            }


                        }
                    }
                    else
                    {
                        if (flag == 0)
                        {

                            if (String.IsNullOrEmpty(txtCode.Text))
                            {

                                frmMessageBoxNew frm2 = new frmMessageBoxNew();
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
                        else {
                            if (flag == 1) {

                                frmMessageBoxDataGeneral frm2 = new frmMessageBoxDataGeneral();
                                frm2.ShowDialog();

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
    
        

       

        private void BtnDataG_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtMinQuantity.Text) || String.IsNullOrEmpty(txtPrice.Text)
                 || cboBrand.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 || cboFamily.SelectedIndex == -1
                 || cboUnit.SelectedIndex == -1 || cboSupplier.SelectedIndex == -1 || cboMoney.SelectedIndex == -1)
            {
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();

            }
            else
            {
                if (flag == 1)
                {
                    flag = 2;
        
                    btnDataG.Enabled = false;
                    txtName.Enabled = false;
                    txtMinQuantity.Enabled = false;
                    txtPrice.Enabled = false;

                    cboCategory.Enabled = false;
                    cboFamily.Enabled = false;
                    cboBrand.Enabled = false;
                    cboUnit.Enabled = false;
                    cboSupplier.Enabled = false;
                    cboMoney.Enabled = false;
                    //Si quieren guardar los datos generales antes aqui va el codigo

                }
                else {

                    frmMessageBoxNew frm = new frmMessageBoxNew();
                    frm.ShowDialog();

                }
                
            }
        }



        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                //Llenamos el cboFamily
            
        }
    }
}
