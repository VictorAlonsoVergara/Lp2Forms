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
    public partial class frmTool : Form
    {
        public int flag = 0;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        private List<AlmacenDisecWS.currency> userTypes = Enum.GetValues(typeof(AlmacenDisecWS.currency)).Cast<AlmacenDisecWS.currency>().ToList();
        private List<String> listWayToPay = new List<String>();

        public frmTool()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();

            listWayToPay.Add("CRÉDITO");
            listWayToPay.Add("CONTADO");

            cboWayofPay.DataSource = listWayToPay;
            cboWayofPay.SelectedIndex = -1;

            cboBrand.DataSource = serviceDA.queryAllBrand();
            cboBrand.DisplayMember = "brand_name";
            cboBrand.ValueMember = "brand_id";


            cboCategory.DataSource = serviceDA.queryAllCategory();
            cboCategory.DisplayMember = "category_name";
            cboCategory.ValueMember = "category_id";

            //AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
            //cboFamily.DisplayMember = "name_family";
            //cboFamily.ValueMember = "id_family";
            //cboFamily.DataSource = serviceDA.queryAllFamily(c.category_id);
            //cboFamily.SelectedValue = -1;

            cboSupplier.DataSource = serviceDA.queryAllSupplier();
            cboSupplier.DisplayMember = "supplier_name";
            cboSupplier.ValueMember = "id_supplier";

            cboStorehouse.DataSource = serviceDA.queryAllStorehouse();
            cboStorehouse.DisplayMember = "storehouse_name";
            cboStorehouse.ValueMember = "id_storehouse";


            cboMoney.DataSource = userTypes;

            txtCode.Enabled = false;
            txtId.Enabled = false;
            btnDelete.Enabled = false;
            btnDataG.Enabled = true;
            btnCancel.Enabled = true;

            cboBrand.SelectedValue = -1;
            cboCategory.SelectedValue = -1;
            cboSupplier.SelectedValue = -1;
            cboFamily.SelectedValue = -1;
            cboStorehouse.SelectedValue = -1;
            cboMoney.SelectedIndex = -1;

            txtName.CharacterCasing = CharacterCasing.Upper;
        }


        private void reiniciar()
        {
            flag = 0;
            btnDelete.Enabled = false;            
            btnDataG.Enabled = true;
            cboCategory.SelectedIndex = -1;
            cboBrand.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cboMoney.SelectedIndex = -1;
            
            txtCode.Clear();          
            txtPrice.Clear();
            txtSerie.Clear();
            txtName.Clear();

            cboCategory.Enabled = true;
            cboFamily.Enabled = true;
            cboBrand.Enabled = true;        
            cboSupplier.Enabled = true;
            cboMoney.Enabled = true;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(flag == 0)
                reiniciar();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSerie.Text) || String.IsNullOrEmpty(txtPrice.Text) 
                    || cboBrand.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 ||  cboFamily.SelectedIndex == -1  
                    || cboSupplier.SelectedIndex == -1 || cboMoney.SelectedIndex == -1)
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
                                //cboStatus.SelectedIndex = -1;

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
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPrice.Text) || cboBrand.SelectedIndex == -1 || 
                cboCategory.SelectedIndex == -1 || cboFamily.SelectedIndex == -1 || cboSupplier.SelectedIndex == -1
                || cboMoney.SelectedIndex == -1)
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
                    txtPrice.Enabled = false;

                    cboCategory.Enabled = false;
                    cboFamily.Enabled = false;
                    cboBrand.Enabled = false;
       
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

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
            cboFamily.DataSource = serviceDA.queryAllFamily(c.category_id);
            cboFamily.DisplayMember = "name_family";
            cboFamily.ValueMember = "id_family";
        }
    }
}
