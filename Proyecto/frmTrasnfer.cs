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
    public partial class frmTrasnfer : Form
    {
        public bool flag = false;
        private List<String> listas2 = new List<String>();
        public frmTrasnfer()
        {
      
            InitializeComponent();
            txtId.Enabled = false;
           
            

            listas2.Add("Lima");
            listas2.Add("Quitor");
            cboDriver.DataSource = listas2;
            cboDestino.DataSource = listas2;
            cboOrigen.DataSource = listas2;
            cboDriver.SelectedIndex = -1;
            cboDestino.SelectedIndex = -1;
            cboOrigen.SelectedIndex = -1;

        }


        private void reiniciar() {
            flag = false;


            txtCost.Clear();
            txtId.Clear();
            txtP.Clear();


            btnEliminarItem.Enabled = true; ;
            btnAddMaterial.Enabled = true; ;

            dgvItem.Enabled = true;
            dgvItem.DataSource = null;
            cboDriver.SelectedIndex = -1;
            cboDestino.SelectedIndex = -1;
            cboOrigen.SelectedIndex = -1;





        }





        private void btnAddTool_Click(object sender, EventArgs e)
        {
            frmSearchInventoryTool frm = new frmSearchInventoryTool();
            frm.btnAddTool.Enabled = true;
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

     
        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvItem.SelectedRows.Count > 0)
            {
                if (dgvItem.CurrentRow.Cells[0].Value == null)
                {

                    frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                    frm3.ShowDialog();
                }
                else
                {
                    frmMessageBoxDelete frm = new frmMessageBoxDelete();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        dgvItem.Rows.RemoveAt(dgvItem.CurrentRow.Index);
                    }

                }
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
           
            frmSearchInventoryMaterial frm = new frmSearchInventoryMaterial();
            frm.btnAddMaterial.Visible = true;
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();


        }

       

    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {


                reiniciar();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            {


                if (flag == true)
                {

                    if (String.IsNullOrEmpty(txtCost.Text) || String.IsNullOrEmpty(txtP.Text) || cboDestino.SelectedIndex == -1
                || cboDriver.SelectedIndex == -1 || cboOrigen.SelectedIndex == -1)
                    {

                        frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                        frm.ShowDialog();


                    }
                    else
                    {

                        if (String.IsNullOrEmpty(txtId.Text))
                        {


                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {

                                //  String name = txtName.Text;
                                //Category cat = new category(name,1);
                                //Se llama al insert
                                reiniciar();
                            }

                        }
                        else
                        {

                            frmMessageBoxDataGeneral frm2 = new frmMessageBoxDataGeneral();
                            frm2.ShowDialog();

                        }

                    }
                }
                else
                {
                    if ((String.IsNullOrEmpty(txtId.Text)))
                    {

                        frmMessageBoxFillNull frm2 = new frmMessageBoxFillNull();
                        frm2.ShowDialog();

                    }
                    else
                    {

                        frmMessageBoxSave frm = new frmMessageBoxSave();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            //  int id = Int32.Parse(txtId.Text);
                            //    String name = txtName.Text;
                            //  Category cat = (Category)cboCategory.SelectedIndex;
                            //Category cat = new category(name,0);
                            //Se llama al update
                            reiniciar();
                        }
                    }

                }
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
                    //   int id = Int32.Parse(txtId.Text);
                    //String name = txtName.Text;
                    ////Category cat = new category(name,0);
                    //Se llama al delete 
                    reiniciar();
                }


            }
        }

      

    
    }
    }




