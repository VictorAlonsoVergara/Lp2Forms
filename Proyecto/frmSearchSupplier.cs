
using System;
using System.Collections;
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
    public partial class frmSearchSupplier : Form
    {
        private String nombreTextoAnterior = null;
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        private ArrayList array = new ArrayList();
        private BindingList<Supplier> list = new BindingList<Supplier>();
     
    
        public frmSearchSupplier()
        {
          
           
            InitializeComponent();
           
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();

            txtSearch.CharacterCasing = CharacterCasing.Upper;

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
           
            
            if (dgvSearch.SelectedRows.Count > 0)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value == null)
                    {

                        frmMessageBoxInvalidData frm3 = new frmMessageBoxInvalidData();
                        frm3.ShowDialog();
                    }
                    else
                    {
                    frmSupplier frm = new frmSupplier();
                    AddOwnedForm(frm);
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    this.Controls.Add(frm);
                    this.Tag = frm;
                    frm.BringToFront();
               
                    frm.flag = false;
                   
                        frm.btnDelete.Enabled = true;
                        frm.txtCode.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                        frm.txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        frm.txtRuc.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                        frm.txtAddress.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
                        //Los combo box se rellenan diferente asi no   
                        //frm.cboCity.SelectedValue = dgvSearch.CurrentRow.Cells[4].Value.ToString();
                        //frm.cboCountry.SelectedValue = dgvSearch.CurrentRow.Cells[5].Value.ToString();
                        frm.txtPhone.Text = dgvSearch.CurrentRow.Cells[5].Value.ToString();
                        frm.txtEmail.Text = dgvSearch.CurrentRow.Cells[6].Value.ToString();
              
                    frm.cboCountry.Enabled = false;
                    frm.cboCity.Enabled = false;

                    frm.Show();

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
            frmSupplier frm = new frmSupplier();
            frm.flag = true;
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                list.Clear();
                int cont = 0;
                AlmacenDisecWS.supplier[] a = new AlmacenDisecWS.supplier[100];

                a = serviceDA.queryAllSupplier();
                cont = a.Count();
                for (int i = 0; i < cont; i++)
                {
                    Supplier s = new Supplier();
                    //     s = (Supplier)a[i];
                    s.id_supplier = a[i].id_supplier;
                    s.supplier_name = a[i].supplier_name;
                    s.city.id_city = a[i].city.id_city;
                    s.city.name_city = a[i].city.name_city;
                    s.email = a[i].email;
                    s.ruc = a[i].ruc;
                    s.phone_number = a[i].phone_number;
                    s.adress = a[i].adress;
                    list.Add(s);
                }


                /*  s2.supplier_name = a[1].supplier_name;
                  s2.city.id_city = a[1].city.id_city;
                  s2.city.name_city = a[1].city.name_city;
                  s3.supplier_name = a[2].supplier_name;
                  s3.city.id_city = a[2].city.id_city;
                  s3.city.name_city = a[2].city.name_city;

                  s2.email = a[1].email;
                  s2.ruc = a[1].ruc;
                  s2.phone_number = a[1].phone_number;
                  s2.adress = a[1].adress;
                  s3.email = a[2].email;
                  s3.ruc = a[2].ruc;
                  s3.phone_number = a[2].phone_number;
                  s3.adress = a[2].adress;




                  list.Add(s2);
                  list.Add(s3);*/

                btnModify.Enabled = true;
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = list;


            }
            else
            {
                BindingList<Supplier> list2 = new BindingList<Supplier>();
                AlmacenDisecWS.supplier s = new AlmacenDisecWS.supplier();
                String name = txtSearch.Text;

                s = serviceDA.querySupplierByName(name);
                if (s.id_supplier == 0) {

                    frmMessageBoxSearchNull frm = new frmMessageBoxSearchNull();
                    frm.ShowDialog();

                }
                else
                {
                    Supplier s2 = new Supplier();

                    s2.id_supplier = s.id_supplier;

                    s2.supplier_name = s.supplier_name;
                    s2.city.id_city = s.city.id_city;
                    s2.city.name_city = s.city.name_city;
                    s2.email = s.email;
                    s2.ruc = s.ruc;
                    s2.phone_number = s.phone_number;
                    s2.adress = s.adress;
                    dgvSearch.AutoGenerateColumns = false;
                    list2.Add(s2);
                    dgvSearch.DataSource = list2;
                    btnModify.Enabled = true;
                }

                //Insertar el codigo de busqueda por nombre

            }
        }

    }
}
