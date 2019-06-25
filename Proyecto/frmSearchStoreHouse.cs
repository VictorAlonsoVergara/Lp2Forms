
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
    public partial class frmSearchStoreHouse : Form
    {
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        private BindingList<Storehouse> list = new BindingList<Storehouse>();
        public frmSearchStoreHouse()
        {
            InitializeComponent();
            //dgvSearch.Rows.Insert(0, "Cod1", "Brasil", "Av.  Brasil", "Lima",  "4532345");
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            btnModify.Enabled = false;
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

        private void BtnModify_Click(object sender, EventArgs e)
        {

            frmStoreHouse frm = new frmStoreHouse();
            frm.flag = false;
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.cboCity.Enabled = true;

            String name = dgvSearch.CurrentRow.Cells[1].Value.ToString();
            AlmacenDisecWS.storehouse store = new AlmacenDisecWS.storehouse();
            store = serviceDA.queryStorehouseByName(name);

            frm.txtId.Text = store.id_storehouse.ToString();
            frm.txtNameStorehouse.Text = store.storehouse_name;
            frm.txtAddressStorehouse.Text = store.address;
            frm.txtPhone.Text = store.phone_number.ToString();
            frm.txtId.Enabled = false;
            frm.cboCity.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
            frm.btnDelete.Enabled = true;
            btnModify.Enabled = true;
            frm.BringToFront();
            frm.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmStoreHouse frm = new frmStoreHouse();
            frm.flag = true;
            //OpenFormPanel(frm);
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                /*
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = serviceDA.queryAllStorehouse();
                */

                list.Clear();
                int cont = 0;
                AlmacenDisecWS.storehouse[] a = new AlmacenDisecWS.storehouse[100];

                a = serviceDA.queryAllStorehouse();
                cont = a.Count();
                for (int i = 0; i < cont; i++)
                {
                    Storehouse s = new Storehouse();
                    s.id_storehouse = a[i].id_storehouse;
                    s.phone_number = a[i].phone_number;
                    s.storehouse_name = a[i].storehouse_name;
                    s.city.id_city = a[i].city.id_city;
                    s.city.name_city = a[i].city.name_city;
                    s.address = a[i].address;
                    s.storehouse_status = a[i].storehouse_status;
                    list.Add(s);
                }

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = list;

            }
            else
            {
                String name = txtSearch.Text;

                //Insertar el codigo de busqueda por nombre

            }
            btnModify.Enabled = true;
        }
    }
}
