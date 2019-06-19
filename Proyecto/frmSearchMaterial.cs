
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
    public partial class frmSearchMaterial : Form
    {
        private List<Items> listas = new List<Items>();
        private Items items;
        public frmSearchMaterial()
        {
            InitializeComponent();

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



        private void btnBuscarMaterial_Click(object sender, EventArgs e)
        {
            //Metodos de busqueda
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
           

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
                        frm.flag = 2;
                 
                        frm.cboCategory.Enabled = false;
                        frm.cboFamily.Enabled = false;
                        frm.cboBrand.Enabled = false;
                        frm.cboUnit.Enabled = false;
                        frm.cboSupplier.Enabled = false;
                        frm.cboMoney.Enabled = false;
                        frm.txtName.Enabled = false;
                        frm.txtPrice.Enabled = false;
                        frm.txtMinQuantity.Enabled = false;
            // frm.btnDelete.Enabled = true;
            //Llenamos todos los datos falta ver como capturarlos


            OpenFormPanel(frm);
                    }

                }
                else
                {
                frmMessageBoxSelectRow frm2 = new frmMessageBoxSelectRow();
                frm2.ShowDialog();
                }

            }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            
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
                }

            }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.flag = 1;
            OpenFormPanel(frm);
        }
    }
    }
    
    

