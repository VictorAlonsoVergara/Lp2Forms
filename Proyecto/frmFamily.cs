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
    public partial class frmFamily : Form
    {
        private String nombreTextoAnterior = null;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        bool flag = false;
        private List<String> listas = new List<String>();

        bool operation = false;
        public frmFamily()
        {
            InitializeComponent();
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            cboCategory.DataSource = serviceDA.queryAllCategory();
            cboCategory.DisplayMember = "category_name";
            cboCategory.ValueMember = "category_id";
            cboCategory.Enabled = false;

            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            cmbSearch.DataSource = serviceDA.queryAllCategory();
            cmbSearch.DisplayMember = "category_name";
            cmbSearch.ValueMember = "category_id";
            cmbSearch.Enabled = true;
           
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtName.CharacterCasing = CharacterCasing.Upper;

            listas.Add("MATERIAL");
            listas.Add("HERRAMIENTA");

            cboType.DataSource = listas;
            cboType.Enabled = false;
            cboCategory.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;
        }

        private void reiniciar() {
            flag = true;
            txtId.Clear();
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
            cboCategory.Enabled = false;            
            txtId.Enabled = false;
            txtName.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            cboType.Enabled = false;
        }
        private void reiniciar2()
        {
            flag = true;
            txtId.Clear();
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
            cboCategory.Enabled = false;
            txtId.Enabled = false;
            txtName.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnModify.Enabled = true;
            cboType.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            txtId.Clear();
            cboCategory.Enabled = true;
            cmbSearch.Enabled = true;
            txtName.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnModify.Enabled = false;
            cboType.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();

            }
            else
            {


                if (flag == true)
                {
                   
                        if ((cboCategory.SelectedIndex == -1)|| (cboType.SelectedIndex == -1)) {
                            frmMessageBoxCategory frm = new frmMessageBoxCategory();
                            frm.ShowDialog();
                        }
                        else
                        {
                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                String name = txtName.Text;                   
                                AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;                                
                                AlmacenDisecWS.family f = new AlmacenDisecWS.family();
                                f.name_family = name;
                                f.category = c;
                                                            
                          
                                btnModify.Enabled = true;
                                operation = true;
                                dgvSearch.AutoGenerateColumns = false;
                            int a = 0;
                            string a1 = cboType.SelectedItem.ToString();
                            if (cboType.SelectedItem.ToString() == "MATERIAL")
                            {
                                a = 1;

                            }
                            else if (cboType.SelectedItem.ToString() == "HERRAMIENTA")
                            {
                                a = 2;
                            }


                            int result = serviceDA.insertFamily(f,a);
                            dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                            cmbSearch.Text = cboCategory.Text;
                            reiniciar();
                          

                        }
                        }

                   

                }
                else
                {
                    if (String.IsNullOrEmpty(txtId.Text) || String.IsNullOrEmpty(cboCategory.Text))
                    {

                        frmMessageBoxFillNull frm2 = new frmMessageBoxFillNull();
                        frm2.ShowDialog();

                    }
                    else
                    {

                        frmMessageBoxSave frm = new frmMessageBoxSave();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            int id = Int32.Parse(txtId.Text);
                            String name = txtName.Text;
                            AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
                            AlmacenDisecWS.family f = new AlmacenDisecWS.family();
                            f.id_family = id;
                            f.name_family = name;
                            f.category = c;
                            int result = serviceDA.updateFamily(f);
                            dgvSearch.AutoGenerateColumns = false;
                            dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                            cmbSearch.Text = cboCategory.Text;
                            reiniciar();
                            operation = true;
                            btnModify.Enabled = true;
                        }
                    }

                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (flag == true)
                {
                    reiniciar();
                    if (operation == true)
                        btnModify.Enabled = true;
                }
                else
                {
                    reiniciar2();
                }
            }
        }


        private void BtnModify_Click(object sender, EventArgs e)
        {

            
            if (dgvSearch.SelectedRows.Count > 0)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value == null)
                    {

                        frmMessageBoxInvalidData frm = new frmMessageBoxInvalidData();
                        frm.ShowDialog();
                    }
                    else
                    {
                        flag = false;
                        btnNew.Enabled = false;
                        btnDelete.Enabled = true;
                        btnModify.Enabled = false;
                        txtId.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                        txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        nombreTextoAnterior = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        cboCategory.Text = cmbSearch.Text;
                        cboCategory.Enabled = true;
                    cboType.Enabled = false;
                        txtName.Enabled = true;
                        operation = true;
                        btnSave.Enabled = true;
                    }

                }
                else
                {
                    frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                    frm2.ShowDialog();
                }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
                if ( String.IsNullOrEmpty(txtId.Text) || String.IsNullOrEmpty(cboCategory.Text))
                {
                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();

                }
                else
                {
                    frmMessageBoxDelete frm = new frmMessageBoxDelete();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int id = Int32.Parse(txtId.Text);
                        String name = txtName.Text;
                        int result = serviceDA.deleteFamily(id);
                        dgvSearch.AutoGenerateColumns = false;
                        AlmacenDisecWS.category c = (AlmacenDisecWS.category)cboCategory.SelectedItem;
                        dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                        reiniciar();
                        btnModify.Enabled = true;
                    }

                }            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(cmbSearch.Text))
            {
                //Insertar el codigo de busqueda
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();
            }
            else
            {
                String nameC = cmbSearch.Text;
                dgvSearch.AutoGenerateColumns = false;
                AlmacenDisecWS.category c = serviceDA.queryAllCategoryByName(nameC);
                dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                btnModify.Enabled = true;
                operation = true;
            }
        }

  
    }
    
}
