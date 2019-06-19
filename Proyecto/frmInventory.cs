
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
    public partial class frmInventory : Form
    {
        private List<String> listas = new List<String>();

        public frmInventory()
        {
            InitializeComponent();
            listas.Add("Materiales");
            listas.Add("Herramientas");
            cboInventory.DataSource = listas;
             cboInventory.SelectedIndex = -1;
            dgvMaterial.Visible = false;
            dgvTool.Visible = false;
            lblM.Visible = false;
            lblTool.Visible = false;
        }

        private void BtnSearchW_Click(object sender, EventArgs e)
        {
        
                if (cboInventory.SelectedIndex == -1)
                {
                    frmMessageBoxError fm = new frmMessageBoxError();
                    fm.ShowDialog();
                }
                else
                {
                    if (cboInventory.SelectedItem.ToString() == "Materiales")
                    {
                    //frmSearchInventoryMaterial fm = new frmSearchInventoryMaterial();
                    // fm.lblMaterial.Visible = false;
                    // OpenFormPanel(fm);
                    lblM.Visible = true;
                    lblTool.Visible = false;
                    dgvMaterial.Visible = true;
                        dgvTool.Visible = false;

                    }
                    else
                    {
                        if (cboInventory.SelectedItem.ToString() == "Herramientas")
                        {
                        //    frmSearchInventoryTool fm = new frmSearchInventoryTool();
                        //   fm.lblMaterial.Visible = false;
                        //  OpenFormPanel(fm);
                        lblM.Visible = false;
                        lblTool.Visible = true;
                        dgvTool.Visible = true;
                            dgvMaterial.Visible = false;
                        }


                    
                     }
                }

        }
    }
}
    
    

