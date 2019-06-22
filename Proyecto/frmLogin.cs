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
        private System.Timers.Timer aTimer;
        public frmLogin()
        {
            InitializeComponent();
            serviceDA = new AlmacenDisecWS.DBControllerWSClient();
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 6000;
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

        private void BtnEntrarLogin_Click(object sender, EventArgs e)
        {
            /*
            if (txtUsername.Text == "Admin1234")
            {
                //txtPassword.Text = "1234567";)
                if (txtPassword.Text == "12")
                {
                    MessageBox.Show("Bienvenido administrador");
                    this.Hide();
                    frmPrincipal mainWindow = new frmPrincipal();
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

            if (txtUsername.Text == "Worker1234")
            {
                //txtPassword.Text = "1234567";)
                if (txtPassword.Text == "12")
                {
                    MessageBox.Show("Bienvenido trabajador de almacen");
                    this.Hide();
                    frmPrincipal mainWindow = new frmPrincipal();
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

            if (txtUsername.Text == "Technician1234")
            {
                //txtPassword.Text = "1234567";)
                if (txtPassword.Text == "12")
                {
                    MessageBox.Show("Bienvenido técnico");
                    this.Hide();
                    frmPrincipal mainWindow = new frmPrincipal();
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    return;
                }
            }*/
            frmPrincipal mainWindow = new frmPrincipal();
            mainWindow.Closed += (s, args) => this.Close();
            mainWindow.Show();
            return;
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
            
            String pass=txtPassword.Text;
            String user = txtUsername.Text;
            int result=serviceDA.ConfirmUsuario(user, pass);
            if (cont < 4) {
                if (result == 1)
                {

                    // mainWindow.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmPrincipal mainWindow = new frmPrincipal();
                    serviceDA.EmployeeByCode(user);
                    mainWindow.Show();

                    return;


                }
                else {

                    MessageBox.Show("Noobs");
                    cont++;

               
                }
            } else {
                MessageBox.Show("Se bloqueara el sistema");
                btnEntrarLogin.Enabled = false;
               long  cont2 = 0;
               while(true)
                {
                    /*
                     cont2++;
                    if (cont2 == 150000000) {
                        btnEntrarLogin.Enabled = true;
                        cont = 0;
                        MessageBox.Show(cont2.ToString() );
                        break;
                    }*/
                    Task.Delay(15000).ContinueWith(t=>
                    {
                        btnEntrarLogin.Enabled = true;
                    });

                }

              
              
                    

            }
         
        }


        private void eventTimer(object sender, EventArgs e)
        {     
            MessageBox.Show("Holi");
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
