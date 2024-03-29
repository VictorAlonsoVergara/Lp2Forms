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
    public partial class frmBrand : Form
    {
        private String nombreTextoAnterior = null;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;

        bool flag = false;
        bool operation = false;
        public frmBrand()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtSearch.CharacterCasing = CharacterCasing.Upper;
            txtName.CharacterCasing = CharacterCasing.Upper;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            
        }

        private void reiniciar()
        {
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
            txtName.Enabled = true;
            btnNew.Enabled = false;
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

                        AlmacenDisecWS.brand b = new AlmacenDisecWS.brand();
                        b.brand_name = name;
                        int result = serviceDA.insertBrand(b);
                        dgvSearch.AutoGenerateColumns = false;
                        dgvSearch.DataSource = serviceDA.queryAllBrand();                        
                        reiniciar();
                        btnModify.Enabled = true;
                        operation = true;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(txtId.Text) || nombreTextoAnterior == null)
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
                            AlmacenDisecWS.brand b = serviceDA.queryBrandByName(nombreTextoAnterior);
                            b.brand_name = name;
                            int result = serviceDA.updateBrand(b);
                            dgvSearch.AutoGenerateColumns = false;
                            dgvSearch.DataSource = serviceDA.queryAllBrand();
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
                if(flag == true)
                {
                    reiniciar();
                    if(operation == true)
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

            if (String.IsNullOrEmpty(txtSearch.Text))
            { 
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllBrand();
                btnModify.Enabled = true;
                operation = true;
            }
            else
            {
                String name = txtSearch.Text;

                //  Insertar el codigo de busqueda por nombre

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

            if (String.IsNullOrEmpty(txtId.Text))
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
                    //Se llama al delete 

                    int result = serviceDA.deleteBrand(id);

                    dgvSearch.AutoGenerateColumns = false;
                    dgvSearch.DataSource = serviceDA.queryAllBrand();
                    reiniciar();
                    btnModify.Enabled = true;
                }


            }



        }

    }
    
}
