using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace AlmacenDisecForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            plSubmenuM.Visible = false;
            plTool.Visible = false;
            plStore.Visible = false;
            plWork.Visible = false;
            plSupplier.Visible = false;
            plGUser.Visible = false;

        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(994, 748);
            this.Location = new Point(lx, ly);
            //this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }


        //Para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }



        //Metodos para hacer que el panel tenga efecto

        private void BtnAdjust_Click(object sender, EventArgs e)
        {
            if (plMenu.Width == 255)
            {
                tmHideMenu.Enabled = true;
            }
            else
            {
                tmShowMenu.Enabled = true;
            }
        }

        private void TmHideMenu_Tick(object sender, EventArgs e)
        {
            if (plMenu.Width <= 60)
            {
                tmHideMenu.Enabled = false;

            }
            else
            {
                plMenu.Width = plMenu.Width - 50;
            }
        }

        private void TmShowMenu_Tick(object sender, EventArgs e)
        {
            if (plMenu.Width >= 255)
            {
                tmShowMenu.Enabled = false;

            }
            else
            {
                plMenu.Width = plMenu.Width + 50;
            }
        }



        

        
        //Abrir form dentro del panel
        private void OpenFormPanel(object formHijo)
        {
            if (this.plContent.Controls.Count > 0)
                this.plContent.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.plContent.Controls.Add(fh);
            this.plContent.Tag = fh;
            fh.Show();
        }
       

        private void ShowFormInitial()
        {
            OpenFormPanel(new frmInitial());

        }



        private void ShowFormInitialCloseForms(object sender, FormClosedEventArgs e)
        {
            ShowFormInitial();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ShowFormInitial();
        }


        //Metodo para capturar la fecha y hora actual
        private void TmHourDate_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            //   lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }



        //Cambiar tañaño en tiempo de compilacion
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.plPrincipal.Region = region;
      
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(22, 46, 117));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }

                                                  
                     

        //Metodos de los botones
        private void BtnInventory_Click(object sender, EventArgs e)
        {
         
            frmInventory fm = new frmInventory();
            fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);


        }

        private void BtnWorkOrder_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            plWork.Visible = true;
            btnStore.Visible = false;
            btnTool.Visible = false;
           
        }

        private void BtnBrand_Click(object sender, EventArgs e)
        {
          
            frmBrand fm = new frmBrand();
            fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
           
            frmReport fm = new frmReport();
            fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnGUser_Click(object sender, EventArgs e)
        {
            plGUser.Visible = true;
            btnDisconnect.Visible = false;
        }

        private void BtnTool_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel8.Visible = false;
            btnMaterial.Visible = false;
            btnBrand.Visible = false;
            plTool.Visible = true;
            
        }

        private void BtnMaterial_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            btnBrand.Visible = false;
            btnCategory.Visible = false;
            btnFamiliy.Visible = false;
            plSubmenuM.Visible = true;

 

        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
           
            frmCategory fm = new frmCategory();
         //   fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnFamily_Click(object sender, EventArgs e)
        {
            frmFamily fm = new frmFamily();
        //    fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel8.Visible = false;
            panel6.Visible = false;
            btnBrand.Visible = false;
            plStore.Visible = true;
            btnTool.Visible = false;

            btnMaterial.Visible = false;
         
          //  fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
       
        }

       

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panel10.Visible=false;
            panel11.Visible=false;
            plSupplier.Visible = true;
            btnReport.Visible = false;
            btnGUser.Visible = false;
        }

        private void BtnSearchM_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            plSubmenuM.Visible = false;
            btnBrand.Visible = true;
            btnCategory.Visible = true;
            btnFamiliy.Visible = true;
            frmSearchMaterial fm = new frmSearchMaterial();
         //   fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);

        }

        private void BtnGM_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            plSubmenuM.Visible = false;
            btnBrand.Visible = true;
            btnCategory.Visible = true;
            btnFamiliy.Visible = true;
            frmMaterial fm = new frmMaterial();
        //    fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm); 
        }

        private void BtnUnit_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            plSubmenuM.Visible = false;
            btnBrand.Visible = true;
            btnCategory.Visible = true;
            btnFamiliy.Visible = true;
            frmMeasurementUnit fm = new frmMeasurementUnit();
       //     fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnBH_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel8.Visible = true;
            plTool.Visible = false;
            btnMaterial.Visible = true;
            btnBrand.Visible = true;
            frmSearchTool fm = new frmSearchTool();
            //   fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

     
     

      

    
        private void PlTool_MouseDown(object sender, MouseEventArgs e)
        {
            panel6.Visible = true;
            panel8.Visible = true;
            plTool.Visible = false;
            btnMaterial.Visible = true;
            btnBrand.Visible = true;
        }

        private void PlSubmenuM_MouseDown(object sender, MouseEventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            plSubmenuM.Visible = false;
            btnBrand.Visible = true;
            btnCategory.Visible = true;
            btnFamiliy.Visible = true;
        }

     

        private void BtnGS_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel6.Visible = true;
            panel8.Visible = true;
            plStore.Visible = false;
            btnTool.Visible = true;
            btnMaterial.Visible = true;
            btnBrand.Visible = true;
            frmStoreHouse fm = new frmStoreHouse();
            //   fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void PlStore_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Visible = true;
            panel8.Visible = true;
            panel6.Visible = true;
            btnBrand.Visible = true;
            plStore.Visible = false;
            btnTool.Visible = true;
            btnMaterial.Visible = true;
       
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel8.Visible = true;
            panel6.Visible = true;
            btnBrand.Visible = true;
            plStore.Visible = false;
            plTool.Visible = false;
            btnTool.Visible = true;
            btnMaterial.Visible = true;
            frmSearchTransfer fm = new frmSearchTransfer();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);

        }

   

        private void BtnGW_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            plWork.Visible = false;
            btnStore.Visible = true;
            btnTool.Visible = true;
            frmWorkOrder fm = new frmWorkOrder();
            OpenFormPanel(fm);
        }

        private void BtnSearchSupplier_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = true;
            plSupplier.Visible = false;
            btnReport.Visible = true;
            btnGUser.Visible = true;
            frmSearchSupplier fm = new frmSearchSupplier();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnGSu_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = true;
            plSupplier.Visible = false;
            btnReport.Visible = true;
            btnGUser.Visible = true;
            frmSupplier fm = new frmSupplier();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);

        }

        private void PlWork_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            plWork.Visible = false;
            btnStore.Visible = true;
            btnTool.Visible = true;
        }

        private void PlSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = true;
            plSupplier.Visible = false;
            btnReport.Visible = true;
            btnGUser.Visible = true;
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            plGUser.Visible = false;
            btnDisconnect.Visible = true;
            frmSearchUser fm = new frmSearchUser();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void BtnGUsers_Click(object sender, EventArgs e)
        {
            plGUser.Visible = false;
            btnDisconnect.Visible = true;
            frmUser fm = new frmUser();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void PlGUser_MouseDown(object sender, MouseEventArgs e)
        {
            plGUser.Visible = false;
            btnDisconnect.Visible = true;
        }

        private void PlSupplier_MouseDown_1(object sender, MouseEventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = true;
            plSupplier.Visible = false;
            btnReport.Visible = true;
            btnGUser.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
          //  frmMessageBoxBack frm = new frmMessageBoxBack();
           // if (frm.ShowDialog() == DialogResult.OK) { 
            ShowFormInitial();
       //}
     }

        private void BtnSearchStore_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel8.Visible = true;
            panel6.Visible = true;
            btnBrand.Visible = true;
            plStore.Visible = false;
            plTool.Visible = false;
            btnTool.Visible = true;
            btnMaterial.Visible = true;
            frmSearchStoreHouse fm = new frmSearchStoreHouse();
            // fm.FormClosed += new FormClosedEventHandler(ShowFormInitialCloseForms);
            OpenFormPanel(fm);
        }

        private void btnSearchW_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            plWork.Visible = false;
            btnStore.Visible = true;
            btnTool.Visible = true;
            frmSearchWorkOrder fm = new frmSearchWorkOrder();
            OpenFormPanel(fm);
        }

        
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {

        }


    }
}
