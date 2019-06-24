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
    public partial class frmStoreHouse : Form
    {
        public bool flag = false;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        public frmStoreHouse()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtNameStorehouse.Enabled = true;
            txtAddressStorehouse.Enabled = true;
            txtPhone.Enabled = true;
            btnDelete.Enabled = false;
            cboCity.Enabled = true;

            btnBack.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            cboCity.DataSource = serviceDA.queryAllCitybyId(1);
            cboCity.DisplayMember = "name_city";
            cboCity.ValueMember = "id_city";
            cboCity.SelectedIndex = -1;

        }


        private void reiniciar() {

            flag = true;
            btnDelete.Enabled = false;
            txtAddressStorehouse.Clear();
            txtNameStorehouse.Clear();
            txtId.Clear();
            txtPhone.Clear();
            cboCity.SelectedIndex = -1;
        }

        private void reiniciar2()
        {
            flag = false;
            btnDelete.Enabled = false;
            txtAddressStorehouse.Clear();
            txtNameStorehouse.Clear();
            txtId.Clear();
            txtPhone.Clear();
            cboCity.Enabled = true;
            cboCity.SelectedIndex = -1;
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmMessageBoxCancel frm = new frmMessageBoxCancel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (flag == true)
                {

                    reiniciar();
                }
                else
                {


                    reiniciar2();

                }
            }
        }

 

    
        private void BtnSave_Click(object sender, EventArgs e)
        {

            {
                if (String.IsNullOrEmpty(txtNameStorehouse.Text) || 
                    String.IsNullOrEmpty(txtPhone.Text) ||cboCity.SelectedIndex ==-1
                    || String.IsNullOrEmpty(txtAddressStorehouse.Text))
                {
                    frmMessageBoxFillNull frm = new frmMessageBoxFillNull();
                    frm.ShowDialog();

                }
                else
                {


                    if (flag == true)
                    {
                        if (String.IsNullOrEmpty(txtId.Text))
                        {
                            AlmacenDisecWS.storehouse store = new AlmacenDisecWS.storehouse();

                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {

                                string name = txtNameStorehouse.Text;
                                int phoneNumber = int.Parse(txtPhone.Text);
                                string address = txtAddressStorehouse.Text;
                                store.address = address;
                                store.phone_number = phoneNumber;
                                store.storehouse_name = name;
                                //string nameCity = cboCity.Text;
                                //AlmacenDisecWS.city city = new AlmacenDisecWS.city();
                                //int id = serviceDA.CityByName(nameCity);
                                //city.id_city = id;
                                AlmacenDisecWS.city city = new AlmacenDisecWS.city();
                                city = (AlmacenDisecWS.city)cboCity.SelectedItem;
                                store.city = city;
                                int result = serviceDA.insertStorehouse(store);
                            }
                            frmSearchStoreHouse fm = Owner as frmSearchStoreHouse;
                            fm.dgvSearch.AutoGenerateColumns = false;
                            fm.dgvSearch.DataSource = serviceDA.queryAllStorehouse();

                            this.Close();


                        }
                        else
                        {
                            frmMessageBoxDataGeneral frm2 = new frmMessageBoxDataGeneral();
                            frm2.ShowDialog();

                        }

                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txtNameStorehouse.Text) ||
                            String.IsNullOrEmpty(txtPhone.Text) || cboCity.SelectedIndex == -1
                            || String.IsNullOrEmpty(txtAddressStorehouse.Text))
                        {
                            frmMessageBoxFillNull frm2 = new frmMessageBoxFillNull();
                            frm2.ShowDialog();
                        }
                        else
                        {

                            AlmacenDisecWS.storehouse store = new AlmacenDisecWS.storehouse();

                            frmMessageBoxSave frm = new frmMessageBoxSave();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                int id = int.Parse(txtId.Text);
                                string name = txtNameStorehouse.Text;
                                int phoneNumber = int.Parse(txtPhone.Text);
                                string address = txtAddressStorehouse.Text;
                                store.id_storehouse = id;
                                store.address = address;
                                store.phone_number = phoneNumber;
                                store.storehouse_name = name;
                                AlmacenDisecWS.city city = new AlmacenDisecWS.city();
                                city = (AlmacenDisecWS.city)cboCity.SelectedItem;
                                store.city = city;
                                int result = serviceDA.updateStorehouse(store);

                            }
                            

                        }
                        frmSearchStoreHouse fm = Owner as frmSearchStoreHouse;
                        fm.dgvSearch.AutoGenerateColumns = false;
                        fm.dgvSearch.DataSource = serviceDA.queryAllStorehouse();
                        this.Close();

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
                    int id = int.Parse(txtId.Text);
                    serviceDA.deleteStorehouse(id);
                    frmSearchStoreHouse fm = Owner as frmSearchStoreHouse;
                    fm.dgvSearch.AutoGenerateColumns = false;
                    fm.dgvSearch.DataSource = serviceDA.queryAllStorehouse();
                    this.Close();

                }


            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmMessageBoxBack frm = new frmMessageBoxBack();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                frmSearchStoreHouse fm = Owner as frmSearchStoreHouse;
                this.Close();
            }
        }

    }
}
