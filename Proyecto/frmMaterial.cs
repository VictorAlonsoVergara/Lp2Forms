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
       // private List<AlmacenDisecWS.currency> userTypes = Enum.GetValues(typeof(AlmacenDisecWS.currency)).Cast<AlmacenDisecWS.currency>().ToList();
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        public frmMaterial()
        {
            InitializeComponent();
            //txtCode.Enabled = false;
            // Bitmap img = new Bitmap(Application.StartupPath+@"\img\fondo.jpg");
            // this.BackgroundImage = img;
            // this.BackgroundImageLayout = ImageLayout.Stretch;
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            listas.Add("SOLES");
            listas.Add("DOLARES");

            cboBrand.DataSource = serviceDA.queryAllBrand();
            cboBrand.DisplayMember = "brand_name";
            cboBrand.ValueMember = "brand_id";



            cboUnit.DataSource = serviceDA.queryAllMeasurement_Unit();
            cboUnit.DisplayMember = "abbrevation_measure_unit";
            cboUnit.ValueMember = "id_measure_unit";
 

            cboMoney.DataSource = listas;

            cboCategory.DataSource = serviceDA.queryAllCategory();
            cboCategory.DisplayMember = "category_name";
            cboCategory.ValueMember = "category_id";

            cboSupplier.DataSource = serviceDA.queryAllSupplier();
            cboSupplier.DisplayMember = "supplier_name";
            cboSupplier.ValueMember = "id_supplier";

            cboBrand.DataSource = serviceDA.queryAllBrand();
            cboBrand.DisplayMember = "brand_name";
            cboBrand.ValueMember = "brand_id";

            cboBrand.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cboUnit.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboMoney.SelectedIndex = -1;
             txtCode.Enabled = false;
            btnDelete.Enabled = false;
            txtName.CharacterCasing = CharacterCasing.Upper;
           
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
            btnDataG.Enabled = true;

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
                                if (frm2.ShowDialog() == DialogResult.OK)
                                {
                                    int id_c = 0;
                                    AlmacenDisecWS.materialDetail detail = new AlmacenDisecWS.materialDetail();
                                    AlmacenDisecWS.material m = new AlmacenDisecWS.material();
                                    AlmacenDisecWS.category c = new AlmacenDisecWS.category();
                                    detail.measure = (AlmacenDisecWS.measureUnit)cboUnit.SelectedItem;
                                    detail.serie_material = txtSerie.Text;
                                    m.min_quantity = Int32.Parse(txtMinQuantity.Text);
                                    m.brand = (AlmacenDisecWS.brand)cboUnit.SelectedItem;
                                    m.family = (AlmacenDisecWS.family)cboFamily.SelectedItem;
                                    c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
                                    /// m.supplier = (AlmacenDisecWS.supplier)cbosupplier.SelectedItem
                                    m.price = Double.Parse(txtPrice.Text);
                                    m.name_item = txtName.Text;
                               //     m.material_details.  = detail;
                                
                                    if (cboMoney.SelectedItem.ToString() == "SOLES")
                                    {

                                        id_c = 1;

                                    }
                                    else
                                    {
                                        if (cboMoney.SelectedItem.ToString() == "DOLARES")
                                        {
                                            id_c = 2;
                                        }
                                    }

                                        m.family.category.category_id = c.category_id;
                                    m.family.category.category_name = c.category_name;

                                  //  int result = serviceDA.insertMaterial(m,id_c) ;
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
            btnDataG.Enabled = false;
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





        private void TxtMinQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                frmMessageBoxNumber frm = new frmMessageBoxNumber();
                frm.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                frmMessageBoxNumber frm = new frmMessageBoxNumber();
                frm.ShowDialog();
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    frmMessageBoxPoint frm = new frmMessageBoxPoint();
                    frm.ShowDialog();

                    e.Handled = true;
                }
            }
        }

        private void CboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
            cboFamily.DataSource = serviceDA.queryAllFamily(c.category_id);
            cboFamily.DisplayMember = "name_family";
            cboFamily.ValueMember = "id_family";
        }
    }
}
