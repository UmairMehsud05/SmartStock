namespace SmartStock.Forms
{
    partial class Main
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.drpdwnForLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.drpdwnForSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.drpdwnForProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.drpdwnForUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenuForDropDownList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblForCompanyName = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.lblSetting = new System.Windows.Forms.Label();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnSuppliers = new FontAwesome.Sharp.IconButton();
            this.btnCategories = new FontAwesome.Sharp.IconButton();
            this.btnPurchase = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.lblInventoryAndStock = new System.Windows.Forms.Label();
            this.btnTransaction = new FontAwesome.Sharp.IconButton();
            this.btnSaleReports = new FontAwesome.Sharp.IconButton();
            this.btnSalesHistory = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.lblSalesAndTransaction = new System.Windows.Forms.Label();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.picboxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.contextmenuForDropDownList.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            this.pnlLeftSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfilePicture)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.Color.Silver;
            this.lblProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProfile.Location = new System.Drawing.Point(0, 143);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(213, 37);
            this.lblProfile.TabIndex = 7;
            this.lblProfile.Text = "👤  PROFILE";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.Silver;
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDashboard.Location = new System.Drawing.Point(0, 53);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(213, 37);
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "📊   DASHBOARD";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drpdwnForLogOut
            // 
            this.drpdwnForLogOut.BackColor = System.Drawing.Color.Teal;
            this.drpdwnForLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForLogOut.ForeColor = System.Drawing.Color.Black;
            this.drpdwnForLogOut.Name = "drpdwnForLogOut";
            this.drpdwnForLogOut.Size = new System.Drawing.Size(200, 26);
            this.drpdwnForLogOut.Text = "Logout";
            this.drpdwnForLogOut.Click += new System.EventHandler(this.drpdwnForLogOut_Click);
            // 
            // drpdwnForSetting
            // 
            this.drpdwnForSetting.BackColor = System.Drawing.Color.Teal;
            this.drpdwnForSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForSetting.ForeColor = System.Drawing.Color.Black;
            this.drpdwnForSetting.Name = "drpdwnForSetting";
            this.drpdwnForSetting.Size = new System.Drawing.Size(200, 26);
            this.drpdwnForSetting.Text = "Setting";
            this.drpdwnForSetting.Click += new System.EventHandler(this.drpdwnForSetting_Click);
            // 
            // drpdwnForProfile
            // 
            this.drpdwnForProfile.BackColor = System.Drawing.Color.Teal;
            this.drpdwnForProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForProfile.ForeColor = System.Drawing.Color.Black;
            this.drpdwnForProfile.Name = "drpdwnForProfile";
            this.drpdwnForProfile.Size = new System.Drawing.Size(200, 26);
            this.drpdwnForProfile.Text = "Profile";
            this.drpdwnForProfile.Click += new System.EventHandler(this.drpdwnForProfile_Click);
            // 
            // drpdwnForUserName
            // 
            this.drpdwnForUserName.BackColor = System.Drawing.Color.LightBlue;
            this.drpdwnForUserName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForUserName.Name = "drpdwnForUserName";
            this.drpdwnForUserName.Size = new System.Drawing.Size(200, 26);
            this.drpdwnForUserName.Text = "User Name Here";
            // 
            // contextmenuForDropDownList
            // 
            this.contextmenuForDropDownList.BackColor = System.Drawing.Color.Transparent;
            this.contextmenuForDropDownList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextmenuForDropDownList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drpdwnForUserName,
            this.drpdwnForProfile,
            this.drpdwnForSetting,
            this.drpdwnForLogOut});
            this.contextmenuForDropDownList.Name = "contextmenuForDropDownList";
            this.contextmenuForDropDownList.Size = new System.Drawing.Size(201, 108);
            // 
            // lblForCompanyName
            // 
            this.lblForCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForCompanyName.AutoSize = true;
            this.lblForCompanyName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForCompanyName.ForeColor = System.Drawing.Color.LightBlue;
            this.lblForCompanyName.Location = new System.Drawing.Point(305, 25);
            this.lblForCompanyName.Name = "lblForCompanyName";
            this.lblForCompanyName.Size = new System.Drawing.Size(806, 37);
            this.lblForCompanyName.TabIndex = 4;
            this.lblForCompanyName.Text = "SmartStock - Advanced Inventory & Sales Management System";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.LightBlue;
            this.pnlLogo.Controls.Add(this.picboxForCompanyLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 148);
            this.pnlLogo.TabIndex = 0;
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(0, 0);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(230, 148);
            this.picboxForCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxForCompanyLogo.TabIndex = 1;
            this.picboxForCompanyLogo.TabStop = false;
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.AutoScroll = true;
            this.pnlLeftSide.BackColor = System.Drawing.Color.Teal;
            this.pnlLeftSide.Controls.Add(this.btnExit);
            this.pnlLeftSide.Controls.Add(this.iconButton1);
            this.pnlLeftSide.Controls.Add(this.btnSettings);
            this.pnlLeftSide.Controls.Add(this.lblSetting);
            this.pnlLeftSide.Controls.Add(this.btnCustomers);
            this.pnlLeftSide.Controls.Add(this.lblCustomer);
            this.pnlLeftSide.Controls.Add(this.btnSuppliers);
            this.pnlLeftSide.Controls.Add(this.btnCategories);
            this.pnlLeftSide.Controls.Add(this.btnPurchase);
            this.pnlLeftSide.Controls.Add(this.btnProduct);
            this.pnlLeftSide.Controls.Add(this.lblInventoryAndStock);
            this.pnlLeftSide.Controls.Add(this.btnTransaction);
            this.pnlLeftSide.Controls.Add(this.btnSaleReports);
            this.pnlLeftSide.Controls.Add(this.btnSalesHistory);
            this.pnlLeftSide.Controls.Add(this.btnSales);
            this.pnlLeftSide.Controls.Add(this.lblSalesAndTransaction);
            this.pnlLeftSide.Controls.Add(this.btnProfile);
            this.pnlLeftSide.Controls.Add(this.lblProfile);
            this.pnlLeftSide.Controls.Add(this.btnDashboard);
            this.pnlLeftSide.Controls.Add(this.lblDashboard);
            this.pnlLeftSide.Controls.Add(this.btnMenu);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 148);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(230, 578);
            this.pnlLeftSide.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightBlue;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnExit.IconColor = System.Drawing.Color.LightBlue;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 964);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 53);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Teal;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 911);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(213, 53);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.Text = "Manage User";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Teal;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.IconColor = System.Drawing.Color.LightBlue;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 858);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(213, 53);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblSetting
            // 
            this.lblSetting.BackColor = System.Drawing.Color.Silver;
            this.lblSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSetting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetting.Location = new System.Drawing.Point(0, 821);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(213, 37);
            this.lblSetting.TabIndex = 22;
            this.lblSetting.Text = "⚙️     SETTINGS";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Teal;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.LightBlue;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCustomers.IconColor = System.Drawing.Color.LightBlue;
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 768);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(213, 53);
            this.btnCustomers.TabIndex = 21;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Silver;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCustomer.Location = new System.Drawing.Point(0, 731);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(213, 37);
            this.lblCustomer.TabIndex = 20;
            this.lblCustomer.Text = "👥     CUSTOMERS";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Teal;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSuppliers.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnSuppliers.IconColor = System.Drawing.Color.LightBlue;
            this.btnSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 678);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(213, 53);
            this.btnSuppliers.TabIndex = 19;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Teal;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.LightBlue;
            this.btnCategories.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnCategories.IconColor = System.Drawing.Color.LightBlue;
            this.btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 625);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(213, 53);
            this.btnCategories.TabIndex = 18;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Teal;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.LightBlue;
            this.btnPurchase.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnPurchase.IconColor = System.Drawing.Color.LightBlue;
            this.btnPurchase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(0, 572);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(213, 53);
            this.btnPurchase.TabIndex = 17;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Teal;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.LightBlue;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnProduct.IconColor = System.Drawing.Color.LightBlue;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 519);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(213, 53);
            this.btnProduct.TabIndex = 15;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblInventoryAndStock
            // 
            this.lblInventoryAndStock.BackColor = System.Drawing.Color.Silver;
            this.lblInventoryAndStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventoryAndStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryAndStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInventoryAndStock.Location = new System.Drawing.Point(0, 482);
            this.lblInventoryAndStock.Name = "lblInventoryAndStock";
            this.lblInventoryAndStock.Size = new System.Drawing.Size(213, 37);
            this.lblInventoryAndStock.TabIndex = 14;
            this.lblInventoryAndStock.Text = "📦  INVENTORY & STOCK";
            this.lblInventoryAndStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Teal;
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.LightBlue;
            this.btnTransaction.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnTransaction.IconColor = System.Drawing.Color.LightBlue;
            this.btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 429);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(213, 53);
            this.btnTransaction.TabIndex = 13;
            this.btnTransaction.Text = "      Transactions";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnSaleReports
            // 
            this.btnSaleReports.BackColor = System.Drawing.Color.Teal;
            this.btnSaleReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReports.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSaleReports.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReports.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSaleReports.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnSaleReports.IconColor = System.Drawing.Color.LightBlue;
            this.btnSaleReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaleReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleReports.Location = new System.Drawing.Point(0, 376);
            this.btnSaleReports.Name = "btnSaleReports";
            this.btnSaleReports.Size = new System.Drawing.Size(213, 53);
            this.btnSaleReports.TabIndex = 12;
            this.btnSaleReports.Text = "    Sales Report";
            this.btnSaleReports.UseVisualStyleBackColor = false;
            this.btnSaleReports.Click += new System.EventHandler(this.btnSaleReports_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.BackColor = System.Drawing.Color.Teal;
            this.btnSalesHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSalesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSalesHistory.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnSalesHistory.IconColor = System.Drawing.Color.LightBlue;
            this.btnSalesHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesHistory.Location = new System.Drawing.Point(0, 323);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(213, 53);
            this.btnSalesHistory.TabIndex = 11;
            this.btnSalesHistory.Text = "     Sales History";
            this.btnSalesHistory.UseVisualStyleBackColor = false;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Teal;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnSales.IconColor = System.Drawing.Color.LightBlue;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 270);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(213, 53);
            this.btnSales.TabIndex = 10;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblSalesAndTransaction
            // 
            this.lblSalesAndTransaction.BackColor = System.Drawing.Color.Silver;
            this.lblSalesAndTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesAndTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesAndTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalesAndTransaction.Location = new System.Drawing.Point(0, 233);
            this.lblSalesAndTransaction.Name = "lblSalesAndTransaction";
            this.lblSalesAndTransaction.Size = new System.Drawing.Size(213, 37);
            this.lblSalesAndTransaction.TabIndex = 9;
            this.lblSalesAndTransaction.Text = "🛒    SALES & TRANSACTIONS";
            this.lblSalesAndTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Teal;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.LightBlue;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProfile.IconColor = System.Drawing.Color.LightBlue;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 180);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(213, 53);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Teal;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.LightBlue;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnDashboard.IconColor = System.Drawing.Color.LightBlue;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(213, 53);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.LightBlue;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnMenu.IconColor = System.Drawing.Color.LightBlue;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 40;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(213, 53);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.btnLogOut);
            this.pnlTop.Controls.Add(this.lblWelcomeMessage);
            this.pnlTop.Controls.Add(this.picboxProfilePicture);
            this.pnlTop.Controls.Add(this.lblForCompanyName);
            this.pnlTop.Controls.Add(this.pnlLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1290, 148);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogOut.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(248, 96);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 38);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(571, 102);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(0, 25);
            this.lblWelcomeMessage.TabIndex = 6;
            // 
            // picboxProfilePicture
            // 
            this.picboxProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxProfilePicture.ContextMenuStrip = this.contextmenuForDropDownList;
            this.picboxProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxProfilePicture.Image = global::SmartStock.Properties.Resources.profile_user;
            this.picboxProfilePicture.Location = new System.Drawing.Point(1186, 70);
            this.picboxProfilePicture.Name = "picboxProfilePicture";
            this.picboxProfilePicture.Size = new System.Drawing.Size(92, 72);
            this.picboxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxProfilePicture.TabIndex = 5;
            this.picboxProfilePicture.TabStop = false;
            this.picboxProfilePicture.Click += new System.EventHandler(this.picboxProfilePicture_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlLeftSide);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1290, 726);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 148);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1060, 578);
            this.pnlContent.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 726);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextmenuForDropDownList.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfilePicture)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnProfile;
        private System.Windows.Forms.Label lblProfile;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.ToolStripMenuItem drpdwnForLogOut;
        private System.Windows.Forms.ToolStripMenuItem drpdwnForSetting;
        private System.Windows.Forms.ToolStripMenuItem drpdwnForProfile;
        private System.Windows.Forms.ToolStripMenuItem drpdwnForUserName;
        private System.Windows.Forms.ContextMenuStrip contextmenuForDropDownList;
        private System.Windows.Forms.PictureBox picboxProfilePicture;
        private System.Windows.Forms.Label lblForCompanyName;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Label lblSalesAndTransaction;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnSalesHistory;
        private FontAwesome.Sharp.IconButton btnSaleReports;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private System.Windows.Forms.Label lblInventoryAndStock;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnPurchase;
        private FontAwesome.Sharp.IconButton btnCategories;
        private FontAwesome.Sharp.IconButton btnSuppliers;
        private System.Windows.Forms.Label lblCustomer;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private System.Windows.Forms.Label lblSetting;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button btnLogOut;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}