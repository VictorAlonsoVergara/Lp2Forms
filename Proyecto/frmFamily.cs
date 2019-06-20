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
        public frmFamily()
        {
            InitializeComponent();
            txtId.Enabled = false;
            btnDelete.Enabled = false;
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            cboCategory.DataSource = serviceDA.queryAllCategory();
            cboCategory.DisplayMember = "category_name";
            cboCategory.ValueMember = "category_id";
            cboCategory.Enabled = false;
            txtId.Enabled = false;
            txtName.Enabled = false;
            //cboCategory.SelectedIndex = -1;
        }

        private void reiniciar() {
            flag = false;
            txtId.Clear();
            txtName.Clear();
            btnDelete.Enabled = false;
            cboCategory.SelectedIndex = -1;
            btnNew.Enabled = true;
            btnModify.Enabled = true;
            cboCategory.Enabled = false;
            txtId.Enabled = false;
            txtName.Enabled = false;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            btnDelete.Enabled = false;
            txtId.Clear();
            btnNew.Enabled = false;
            cboCategory.Enabled = true;
            txtName.Enabled = true;
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
                   
                        if (cboCategory.SelectedIndex == -1) {
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
                                int result = serviceDA.insertFamily(f);                                
                                dgvSearch.AutoGenerateColumns = false;
                                dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                                reiniciar();
                            }
                        }

                   

                }
                else
                {
                    if (String.IsNullOrEmpty(txtId.Text))
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
                            int result = serviceDA.updateFamily(f);
                            dgvSearch.AutoGenerateColumns = false;
                            dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
                            reiniciar();
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


                reiniciar();
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
                        //AlmacenDisecWS.category c = serviceDA.queryAllCategoryByName(dgvSearch.CurrentRow.Cells[1].Value.ToString());
                        cboCategory.Text = txtSearch.Text;
                        cboCategory.Enabled = true;
                        txtName.Enabled = true;
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
           
                if ( String.IsNullOrEmpty(txtId.Text))
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
                    }

                }            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                //Insertar el codigo de busqueda
                frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                frm.ShowDialog();
            }
            else
            {
                String nameC = txtSearch.Text;
                dgvSearch.AutoGenerateColumns = false;
                AlmacenDisecWS.category c = serviceDA.queryAllCategoryByName(nameC);
                dgvSearch.DataSource = serviceDA.queryAllFamily(c.category_id);
            }
        }
    }
    
}
