namespace AlmacenDisecForms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.plBar = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnAdjust = new System.Windows.Forms.PictureBox();
            this.btnWorkOrder = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnFamiliy = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.plMenu = new System.Windows.Forms.Panel();
            this.plStore = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearchStore = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.plSubmenuM = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnSearchM = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.PictureBox();
            this.btnGUser = new System.Windows.Forms.Button();
            this.tmHideMenu = new System.Windows.Forms.Timer(this.components);
            this.tmShowMenu = new System.Windows.Forms.Timer(this.components);
            this.tmHourDate = new System.Windows.Forms.Timer(this.components);
            this.plUser = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.plPrincipal = new System.Windows.Forms.Panel();
            this.plContent = new System.Windows.Forms.Panel();
            this.plBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjust)).BeginInit();
            this.plMenu.SuspendLayout();
            this.plStore.SuspendLayout();
            this.plSubmenuM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisconnect)).BeginInit();
            this.plUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            this.plPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBar
            // 
            this.plBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.plBar.Controls.Add(this.btnRestore);
            this.plBar.Controls.Add(this.btnMinimize);
            this.plBar.Controls.Add(this.pictureBox2);
            this.plBar.Controls.Add(this.lblTitulo);
            this.plBar.Controls.Add(this.btnClose);
            this.plBar.Controls.Add(this.btnMaximize);
            this.plBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBar.Location = new System.Drawing.Point(0, 0);
            this.plBar.Name = "plBar";
            this.plBar.Size = new System.Drawing.Size(994, 38);
            this.plBar.TabIndex = 0;
            this.plBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlBar_MouseDown);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(915, 6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(25, 25);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 2;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(872, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(45, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de almacenaje Disec";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(957, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(915, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjust.Image")));
            this.btnAdjust.Location = new System.Drawing.Point(212, 6);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(34, 34);
            this.btnAdjust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdjust.TabIndex = 4;
            this.btnAdjust.TabStop = false;
            this.btnAdjust.Click += new System.EventHandler(this.BtnAdjust_Click);
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnWorkOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnWorkOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkOrder.Image")));
            this.btnWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkOrder.Location = new System.Drawing.Point(3, 142);
            this.btnWorkOrder.Name = "btnWorkOrder";
            this.btnWorkOrder.Size = new System.Drawing.Size(289, 40);
            this.btnWorkOrder.TabIndex = 0;
            this.btnWorkOrder.Text = "  Ordenes de trabajo";
            this.btnWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkOrder.UseVisualStyleBackColor = true;
            this.btnWorkOrder.Click += new System.EventHandler(this.BtnWorkOrder_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(3, 280);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(255, 40);
            this.btnMaterial.TabIndex = 2;
            this.btnMaterial.Text = "  Materiales";
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.BtnMaterial_Click);
            // 
            // btnTool
            // 
            this.btnTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTool.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTool.ForeColor = System.Drawing.Color.White;
            this.btnTool.Image = ((System.Drawing.Image)(resources.GetObject("btnTool.Image")));
            this.btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.Location = new System.Drawing.Point(3, 234);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(255, 40);
            this.btnTool.TabIndex = 3;
            this.btnTool.Text = "  Herramientas";
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.BtnTool_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(3, 464);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(255, 40);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "  Proveedores";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 510);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(255, 40);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "  Reportes";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 372);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(255, 40);
            this.btnCategory.TabIndex = 8;
            this.btnCategory.Text = "  Categorías";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.Image")));
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(3, 326);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(255, 40);
            this.btnBrand.TabIndex = 10;
            this.btnBrand.Text = "  Marcas";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.BtnBrand_Click);
            // 
            // btnFamiliy
            // 
            this.btnFamiliy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamiliy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnFamiliy.FlatAppearance.BorderSize = 0;
            this.btnFamiliy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnFamiliy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamiliy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamiliy.ForeColor = System.Drawing.Color.White;
            this.btnFamiliy.Image = ((System.Drawing.Image)(resources.GetObject("btnFamiliy.Image")));
            this.btnFamiliy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamiliy.Location = new System.Drawing.Point(3, 418);
            this.btnFamiliy.Name = "btnFamiliy";
            this.btnFamiliy.Size = new System.Drawing.Size(255, 40);
            this.btnFamiliy.TabIndex = 11;
            this.btnFamiliy.Text = "  Familias";
            this.btnFamiliy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFamiliy.UseVisualStyleBackColor = true;
            this.btnFamiliy.Click += new System.EventHandler(this.BtnFamily_Click);
            // 
            // btnStore
            // 
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Location = new System.Drawing.Point(3, 188);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(255, 40);
            this.btnStore.TabIndex = 6;
            this.btnStore.Text = "  Almacenes";
            this.btnStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(183)))));
            this.plMenu.Controls.Add(this.plStore);
            this.plMenu.Controls.Add(this.panel19);
            this.plMenu.Controls.Add(this.btnBack);
            this.plMenu.Controls.Add(this.plSubmenuM);
            this.plMenu.Controls.Add(this.panel5);
            this.plMenu.Controls.Add(this.panel10);
            this.plMenu.Controls.Add(this.panel3);
            this.plMenu.Controls.Add(this.panel11);
            this.plMenu.Controls.Add(this.panel6);
            this.plMenu.Controls.Add(this.panel12);
            this.plMenu.Controls.Add(this.panel2);
            this.plMenu.Controls.Add(this.panel7);
            this.plMenu.Controls.Add(this.panel4);
            this.plMenu.Controls.Add(this.panel8);
            this.plMenu.Controls.Add(this.panel1);
            this.plMenu.Controls.Add(this.btnInventory);
            this.plMenu.Controls.Add(this.btnAdjust);
            this.plMenu.Controls.Add(this.btnDisconnect);
            this.plMenu.Controls.Add(this.btnStore);
            this.plMenu.Controls.Add(this.btnFamiliy);
            this.plMenu.Controls.Add(this.btnBrand);
            this.plMenu.Controls.Add(this.btnGUser);
            this.plMenu.Controls.Add(this.btnCategory);
            this.plMenu.Controls.Add(this.btnReport);
            this.plMenu.Controls.Add(this.btnSupplier);
            this.plMenu.Controls.Add(this.btnTool);
            this.plMenu.Controls.Add(this.btnMaterial);
            this.plMenu.Controls.Add(this.btnWorkOrder);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 38);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(255, 710);
            this.plMenu.TabIndex = 1;
            // 
            // plStore
            // 
            this.plStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(117)))));
            this.plStore.Controls.Add(this.panel9);
            this.plStore.Controls.Add(this.btnSearchStore);
            this.plStore.Controls.Add(this.btnTransfer);
            this.plStore.Controls.Add(this.panel20);
            this.plStore.Location = new System.Drawing.Point(37, 228);
            this.plStore.Name = "plStore";
            this.plStore.Size = new System.Drawing.Size(218, 86);
            this.plStore.TabIndex = 1;
            this.plStore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlStore_MouseDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 40);
            this.panel9.TabIndex = 10;
            // 
            // btnSearchStore
            // 
            this.btnSearchStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnSearchStore.FlatAppearance.BorderSize = 0;
            this.btnSearchStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnSearchStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStore.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStore.ForeColor = System.Drawing.Color.White;
            this.btnSearchStore.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchStore.Image")));
            this.btnSearchStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchStore.Location = new System.Drawing.Point(6, 3);
            this.btnSearchStore.Name = "btnSearchStore";
            this.btnSearchStore.Size = new System.Drawing.Size(156, 40);
            this.btnSearchStore.TabIndex = 9;
            this.btnSearchStore.Text = "  Buscar";
            this.btnSearchStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchStore.UseVisualStyleBackColor = true;
            this.btnSearchStore.Click += new System.EventHandler(this.BtnSearchStore_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(6, 46);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(156, 40);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "  Traslados";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel20.Location = new System.Drawing.Point(0, 46);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(5, 40);
            this.panel20.TabIndex = 7;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel19.Location = new System.Drawing.Point(0, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(5, 40);
            this.panel19.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(3, 50);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 40);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = " Inicio";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // plSubmenuM
            // 
            this.plSubmenuM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(117)))));
            this.plSubmenuM.Controls.Add(this.panel13);
            this.plSubmenuM.Controls.Add(this.panel14);
            this.plSubmenuM.Controls.Add(this.btnUnit);
            this.plSubmenuM.Controls.Add(this.btnSearchM);
            this.plSubmenuM.Location = new System.Drawing.Point(40, 320);
            this.plSubmenuM.Name = "plSubmenuM";
            this.plSubmenuM.Size = new System.Drawing.Size(218, 92);
            this.plSubmenuM.TabIndex = 0;
            this.plSubmenuM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlSubmenuM_MouseDown);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 40);
            this.panel13.TabIndex = 6;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel14.Location = new System.Drawing.Point(0, 44);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 40);
            this.panel14.TabIndex = 7;
            // 
            // btnUnit
            // 
            this.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnUnit.FlatAppearance.BorderSize = 0;
            this.btnUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnUnit.Image")));
            this.btnUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnit.Location = new System.Drawing.Point(5, 44);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(156, 42);
            this.btnUnit.TabIndex = 5;
            this.btnUnit.Text = "  Unidades";
            this.btnUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.BtnUnit_Click);
            // 
            // btnSearchM
            // 
            this.btnSearchM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnSearchM.FlatAppearance.BorderSize = 0;
            this.btnSearchM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnSearchM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchM.ForeColor = System.Drawing.Color.White;
            this.btnSearchM.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchM.Image")));
            this.btnSearchM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchM.Location = new System.Drawing.Point(5, 0);
            this.btnSearchM.Name = "btnSearchM";
            this.btnSearchM.Size = new System.Drawing.Size(156, 40);
            this.btnSearchM.TabIndex = 3;
            this.btnSearchM.Text = "  Buscar";
            this.btnSearchM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchM.UseVisualStyleBackColor = true;
            this.btnSearchM.Click += new System.EventHandler(this.BtnSearchM_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel5.Location = new System.Drawing.Point(0, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel10.Location = new System.Drawing.Point(0, 510);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 40);
            this.panel10.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(0, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel11.Location = new System.Drawing.Point(0, 556);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 40);
            this.panel11.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel6.Location = new System.Drawing.Point(0, 326);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 40);
            this.panel6.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel12.Location = new System.Drawing.Point(0, 464);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 40);
            this.panel12.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel7.Location = new System.Drawing.Point(0, 372);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 40);
            this.panel7.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel4.Location = new System.Drawing.Point(0, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel8.Location = new System.Drawing.Point(0, 280);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 40);
            this.panel8.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(3, 96);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(289, 40);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "  Inventario";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.Location = new System.Drawing.Point(9, 656);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(38, 42);
            this.btnDisconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.TabStop = false;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // btnGUser
            // 
            this.btnGUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btnGUser.FlatAppearance.BorderSize = 0;
            this.btnGUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(50)))), ((int)(((byte)(161)))));
            this.btnGUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUser.ForeColor = System.Drawing.Color.White;
            this.btnGUser.Image = ((System.Drawing.Image)(resources.GetObject("btnGUser.Image")));
            this.btnGUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGUser.Location = new System.Drawing.Point(3, 556);
            this.btnGUser.Name = "btnGUser";
            this.btnGUser.Size = new System.Drawing.Size(255, 40);
            this.btnGUser.TabIndex = 9;
            this.btnGUser.Text = "  Usuarios";
            this.btnGUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUser.UseVisualStyleBackColor = true;
            this.btnGUser.Click += new System.EventHandler(this.BtnGUser_Click);
            // 
            // tmHideMenu
            // 
            this.tmHideMenu.Tick += new System.EventHandler(this.TmHideMenu_Tick);
            // 
            // tmShowMenu
            // 
            this.tmShowMenu.Tick += new System.EventHandler(this.TmShowMenu_Tick);
            // 
            // tmHourDate
            // 
            this.tmHourDate.Enabled = true;
            this.tmHourDate.Tick += new System.EventHandler(this.TmHourDate_Tick);
            // 
            // plUser
            // 
            this.plUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(117)))));
            this.plUser.Controls.Add(this.btnUser);
            this.plUser.Controls.Add(this.lblNombre);
            this.plUser.Controls.Add(this.lblApellidos);
            this.plUser.Controls.Add(this.lblCargo);
            this.plUser.Controls.Add(this.lblHora);
            this.plUser.Controls.Add(this.lblFecha);
            this.plUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plUser.Location = new System.Drawing.Point(255, 648);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(739, 100);
            this.plUser.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(27, 16);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(77, 72);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 3;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(110, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(110, 23);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 17);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(110, 64);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(516, 11);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(109, 47);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "hora";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(445, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "fecha";
            // 
            // plPrincipal
            // 
            this.plPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.plPrincipal.Controls.Add(this.plContent);
            this.plPrincipal.Controls.Add(this.plUser);
            this.plPrincipal.Controls.Add(this.plMenu);
            this.plPrincipal.Controls.Add(this.plBar);
            this.plPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPrincipal.Location = new System.Drawing.Point(0, 0);
            this.plPrincipal.Name = "plPrincipal";
            this.plPrincipal.Size = new System.Drawing.Size(994, 748);
            this.plPrincipal.TabIndex = 4;
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(255, 38);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(739, 610);
            this.plContent.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 748);
            this.Controls.Add(this.plPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 720);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.plBar.ResumeLayout(false);
            this.plBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjust)).EndInit();
            this.plMenu.ResumeLayout(false);
            this.plStore.ResumeLayout(false);
            this.plSubmenuM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDisconnect)).EndInit();
            this.plUser.ResumeLayout(false);
            this.plUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            this.plPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.Button btnWorkOrder;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnFamiliy;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Button btnGUser;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnDisconnect;
        private System.Windows.Forms.PictureBox btnAdjust;
        private System.Windows.Forms.Timer tmHideMenu;
        private System.Windows.Forms.Timer tmShowMenu;
        private System.Windows.Forms.Timer tmHourDate;
        private System.Windows.Forms.Panel plUser;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox btnUser;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel plPrincipal;
        private System.Windows.Forms.Panel plContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel plSubmenuM;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnSearchM;
        private System.Windows.Forms.Panel plStore;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSearchStore;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Panel panel19;
        public System.Windows.Forms.Label lblCargo;
    }
}