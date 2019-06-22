using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenDisecForms
{
    public partial class frmLogin : Form
    {
        private AlmacenDisecWS.DBControllerWSClient serviceDA;
        private int cont = 1;
        
     
        public frmLogin()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            lblCont.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username") {
                txtUsername.Text = "";
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

  

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            pctDontLookPassword.Visible = false;
            pctLookPassword.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            pctLookPassword.Visible = false;
            pctDontLookPassword.Visible = true;
        }

        private void btnEntrarLogin_Click_1(object sender, EventArgs e)
        {

            String pass = txtPassword.Text;
            String user = txtUsername.Text;
            int result = serviceDA.ConfirmUsuario(user, pass);
            if (cont < 4)
            {
                if (result == 1)
                {
                    AlmacenDisecWS.employee emp = serviceDA.EmployeeByCode(user);
                    // mainWindow.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmPrincipal mainWindow = new frmPrincipal();
                    mainWindow.lblCargo.Text = emp.privilege.ToString();
                    mainWindow.lblNombre.Text = emp.employee_name;
                    mainWindow.lblApellidos.Text = emp.last_name + " " + emp.second_last_name;

                    mainWindow.Show();

                    return;


                }
                else
                {

                    frmMessageBoxDontCoincidence fm = new frmMessageBoxDontCoincidence();
                    fm.ShowDialog();
                    cont++;


                }
            }
            else
            {
                frmMessageBoxBlockSystem fm = new frmMessageBoxBlockSystem();
                fm.ShowDialog();
                cont = 0;
                btnEntrarLogin.Enabled = false;
                tmLogin.Start();

            }

        }
        private void eventTimer(object sender, EventArgs e)
        {     
            MessageBox.Show("Holi");
        }

        private void TmLogin_Tick(object sender, EventArgs e)
        {
            int r = Int32.Parse(lblCont.Text);
            r++;
            lblCont.Text = r.ToString();
            if (r == 1000)
            {

                tmLogin.Stop();
                lblCont.Text = "1";

                btnEntrarLogin.Enabled = true;
            }
        }









        /*
          private void BtnSalirLogin_Click(object sender, EventArgs e)
          {
              Application.Exit();
          }

          private void BtnLookPassword_Click(object sender, EventArgs e)
          {
              txtPassword.PasswordChar = '\0';
              btnLookPassword.Visible = false;
              btnDontLookPassword.Visible = true;
          }

          private void BtnDontLookPassword_Click(object sender, EventArgs e)
          {
              txtPassword.PasswordChar = '*';
              btnDontLookPassword.Visible = false;
              btnLookPassword.Visible = true;
          }*/
        /*
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {


            if (txtUsername.Text == "Admin1234") {
                //txtPassword.Text = "1234567";)
                if (txtPassword.Text == "12")
                {
                    MessageBox.Show("Bienvenido administrador");
                    this.Hide();
                    frmMain mainWindow = new frmMain(1);
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow.Show();
                    return;
                }
                else {
                    MessageBox.Show("Datos incorrectos");
                    return;
                }
            }

            if (txtUsername.Text == "Worker1234")                {
                //txtPassword.Text = "1234567";)
                if (txtPassword.Text == "12")
                {
                    MessageBox.Show("Bienvenido trabajador de almacen");
                    this.Hide();
                    frmMain mainWindow = new frmMain(2);
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow.Show();
                    return;
                }
                else              {
                    MessageBox.Show("Datos incorrectos");
                    return;
                }
            }

             if (txtUsername.Text == "Technician1234")
                {
                    //txtPassword.Text = "1234567";)
                    if (txtPassword.Text == "12")
                    {
                        MessageBox.Show("Bienvenido técnico");
                        this.Hide();
                        frmMain mainWindow = new frmMain(3);
                        mainWindow.Closed += (s, args) => this.Close();
                        mainWindow.Show();
                    return;
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                        return;
                    }
                }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }*/
    }
}
