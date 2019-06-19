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
	public partial class frmMain : Form
	{
		private int privilegy;

		public int Privilegy { get => privilegy; set => privilegy = value; }

		public frmMain(int p)
		{
			InitializeComponent();
			txtIdStore.Enabled = false;
			BotonRedondeado.BordeRedondo(btnCancelStorehouse);
			BotonRedondeado.BordeRedondo(btnSearchStorehouse);
			BotonRedondeado.BordeRedondo(btnNewStorehouse);
			BotonRedondeado.BordeRedondo(btnSaveStorehouse);
			BotonRedondeado.BordeRedondo(btnTrasladoAlmacen);
			this.tabReportes.Parent = null;
			this.tabUsuarios.Parent = null;
			this.tabCategorías.Parent = null;
			this.tabAlmacenes.Parent = null;
			this.tabHerramientas.Parent = null;
			this.tabMarcas.Parent = null;
			this.tabMateriales.Parent = null;
			this.tabProveedores.Parent = null;
			privilegy = p;
			inicializePrivilegy();
		}

		private void inicializePrivilegy()
		{
			if (Privilegy == 1)
			{
				this.tabReportes.Parent = this.tabControl1;
				this.tabUsuarios.Parent = this.tabControl1;
				this.tabCategorías.Parent = this.tabControl1;
				this.tabAlmacenes.Parent = this.tabControl1;
				this.tabHerramientas.Parent = this.tabControl1;
				this.tabMarcas.Parent = this.tabControl1;
				this.tabMateriales.Parent = this.tabControl1;
				this.tabProveedores.Parent = this.tabControl1;
				this.btnTrasladoAlmacen.Visible = true;
			}
			else if (Privilegy == 2)
			{
				this.tabCategorías.Parent = this.tabControl1;
				this.tabAlmacenes.Parent = this.tabControl1;
				this.tabHerramientas.Parent = this.tabControl1;
				this.tabMarcas.Parent = this.tabControl1;
				this.tabMateriales.Parent = this.tabControl1;
				this.tabProveedores.Parent = this.tabControl1;
				this.btnTrasladoAlmacen.Visible = false;
			}
			else
			{
				this.btnTrasladoAlmacen.Visible = false;
			}

		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			frmLogin login = new frmLogin();
			this.Hide();
			login.Closed += (s, args) => this.Close();
			login.Show();
		}

		private void clickCloseMain(object sender, FormClosingEventArgs e)
		{

		}

		private void clickTransfer(object sender, EventArgs e)
		{
			//TrasladoAlmacenForm frmTransfer = new TrasladoAlmacenForm();
			//frmTransfer.ShowDialog();

		}


		private void btnNewStorehouse_Click(object sender, EventArgs e)
		{

		}

		private void btnSaveStorehouse_Click(object sender, EventArgs e)
		{

		}

		private void btnSearchStorehouse_Click(object sender, EventArgs e)
		{
	
		}

		private void btnCancelStorehouse_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox8_Enter(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
					}

		private void button12_Click(object sender, EventArgs e)
		{
/*			"frmSearchCategory frm = new frmSearchCategory();"

			if (frm.ShowDialog() == DialogResult.OK)
			{
				txtIdCategory.Text = frm.Category.IdCategory.ToString();
				txtNameCategory.Text = frm.Category.NombreCategory;
				txtCodeCategory.Text = frm.Category.CodCategory;




			} */
		}

		private void btnSearchMaterial_Click(object sender, EventArgs e)
		{
			frmSearchMaterial frmMaterial = new frmSearchMaterial();
			if (frmMaterial.ShowDialog() == DialogResult.OK)
			{
			/*	txtIdMaterial.Text = frmMaterial.Items.Id.ToString();
				txtNameMaterial.Text = frmMaterial.Items.Nombre;
				txtCodeMaterial.Text = frmMaterial.Items.CodItem;
				txtSerieMaterial.Text = frmMaterial.Items.Serie;
				txtCantMaterial.Text = frmMaterial.Items.Cant.ToString();
				txtCantMin.Text = frmMaterial.Items.CantMinima.ToString();
				cboCategoriaMaterial.SelectedValue = frmMaterial.Items.CategoryItem;
				cboMarcaMaterial.SelectedValue = frmMaterial.Items.BrandItem;*/
			}
		}

		private void btnBuscarHerramienta_Click(object sender, EventArgs e)
		{
			/*BuscarHerramienta frmHerramienta = new BuscarHerramienta();
			if (frmHerramienta.ShowDialog() == DialogResult.OK)
			{
				txtIdTool.Text = frmHerramienta.Herramienta.Id.ToString();
				txtNameTool.Text = frmHerramienta.Herramienta.Nombre;
				txtCodeTool.Text = frmHerramienta.Herramienta.CodHerramienta;
				txtSerieTool.Text = frmHerramienta.Herramienta.Serie;
				txtCantTool.Text = frmHerramienta.Herramienta.Cant.ToString();
				cboCateTool.SelectedValue = frmHerramienta.Herramienta.CategoryHerramienta;
				cboBrandTool.SelectedValue = frmHerramienta.Herramienta.BrandHerramienta;
			}
		}

		private void txtEmployee_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblNameMaterial_Click(object sender, EventArgs e)
		{

		}

		private void button24_Click(object sender, EventArgs e)
		{
			frmSearchMaterial frmMaterial = new frmSearchMaterial();
			if (frmMaterial.ShowDialog() == DialogResult.OK)
			{

			}
		}

		private void button30_Click(object sender, EventArgs e)
		{
			BuscarHerramienta frmHerramienta = new BuscarHerramienta();
			if (frmHerramienta.ShowDialog() == DialogResult.OK)
			{
				txtIdMaterialO.Text = frmHerramienta.Herramienta.Id.ToString();
				txtnombreMaterialO.Text = frmHerramienta.Herramienta.Nombre;
				txtSerialMaterialO.Text = frmHerramienta.Herramienta.CodHerramienta;
				txtCantidadMaterialO.Text = frmHerramienta.Herramienta.Serie;
				txtMarcaMaterialO.Text = frmHerramienta.Herramienta.Cant.ToString();
				txtMaterialCategoriaO.Text = frmHerramienta.Herramienta.CategoryHerramienta.ToString();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			

		}

		private void button23_Click(object sender, EventArgs e)
		{

		}

		private void button22_Click(object sender, EventArgs e)
		{
            /*frmBuscarWorkOrder frm = new frmBuscarWorkOrder();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtDescriptionWorkOrder.Text = frm.WorkOrder.Descripcion;
                txtIDWorkOrder.Text = frm.WorkOrder.IdOrdenTrabajo.ToString();
                dtpStartDate.Value = frm.WorkOrder.FechaInicio;
                dtpEndDate.Value = frm.WorkOrder.FechaFin;
                txtCodeWorkOrder.Text = frm.WorkOrder.CodOrdenTrabajo.ToString();
            }*/
        }

        private void button28_Click(object sender, EventArgs e)
        {
        
        }

        private void textIdUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportType = (string)comboBox7.SelectedItem;
        }

        private void reporteClick(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            string[] reportType = { "Inventario valorizado", "Kardex"};
            comboBox7.Items.AddRange(reportType);
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
         /*   frmSearchUser frm = new frmSearchUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtEmployee.Text = frm.User.Nombre + " " + frm.User.ApellidoPaterno + " " + frm.User.ApellidoMaterno;
            }*/
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
         
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se generó el reporte correctamente", "Confirmación");
        }
    }
}
	
