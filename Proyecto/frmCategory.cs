﻿using System;
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
    public partial class frmCategory : Form
    {       
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        bool operation = false;
        bool flag = false;
        public frmCategory()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtName.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtSearch.CharacterCasing = CharacterCasing.Upper;
        }

        private void reiniciar() {
            flag = true;
            txtId.Clear();
            txtName.Clear();
            txtName.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        private void reiniciar2()
        {
            flag = false;
            txtId.Clear();
            txtName.Clear();
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnModify.Enabled = true;
            txtName.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            txtId.Clear();
            btnNew.Enabled = false;
            txtName.Enabled = true;
            btnSave.Enabled = true;
            btnModify.Enabled = false;
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
                    

                    frmMessageBoxSave frm = new frmMessageBoxSave();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        String name = txtName.Text;
                        AlmacenDisecWS.category c = new AlmacenDisecWS.category();
                        c.category_name = name;
                        serviceDA.insertCategory(c);
                        dgvSearch.AutoGenerateColumns = false;
                        dgvSearch.DataSource = serviceDA.queryAllCategory();
                        reiniciar();
                        btnModify.Enabled = true;
                        operation = true;
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
                            AlmacenDisecWS.category c = new AlmacenDisecWS.category();
                            c.category_name = name;
                            c.category_id = id;
                            serviceDA.updateCategory(c);

                            dgvSearch.AutoGenerateColumns = false;

                            dgvSearch.DataSource = serviceDA.queryAllCategory();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            if ( String.IsNullOrEmpty (txtSearch.Text))
            {

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllCategory();
                btnModify.Enabled = true;
                operation = true;
            }
            else {
                String name = txtSearch.Text;
      
                //Insertar el codigo de busqueda por nombre

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
                        btnModify.Enabled = false;
                        btnDelete.Enabled = true;
                        txtId.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                        txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
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
                        int result = serviceDA.deleteCategory(id);
                        dgvSearch.AutoGenerateColumns = false;
                        dgvSearch.DataSource = serviceDA.queryAllCategory();
                        reiniciar();
                        btnModify.Enabled = true;
                    }


                }


            
        }

      
    }
    
}
