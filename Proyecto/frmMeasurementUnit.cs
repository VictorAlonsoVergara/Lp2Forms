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
    public partial class frmMeasurementUnit : Form
    {
        bool flag = false;
        private String nombreTextoAnterior = null;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        bool operation = false;
        public frmMeasurementUnit()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            txtA.Enabled = false;
            txtId.Enabled = false;
            txtName.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtA.CharacterCasing = CharacterCasing.Lower;
            txtSearch.CharacterCasing = CharacterCasing.Upper;
        }

        private void reiniciar() {
            flag = true;
            txtId.Clear();
            txtName.Clear();
            txtA.Clear();
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtA.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        private void reiniciar2()
        {
            flag = false;
            txtId.Clear();
            txtName.Clear();
            txtA.Clear();
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtA.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnModify.Enabled = true;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            txtId.Clear();
            txtName.Enabled = true;
            txtA.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnModify.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtA.Text))
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
                        String abrev = txtA.Text;
                        AlmacenDisecWS.measureUnit mU = new AlmacenDisecWS.measureUnit();
                        mU.abbrevation_measure_unit = abrev;
                        mU.description = name;                       
                        serviceDA.insertMeasure_unit(mU);
                        dgvSearch.AutoGenerateColumns = false;
                        dgvSearch.DataSource = serviceDA.queryAllMeasurement_Unit();
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
                            String abrev = txtA.Text;
                            AlmacenDisecWS.measureUnit mU = new AlmacenDisecWS.measureUnit();
                            mU.abbrevation_measure_unit = abrev;
                            mU.description = name;
                            mU.id_measure_unit = id;
                            serviceDA.updateMeasure_unit(mU);
                            dgvSearch.AutoGenerateColumns = false;
                            dgvSearch.DataSource = serviceDA.queryAllMeasurement_Unit();
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
                    /*
                    flag = false;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    btnDelete.Enabled = true;
                    txtId.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                    txtA.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    */
                    flag = false;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    btnDelete.Enabled = true;
                    txtId.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                    txtA.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    txtName.Enabled = true;
                    txtA.Enabled = true;
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
                    int result = serviceDA.deleteMeasure_unit(id);
                    dgvSearch.AutoGenerateColumns = false;
                    dgvSearch.DataSource = serviceDA.queryAllMeasurement_Unit();
                    reiniciar();
                    btnModify.Enabled = true;
                }
            }



        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllMeasurement_Unit();
                btnModify.Enabled = true;
                operation = true;
            }
            else
            {
                String name = txtSearch.Text;
            }
            
        }

    }
}