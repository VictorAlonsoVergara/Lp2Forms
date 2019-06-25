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
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        public frmSupplier()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
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
           
            cboCountry.DataSource = serviceDA.queryAllCountry();
            cboCountry.DisplayMember = "name_country";
            cboCountry.ValueMember = "id_country";
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtAddress.CharacterCasing = CharacterCasing.Upper;
          

        }


        private void reiniciar() {

            flag = true;
            btnDelete.Enabled = false;
            txtAddress.Clear();
            txtCode.Clear();
            txtName.Clear();
            txtRuc.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            cboCountry.Enabled = true;
            cboCity.Enabled = true;


        }

        private void reiniciar2()
        {

            flag = false;
            btnDelete.Enabled = true;
            txtAddress.Clear();
            
            txtName.Clear();
            txtRuc.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            cboCountry.Enabled = false;
            cboCity.Enabled = false;


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


                if (flag == true)
                {

                    reiniciar();
                }
                else
                {


                    reiniciar2();

                }
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

            

                if (flag == true)
                {

                    if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtRuc.Text) || String.IsNullOrEmpty(txtAddress.Text) ||
                    String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPhone.Text) || cboCountry.SelectedIndex == -1 || cboCity.SelectedIndex == -1)
                    {
                        frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                        frm.ShowDialog();

                    }

                    else
                    {
                        frmMessageBoxSave frm = new frmMessageBoxSave();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            AlmacenDisecWS.supplier s = new AlmacenDisecWS.supplier();
                            AlmacenDisecWS.city ci = new AlmacenDisecWS.city();
                            AlmacenDisecWS.country co = new AlmacenDisecWS.country();
                            s.email = txtEmail.Text;
                            s.ruc = txtRuc.Text;
                            s.adress = txtAddress.Text;
                            s.phone_number = Int32.Parse(txtPhone.Text);
                            s.supplier_name = txtName.Text;
                            s.city = (AlmacenDisecWS.city)cboCity.SelectedItem;
                            s.city.country = (AlmacenDisecWS.country)cboCountry.SelectedItem;
                            int result = serviceDA.insertSupplier(s);


                            reiniciar();
                        frmSearchSupplier fm = Owner as frmSearchSupplier;
                        fm.dgvSearch.AutoGenerateColumns = false;
                        fm.dgvSearch.DataSource = "";

                        this.Close();
                    }
                    }

                }


                else
                {
                    if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtRuc.Text) || String.IsNullOrEmpty(txtAddress.Text) ||
                        String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPhone.Text))
                    {

                        frmMessageBoxFillNull frm2 = new frmMessageBoxFillNull();
                        frm2.ShowDialog();

                    }
                    else
                    {

                        frmMessageBoxSave frm = new frmMessageBoxSave();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        AlmacenDisecWS.supplier s = new AlmacenDisecWS.supplier();
                            //falta que le quiten el pais al actualizar
                        s.id_supplier = Int32.Parse(txtCode.Text);
                           s.email = txtEmail.Text;
                            s.ruc = txtRuc.Text;
                            s.adress = txtAddress.Text;
                            s.phone_number = Int32.Parse(txtPhone.Text);
                            s.supplier_name = txtName.Text;
         
                            int result = serviceDA.updateSupplier(s);

                            reiniciar();
                        frmSearchSupplier fm = Owner as frmSearchSupplier;
                        fm.txtSearch.Clear();
                        fm.dgvSearch.AutoGenerateColumns = false;
                        fm.dgvSearch.DataSource = "";

                        this.Close();
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
                    int id  = Int32.Parse(txtCode.Text);

                    //        s.city = (AlmacenDisecWS.city)cboCity.SelectedItem;
                    //        s.city.country = (AlmacenDisecWS.country)cboCountry.SelectedItem;
                    int result = serviceDA.deleteSupplier(id);
                    reiniciar();
                    frmSearchSupplier fm = Owner as frmSearchSupplier;
                    fm.dgvSearch.AutoGenerateColumns = false;
                    fm.dgvSearch.DataSource = "";
    
                    this.Close();
                }


            }
        }



    

            private void BtnBack_Click(object sender, EventArgs e)
        {
            frmMessageBoxBack frm = new frmMessageBoxBack();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                frmSearchSupplier fm = Owner as frmSearchSupplier;
          
               

                this.Close();
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                frmMessageBoxNumber frm = new frmMessageBoxNumber();
                frm.ShowDialog();
                e.Handled = true;
                //  return;
            }
        }

  

        private void CboCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AlmacenDisecWS.country c = new AlmacenDisecWS.country();
            c = (AlmacenDisecWS.country)cboCountry.SelectedItem;
            int a = c.id_country;
            cboCity.DataSource = serviceDA.queryAllCitybyId(c.id_country);

            //El nombre del  atributo a mostrar
            cboCity.DisplayMember = "name_city";
            cboCity.ValueMember = "id_city";
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    frmMessageBoxNumber frm = new frmMessageBoxNumber();
                    frm.ShowDialog();
                    e.Handled = true;
                    //  return;
                }
            
        }
    }
}
