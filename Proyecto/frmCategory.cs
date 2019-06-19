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
        private Category category;
        Category cat1 = new Category("cat1", 1, 1, "cat001");
        Category cat2 = new Category("cat2", 2, 1, "cat002");
        BindingList<Category> categorys = new BindingList<Category>();


        bool flag = false;
        public frmCategory()
        {
            InitializeComponent();
            categorys.Add(cat1);
            categorys.Add(cat2);
            dgvSearch.AutoGenerateColumns = false;
            dgvSearch.DataSource = categorys;


            txtId.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void reiniciar() {
            flag = false;
            txtId.Clear();
            txtName.Clear();
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnModify.Enabled = true;
     
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            flag = true;
            txtId.Clear();
            btnNew.Enabled = false;
            //  txtName.Clear();

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
                            //Category cat = new category(name,1);
                            //Se llama al insert
                            reiniciar();
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
                            //Category cat = new category(name,0);
                            //Se llama al update
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

     
    

   

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            if ( String.IsNullOrEmpty (txtSearch.Text))
            {

                //Insertar el codigo de busqueda

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
                        ////Category cat = new category(name,0);
                        //Se llama al delete 
                        reiniciar();
                    }


                }


            
        }

      
    }
    
}
