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
    public partial class frmWorkOrder : Form
    {
        public bool flag = false;
        private List<String> listas2 = new List<String>();
        public frmWorkOrder()
        {
      
            InitializeComponent();
            txtRucC.Enabled = false;
            txtNameC.Enabled = false;
            txtCodeWorkOrder.Enabled = false;
            cboStatus.SelectedIndex = -1;

            listas2.Add("Lima");
            listas2.Add("Quitor");
            cboStatus.DataSource = listas2;
            cboStatus.SelectedIndex = -1;

        }


        private void reiniciar() {
            flag = false;
            txtCodeWorkOrder.Clear();

            txtDesc.Clear();
            txtDesc.Enabled = true;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            dtpFin.Enabled = true;
            dtpInicio.Enabled = true;
         
            btnEliminarItem.Enabled = true;;
            btnAddMaterial.Enabled = true; ;
            btnAddTool.Enabled = true;
            dgvSearchClient.Enabled = true;
            dgvItem.Enabled = true;
            dgvItem.DataSource = null;
            cboStatus.SelectedIndex = -1;


        }



        private void DgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameC.Text = dgvSearchClient.CurrentRow.Cells[0].Value.ToString();
            txtRucC.Text = dgvSearchClient.CurrentRow.Cells[1].Value.ToString();
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

        private void btnAddTool_Click_1(object sender, EventArgs e)
        {
            frmSearchInventoryTool frm = new frmSearchInventoryTool();
         
            frm.btnAddTool.Visible = true;
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

                    if (String.IsNullOrEmpty(txtNameC.Text) || String.IsNullOrEmpty(txtRucC.Text) ||
                String.IsNullOrEmpty(txtDesc.Text) || cboStatus.SelectedIndex == -1)
                    {

                        frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                        frm.ShowDialog();


                    }
                    else
                    {

                        if (String.IsNullOrEmpty(txtCodeWorkOrder.Text))
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
                    if ((!String.IsNullOrEmpty(txtCodeWorkOrder.Text))||cboStatus.SelectedIndex==-1)
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

       
    }
    }



