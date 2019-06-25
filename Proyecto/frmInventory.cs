
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
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        public frmInventory()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            listas.Add("Materiales");
            listas.Add("Herramientas");
            cboInventory.DataSource = listas;
            cboInventory.SelectedIndex = -1;
            cboStore.DataSource = serviceDA.queryAllStorehouse();
            cboStore.DisplayMember = "storehouse_name";
            cboStore.SelectedIndex = -1;
            cboStore.ValueMember = "id_storehouse";
            dgvMaterial.Visible = false;
            dgvTool.Visible = false;
            lblM.Visible = false;
            lblTool.Visible = false;
        }

       private void reiniciar() {




        }
        private void BtnSearchW_Click(object sender, EventArgs e)
        {
        
                if ((cboInventory.SelectedIndex == -1)|| (cboInventory.SelectedIndex == -1))
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
                    AlmacenDisecWS.storehouse s = new AlmacenDisecWS.storehouse();
                    s = (AlmacenDisecWS.storehouse)cboStore.SelectedItem;
                    lblM.Visible = true;
                    lblTool.Visible = false;
                    dgvMaterial.Visible = true;
                    dgvTool.Visible = false;
                    dgvMaterial.DataSource = serviceDA.queryStockMaterialByStorehouse(s.id_storehouse);

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
                        // dgvTool.DataSource = query2
                    }



                }
                }

        }


    }
}
    
    

