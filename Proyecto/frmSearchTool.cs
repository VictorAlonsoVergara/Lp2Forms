
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
    public partial class frmSearchTool : Form
    {
        private BindingList<Tool> list = new BindingList<Tool>();
        private BindingList<AlmacenDisecWS.toolDetail> listDetails = new BindingList<AlmacenDisecWS.toolDetail>();
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        
        public frmSearchTool()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            txtSearch.Enabled = true;
            
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
        /*
        private void BtnAddMaterial_Click(object sender, EventArgs e)
        { 
            frmTool frm = new frmTool();
                if (dgvSearch.SelectedRows.Count > 0)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value == null)
                    {

                        frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                        frm3.ShowDialog();
                    }
                    else
                    {                    
                        frm.flag = 2;
                        frm.cboFamily.Enabled = false;
                        frm.cboBrand.Enabled = false;
                        frm.cboSupplier.Enabled = false;
                        frm.cboMoney.Enabled = false;
                        frm.txtName.Enabled = false;
                        frm.txtPrice.Enabled = false;
                        OpenFormPanel(frm);                    
                    }
                }
                else
                {
                frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                frm2.ShowDialog();
                }

            }*/

        private void BtnModify_Click(object sender, EventArgs e)
        {
            /*
            frmTool frm = new frmTool();
            frm.flag = 0;
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.cboFamily.Enabled = true;
            frm.cboBrand.Enabled = true;
            frm.cboSupplier.Enabled = true;

            //String name = cmbSearch.Text;
            AlmacenDisecWS.tool tool = new AlmacenDisecWS.tool();
            tool = serviceDA.queryToolByName(name);
            frm.txtName.Text = tool.name_item;
            frm.txtPrice.Text = tool.price.ToString();
            frm.cboBrand.Text = tool.brand.brand_name;
            frm.cboFamily.Text = tool.family.name_family;
            frm.cboMoney.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
            /*
            frm.txtCode.Text = tool..ToString();
            frm.txtNameStorehouse.Text = store.storehouse_name;
            frm.txtAddressStorehouse.Text = store.address;
            frm.txtPhone.Text = store.phone_number.ToString();
            frm.txtId.Enabled = false;
            frm.cboCity.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
            frm.btnDelete.Enabled = true;
            btnModify.Enabled = true;
            frm.BringToFront();
            frm.Show();
            /*
            frmMaterial frm = new frmMaterial();
                if (dgvSearch.SelectedRows.Count > 0)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value == null)
                    {

                    frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                    frm3.ShowDialog();
                    }
                    else
                    {
                        frm.flag = 0;
                    
                         frm.btnDelete.Enabled = true;
                        //Llenamos todos los datos falta ver como capturarlos


                        OpenFormPanel(frm);
                    }

                }
                else
                {
                frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                frm2.ShowDialog();
                }*/

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {            
            frmTool frm = new frmTool();

            frm.cboCategory.Enabled = true;
            frm.cboFamily.Enabled = true;
            frm.cboBrand.Enabled = true;
            frm.cboStorehouse.Enabled = true;
            frm.cboSupplier.Enabled = true;
            frm.cboMoney.Enabled = true;
            frm.cboWayofPay.Enabled = true;
            frm.txtName.Enabled = true;
            frm.txtPrice.Enabled = true;

            frm.txtCode.Enabled = false;
            frm.txtSerie.Enabled = false;
            frm.txtId.Enabled = false;

            frm.flag = 1;
            OpenFormPanel(frm);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                list.Clear();
                listDetails.Clear();
                int cont = 0;
                AlmacenDisecWS.tool[] a = new AlmacenDisecWS.tool[200];
                a  = serviceDA.queryAllTool();
                cont = a.Count();
                for (int i = 0; i < cont; i++)
                {
                    Tool s = new Tool();
                    s.id_item = a[i].id_item;
                    s.name_item = a[i].name_item;
                    s.price = a[i].price;
                    s.brand.brand_name = a[i].brand.brand_name;
                    list.Add(s);
                }

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = list;
                /*
                if (s.tool_details != null)
                {
                    cont = s.tool_details.Count();
                    for (int i = 0; i < cont; i++)
                    {
                        AlmacenDisecWS.toolDetail t = new AlmacenDisecWS.toolDetail();
                        t.code_tool = s.tool_details[i].code_tool;
                        t.serie_tool = s.tool_details[i].serie_tool;
                        t.detail_tool = s.tool_details[i].detail_tool;
                        t.tool_state = s.tool_details[i].tool_state;
                        listDetails.Add(t);
                    }

                    dgvSearch.AutoGenerateColumns = false;
                    dgvSearch.DataSource = listDetails;
                    btnModify.Enabled = true;
                }*/


                /*
                a = serviceDA.queryAllTool();
                cont = a.Count();
                for (int i = 0; i < cont; i++)
                {
                    Tool s = new Tool();
                    s.id_tool = a[i].id_tool;
                    s.name_item = a[i].name_item;
                    s.price = a[i].price;
                    s.brand = a[i].brand;
                    s.tool_details = a[i].tool_details;
                    if (s.tool_details != null)
                    {
                        int b = s.tool_details.Length;
                        for (int j = 0; j < b; j++)
                        {
                            AlmacenDisecWS.toolDetail t = new AlmacenDisecWS.toolDetail();
                            t.code_tool = s.tool_details[j].code_tool;
                            t.serie_tool = s.tool_details[j].serie_tool;
                            t.detail_tool = s.tool_details[j].detail_tool;
                            t.tool_state = s.tool_details[j].tool_state;
                            listDetails.Add(t);
                        }
                    }

                    list.Add(s);
                }
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = listDetails;
                */
            }
            else
            {


            }
        }

        private void BtnAddTool_Click(object sender, EventArgs e)
        {
            frmTool frm = new frmTool();
            if (dgvSearch.SelectedRows.Count > 0)
            {
                if (dgvSearch.CurrentRow.Cells[0].Value == null)
                {
                    frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                    frm3.ShowDialog();
                }
                else
                {
                    frm.flag = 2;
                    frm.cboCategory.Enabled = false;
                    frm.cboFamily.Enabled = false;
                    frm.cboBrand.Enabled = false;
                    frm.cboStorehouse.Enabled = false;
                    frm.cboSupplier.Enabled = false;
                    frm.cboMoney.Enabled = false;
                    frm.cboWayofPay.Enabled = false;
                    frm.txtName.Enabled = false;
                    frm.txtPrice.Enabled = false;
                    frm.txtCode.Enabled = true;
                    frm.txtSerie.Enabled = true;
                    frm.txtId.Enabled = false;
                    OpenFormPanel(frm);
                }
            }
            else
            {
                frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                frm2.ShowDialog();
            }
        }
    }
}
    
    

