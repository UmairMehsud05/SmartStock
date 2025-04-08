namespace SmartStock.Forms
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.drpdwnCity = new System.Windows.Forms.ComboBox();
            this.drpdwnCustomerType = new System.Windows.Forms.ComboBox();
            this.datetimeRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnCustomerSearch = new System.Windows.Forms.PictureBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.grounboxAddCategory.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerSearch)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.grounboxAddCategory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1070, 287);
            this.pnlTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 50);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer";
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.drpdwnCity);
            this.grounboxAddCategory.Controls.Add(this.drpdwnCustomerType);
            this.grounboxAddCategory.Controls.Add(this.datetimeRegistrationDate);
            this.grounboxAddCategory.Controls.Add(this.txtAddress);
            this.grounboxAddCategory.Controls.Add(this.txtEmail);
            this.grounboxAddCategory.Controls.Add(this.txtContact);
            this.grounboxAddCategory.Controls.Add(this.txtCustomerName);
            this.grounboxAddCategory.Controls.Add(this.label7);
            this.grounboxAddCategory.Controls.Add(this.label6);
            this.grounboxAddCategory.Controls.Add(this.label4);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Controls.Add(this.lblprice);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Controls.Add(this.btnAddCustomer);
            this.grounboxAddCategory.Location = new System.Drawing.Point(67, 33);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(937, 220);
            this.grounboxAddCategory.TabIndex = 10;
            this.grounboxAddCategory.TabStop = false;
            // 
            // drpdwnCity
            // 
            this.drpdwnCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpdwnCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpdwnCity.BackColor = System.Drawing.Color.White;
            this.drpdwnCity.DropDownHeight = 150;
            this.drpdwnCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnCity.DropDownWidth = 200;
            this.drpdwnCity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnCity.FormattingEnabled = true;
            this.drpdwnCity.IntegralHeight = false;
            this.drpdwnCity.Items.AddRange(new object[] {
            "Select City",
            "Abbottabad",
            "Attock",
            "Bahawalnagar",
            "Bahawalpur",
            "Bannu",
            "Bhakkar",
            "Chakwal",
            "Chaman",
            "Charsadda",
            "Chiniot",
            "Dadu",
            "Dera Ghazi Khan",
            "Dera Ismail Khan",
            "Faisalabad",
            "Ghotki",
            "Gilgit",
            "Gojra",
            "Gwadar",
            "Gujranwala",
            "Gujrat",
            "Hafizabad",
            "Hyderabad",
            "Islamabad",
            "Jacobabad",
            "Jhang",
            "Jhelum",
            "Kamoke",
            "Karachi",
            "Kasur",
            "Khairpur",
            "Khanewal",
            "Khanpur",
            "Khuzdar",
            "Kohat",
            "Kot Adu",
            "Lahore",
            "Larkana",
            "Mandi Bahauddin",
            "Mansehra",
            "Mardan",
            "Mingora",
            "Mirpur (AJK)",
            "Mirpur Khas",
            "Multan",
            "Muzaffarabad",
            "Muzaffargarh",
            "Nawabshah",
            "Nowshera",
            "Okara",
            "Pakpattan",
            "Peshawar",
            "Quetta",
            "Rahim Yar Khan",
            "Rawalpindi",
            "Sadiqabad",
            "Sahiwal",
            "Sanghar",
            "Sargodha",
            "Sheikhupura",
            "Shikarpur",
            "Sialkot",
            "Sukkur",
            "Swabi",
            "Swat",
            "Tando Adam",
            "Tando Allahyar",
            "Turbat",
            "Vehari",
            "Wah Cantt"});
            this.drpdwnCity.Location = new System.Drawing.Point(33, 137);
            this.drpdwnCity.Name = "drpdwnCity";
            this.drpdwnCity.Size = new System.Drawing.Size(210, 38);
            this.drpdwnCity.TabIndex = 4;
            this.drpdwnCity.MouseEnter += new System.EventHandler(this.drpdwnCity_MouseEnter);
            this.drpdwnCity.MouseLeave += new System.EventHandler(this.drpdwnCity_MouseLeave);
            // 
            // drpdwnCustomerType
            // 
            this.drpdwnCustomerType.BackColor = System.Drawing.Color.White;
            this.drpdwnCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnCustomerType.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnCustomerType.FormattingEnabled = true;
            this.drpdwnCustomerType.Items.AddRange(new object[] {
            "Regular",
            "WholeSale",
            "VIP"});
            this.drpdwnCustomerType.Location = new System.Drawing.Point(248, 137);
            this.drpdwnCustomerType.Name = "drpdwnCustomerType";
            this.drpdwnCustomerType.Size = new System.Drawing.Size(210, 38);
            this.drpdwnCustomerType.TabIndex = 5;
            this.drpdwnCustomerType.MouseEnter += new System.EventHandler(this.drpdwnCustomerType_MouseEnter);
            this.drpdwnCustomerType.MouseLeave += new System.EventHandler(this.drpdwnCustomerType_MouseLeave);
            // 
            // datetimeRegistrationDate
            // 
            this.datetimeRegistrationDate.Enabled = false;
            this.datetimeRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeRegistrationDate.Location = new System.Drawing.Point(468, 140);
            this.datetimeRegistrationDate.Margin = new System.Windows.Forms.Padding(9);
            this.datetimeRegistrationDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeRegistrationDate.Name = "datetimeRegistrationDate";
            this.datetimeRegistrationDate.Size = new System.Drawing.Size(210, 35);
            this.datetimeRegistrationDate.TabIndex = 0;
            this.datetimeRegistrationDate.Value = new System.DateTime(2025, 3, 12, 16, 9, 9, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(702, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 46);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "";
            this.txtAddress.MouseEnter += new System.EventHandler(this.txtAddress_MouseEnter);
            this.txtAddress.MouseLeave += new System.EventHandler(this.txtAddress_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(469, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.MouseEnter += new System.EventHandler(this.txtEmail_MouseEnter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(253, 60);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(210, 35);
            this.txtContact.TabIndex = 1;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            this.txtContact.MouseEnter += new System.EventHandler(this.txtContact_MouseEnter);
            this.txtContact.MouseLeave += new System.EventHandler(this.txtContact_MouseLeave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(35, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(210, 35);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtCustomerName.MouseEnter += new System.EventHandler(this.txtCustomerName_MouseEnter);
            this.txtCustomerName.MouseLeave += new System.EventHandler(this.txtCustomerName_MouseLeave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Customer Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registration Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // lblprice
            // 
            this.lblprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(251, 36);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(69, 21);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Contact";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCustomer.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(702, 130);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(113, 45);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMiddle.Controls.Add(this.btnCustomerSearch);
            this.pnlMiddle.Controls.Add(this.txtCustomerSearch);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 287);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1070, 94);
            this.pnlMiddle.TabIndex = 1;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerSearch.Image = global::SmartStock.Properties.Resources.searchicon;
            this.btnCustomerSearch.Location = new System.Drawing.Point(629, 34);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(43, 34);
            this.btnCustomerSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomerSearch.TabIndex = 7;
            this.btnCustomerSearch.TabStop = false;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(398, 33);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(274, 35);
            this.txtCustomerSearch.TabIndex = 7;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBottom.Controls.Add(this.dgvCustomer);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 381);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1070, 227);
            this.pnlBottom.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.RowTemplate.Height = 42;
            this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomer.Size = new System.Drawing.Size(1070, 227);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvCustomer_Paint);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 526);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerSearch)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.ComboBox drpdwnCity;
        private System.Windows.Forms.ComboBox drpdwnCustomerType;
        private System.Windows.Forms.DateTimePicker datetimeRegistrationDate;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}