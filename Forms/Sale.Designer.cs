namespace SmartStock.Forms
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.drpdwnCustomerName = new System.Windows.Forms.ComboBox();
            this.txtSoldBy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.drpdwnPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnConfirmSell = new System.Windows.Forms.Button();
            this.datetimeSale = new System.Windows.Forms.DateTimePicker();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.drpdwnProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.lblInoiceNoForBill = new System.Windows.Forms.Label();
            this.lblPaymentMethodForBill = new System.Windows.Forms.Label();
            this.lblSubTotalForBill = new System.Windows.Forms.Label();
            this.lblTotalDiscountForBill = new System.Windows.Forms.Label();
            this.lblTotalPayableForBill = new System.Windows.Forms.Label();
            this.lblCutomerNameForBill = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlSalesumm = new System.Windows.Forms.Panel();
            this.grpBillSummary = new System.Windows.Forms.GroupBox();
            this.BillPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BillPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grounboxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.pnlSalesumm.SuspendLayout();
            this.grpBillSummary.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.drpdwnCustomerName);
            this.grounboxAddCategory.Controls.Add(this.txtSoldBy);
            this.grounboxAddCategory.Controls.Add(this.label17);
            this.grounboxAddCategory.Controls.Add(this.label2);
            this.grounboxAddCategory.Controls.Add(this.txtInvoice);
            this.grounboxAddCategory.Controls.Add(this.label9);
            this.grounboxAddCategory.Controls.Add(this.drpdwnPaymentMethod);
            this.grounboxAddCategory.Controls.Add(this.btnConfirmSell);
            this.grounboxAddCategory.Controls.Add(this.datetimeSale);
            this.grounboxAddCategory.Controls.Add(this.btnAddMore);
            this.grounboxAddCategory.Controls.Add(this.txtTotalCost);
            this.grounboxAddCategory.Controls.Add(this.txtDiscount);
            this.grounboxAddCategory.Controls.Add(this.txtUnitPrice);
            this.grounboxAddCategory.Controls.Add(this.txtQuantity);
            this.grounboxAddCategory.Controls.Add(this.drpdwnProduct);
            this.grounboxAddCategory.Controls.Add(this.label8);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Controls.Add(this.lblprice);
            this.grounboxAddCategory.Controls.Add(this.label7);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label4);
            this.grounboxAddCategory.Controls.Add(this.label6);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Location = new System.Drawing.Point(43, 11);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(983, 245);
            this.grounboxAddCategory.TabIndex = 15;
            this.grounboxAddCategory.TabStop = false;
            // 
            // drpdwnCustomerName
            // 
            this.drpdwnCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnCustomerName.FormattingEnabled = true;
            this.drpdwnCustomerName.Location = new System.Drawing.Point(503, 125);
            this.drpdwnCustomerName.Name = "drpdwnCustomerName";
            this.drpdwnCustomerName.Size = new System.Drawing.Size(210, 38);
            this.drpdwnCustomerName.TabIndex = 20;
            this.drpdwnCustomerName.SelectedIndexChanged += new System.EventHandler(this.drpdwnCustomerName_SelectedIndexChanged);
            this.drpdwnCustomerName.MouseEnter += new System.EventHandler(this.drpdwnCustomerName_MouseEnter);
            this.drpdwnCustomerName.MouseLeave += new System.EventHandler(this.drpdwnCustomerName_MouseEnter);
            // 
            // txtSoldBy
            // 
            this.txtSoldBy.BackColor = System.Drawing.Color.White;
            this.txtSoldBy.Enabled = false;
            this.txtSoldBy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoldBy.Location = new System.Drawing.Point(262, 187);
            this.txtSoldBy.Name = "txtSoldBy";
            this.txtSoldBy.ReadOnly = true;
            this.txtSoldBy.Size = new System.Drawing.Size(210, 35);
            this.txtSoldBy.TabIndex = 19;
            this.txtSoldBy.MouseEnter += new System.EventHandler(this.txtSoldBy_MouseEnter);
            this.txtSoldBy.MouseLeave += new System.EventHandler(this.txtSoldBy_MouseLeave);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(260, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Sold By";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sale";
            // 
            // txtInvoice
            // 
            this.txtInvoice.BackColor = System.Drawing.Color.White;
            this.txtInvoice.Enabled = false;
            this.txtInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.Location = new System.Drawing.Point(26, 188);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(210, 35);
            this.txtInvoice.TabIndex = 11;
            this.txtInvoice.MouseEnter += new System.EventHandler(this.txtInvoice_MouseEnter);
            this.txtInvoice.MouseLeave += new System.EventHandler(this.txtInvoice_MouseLeave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Invoice";
            // 
            // drpdwnPaymentMethod
            // 
            this.drpdwnPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnPaymentMethod.FormattingEnabled = true;
            this.drpdwnPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit card",
            "Online payment"});
            this.drpdwnPaymentMethod.Location = new System.Drawing.Point(744, 125);
            this.drpdwnPaymentMethod.Name = "drpdwnPaymentMethod";
            this.drpdwnPaymentMethod.Size = new System.Drawing.Size(210, 38);
            this.drpdwnPaymentMethod.TabIndex = 5;
            this.drpdwnPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.drpdwnPaymentMethod_SelectedIndexChanged);
            this.drpdwnPaymentMethod.MouseEnter += new System.EventHandler(this.drpdwnPaymentMethod_MouseEnter);
            this.drpdwnPaymentMethod.MouseLeave += new System.EventHandler(this.drpdwnPaymentMethod_MouseLeave);
            // 
            // btnConfirmSell
            // 
            this.btnConfirmSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmSell.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConfirmSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSell.Location = new System.Drawing.Point(744, 185);
            this.btnConfirmSell.Name = "btnConfirmSell";
            this.btnConfirmSell.Size = new System.Drawing.Size(117, 37);
            this.btnConfirmSell.TabIndex = 7;
            this.btnConfirmSell.Text = "Confirm Sell";
            this.btnConfirmSell.UseVisualStyleBackColor = false;
            this.btnConfirmSell.Click += new System.EventHandler(this.btnConfirmSell_Click);
            // 
            // datetimeSale
            // 
            this.datetimeSale.Enabled = false;
            this.datetimeSale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSale.Location = new System.Drawing.Point(262, 122);
            this.datetimeSale.Margin = new System.Windows.Forms.Padding(9);
            this.datetimeSale.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeSale.Name = "datetimeSale";
            this.datetimeSale.Size = new System.Drawing.Size(210, 35);
            this.datetimeSale.TabIndex = 14;
            this.datetimeSale.Value = new System.DateTime(2025, 3, 12, 16, 9, 9, 0);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddMore.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMore.Location = new System.Drawing.Point(503, 185);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(117, 37);
            this.btnAddMore.TabIndex = 6;
            this.btnAddMore.Text = "More?";
            this.btnAddMore.UseVisualStyleBackColor = false;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.White;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(26, 122);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(210, 35);
            this.txtTotalCost.TabIndex = 12;
            this.txtTotalCost.MouseEnter += new System.EventHandler(this.txtTotalCost_MouseEnter);
            this.txtTotalCost.MouseLeave += new System.EventHandler(this.txtTotalCost_MouseLeave);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(744, 53);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(210, 35);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.MouseEnter += new System.EventHandler(this.txtDiscount_MouseEnter);
            this.txtDiscount.MouseLeave += new System.EventHandler(this.txtDiscount_MouseLeave);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(503, 51);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 35);
            this.txtUnitPrice.TabIndex = 2;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            this.txtUnitPrice.MouseEnter += new System.EventHandler(this.txtUnitPrice_MouseEnter);
            this.txtUnitPrice.MouseLeave += new System.EventHandler(this.txtUnitPrice_MouseLeave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(262, 51);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 35);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.ValueChanged += new System.EventHandler(this.txtQuantity_ValueChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // drpdwnProduct
            // 
            this.drpdwnProduct.BackColor = System.Drawing.Color.White;
            this.drpdwnProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnProduct.FormattingEnabled = true;
            this.drpdwnProduct.Location = new System.Drawing.Point(26, 48);
            this.drpdwnProduct.Name = "drpdwnProduct";
            this.drpdwnProduct.Size = new System.Drawing.Size(210, 38);
            this.drpdwnProduct.TabIndex = 0;
            this.drpdwnProduct.MouseEnter += new System.EventHandler(this.drpdwnProduct_MouseEnter);
            this.drpdwnProduct.MouseLeave += new System.EventHandler(this.drpdwnProduct_MouseLeave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // lblprice
            // 
            this.lblprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(260, 24);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(77, 21);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discount (in %)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sale Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.grounboxAddCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 274);
            this.panel1.TabIndex = 6;
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSale.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(0, 0);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowTemplate.Height = 42;
            this.dgvSale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSale.Size = new System.Drawing.Size(570, 334);
            this.dgvSale.TabIndex = 7;
            // 
            // btnClearBill
            // 
            this.btnClearBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearBill.BackColor = System.Drawing.Color.Teal;
            this.btnClearBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBill.Location = new System.Drawing.Point(120, 235);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(66, 39);
            this.btnClearBill.TabIndex = 9;
            this.btnClearBill.Text = "Clear";
            this.btnClearBill.UseVisualStyleBackColor = false;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrintBill.BackColor = System.Drawing.Color.Teal;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(21, 235);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(69, 39);
            this.btnPrintBill.TabIndex = 8;
            this.btnPrintBill.Text = "Print";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // lblInoiceNoForBill
            // 
            this.lblInoiceNoForBill.AutoSize = true;
            this.lblInoiceNoForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInoiceNoForBill.Location = new System.Drawing.Point(196, 76);
            this.lblInoiceNoForBill.Name = "lblInoiceNoForBill";
            this.lblInoiceNoForBill.Size = new System.Drawing.Size(16, 21);
            this.lblInoiceNoForBill.TabIndex = 14;
            this.lblInoiceNoForBill.Text = "-";
            // 
            // lblPaymentMethodForBill
            // 
            this.lblPaymentMethodForBill.AutoSize = true;
            this.lblPaymentMethodForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethodForBill.Location = new System.Drawing.Point(196, 109);
            this.lblPaymentMethodForBill.Name = "lblPaymentMethodForBill";
            this.lblPaymentMethodForBill.Size = new System.Drawing.Size(16, 21);
            this.lblPaymentMethodForBill.TabIndex = 13;
            this.lblPaymentMethodForBill.Text = "-";
            // 
            // lblSubTotalForBill
            // 
            this.lblSubTotalForBill.AutoSize = true;
            this.lblSubTotalForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalForBill.Location = new System.Drawing.Point(196, 141);
            this.lblSubTotalForBill.Name = "lblSubTotalForBill";
            this.lblSubTotalForBill.Size = new System.Drawing.Size(16, 21);
            this.lblSubTotalForBill.TabIndex = 12;
            this.lblSubTotalForBill.Text = "-";
            // 
            // lblTotalDiscountForBill
            // 
            this.lblTotalDiscountForBill.AutoSize = true;
            this.lblTotalDiscountForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscountForBill.Location = new System.Drawing.Point(196, 171);
            this.lblTotalDiscountForBill.Name = "lblTotalDiscountForBill";
            this.lblTotalDiscountForBill.Size = new System.Drawing.Size(16, 21);
            this.lblTotalDiscountForBill.TabIndex = 11;
            this.lblTotalDiscountForBill.Text = "-";
            // 
            // lblTotalPayableForBill
            // 
            this.lblTotalPayableForBill.AutoSize = true;
            this.lblTotalPayableForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayableForBill.Location = new System.Drawing.Point(196, 201);
            this.lblTotalPayableForBill.Name = "lblTotalPayableForBill";
            this.lblTotalPayableForBill.Size = new System.Drawing.Size(16, 21);
            this.lblTotalPayableForBill.TabIndex = 10;
            this.lblTotalPayableForBill.Text = "-";
            // 
            // lblCutomerNameForBill
            // 
            this.lblCutomerNameForBill.AutoSize = true;
            this.lblCutomerNameForBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutomerNameForBill.Location = new System.Drawing.Point(196, 39);
            this.lblCutomerNameForBill.Name = "lblCutomerNameForBill";
            this.lblCutomerNameForBill.Size = new System.Drawing.Size(16, 21);
            this.lblCutomerNameForBill.TabIndex = 9;
            this.lblCutomerNameForBill.Text = "-";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 26);
            this.label16.TabIndex = 8;
            this.label16.Text = "Invoice No:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 26);
            this.label15.TabIndex = 7;
            this.label15.Text = "Payment Method:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "Subtotal:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Discount:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 26);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total Payable:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Customer Name:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, -7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "Billing Summary";
            // 
            // pnlSalesumm
            // 
            this.pnlSalesumm.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSalesumm.Controls.Add(this.grpBillSummary);
            this.pnlSalesumm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSalesumm.Location = new System.Drawing.Point(570, 274);
            this.pnlSalesumm.Name = "pnlSalesumm";
            this.pnlSalesumm.Size = new System.Drawing.Size(500, 334);
            this.pnlSalesumm.TabIndex = 8;
            // 
            // grpBillSummary
            // 
            this.grpBillSummary.Controls.Add(this.btnClearBill);
            this.grpBillSummary.Controls.Add(this.label10);
            this.grpBillSummary.Controls.Add(this.btnPrintBill);
            this.grpBillSummary.Controls.Add(this.label11);
            this.grpBillSummary.Controls.Add(this.lblTotalDiscountForBill);
            this.grpBillSummary.Controls.Add(this.lblPaymentMethodForBill);
            this.grpBillSummary.Controls.Add(this.lblTotalPayableForBill);
            this.grpBillSummary.Controls.Add(this.lblInoiceNoForBill);
            this.grpBillSummary.Controls.Add(this.label13);
            this.grpBillSummary.Controls.Add(this.label12);
            this.grpBillSummary.Controls.Add(this.lblSubTotalForBill);
            this.grpBillSummary.Controls.Add(this.label16);
            this.grpBillSummary.Controls.Add(this.lblCutomerNameForBill);
            this.grpBillSummary.Controls.Add(this.label15);
            this.grpBillSummary.Controls.Add(this.label14);
            this.grpBillSummary.Location = new System.Drawing.Point(12, 10);
            this.grpBillSummary.Name = "grpBillSummary";
            this.grpBillSummary.Size = new System.Drawing.Size(476, 291);
            this.grpBillSummary.TabIndex = 0;
            this.grpBillSummary.TabStop = false;
            // 
            // BillPrintPreviewDialog
            // 
            this.BillPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BillPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BillPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BillPrintPreviewDialog.Enabled = true;
            this.BillPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BillPrintPreviewDialog.Icon")));
            this.BillPrintPreviewDialog.Name = "BillPrintPreviewDialog";
            this.BillPrintPreviewDialog.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 334);
            this.panel2.TabIndex = 9;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSalesumm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 566);
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Load);
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.pnlSalesumm.ResumeLayout(false);
            this.grpBillSummary.ResumeLayout(false);
            this.grpBillSummary.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirmSell;
        private System.Windows.Forms.DateTimePicker datetimeSale;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.ComboBox drpdwnProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label lblInoiceNoForBill;
        private System.Windows.Forms.Label lblPaymentMethodForBill;
        private System.Windows.Forms.Label lblSubTotalForBill;
        private System.Windows.Forms.Label lblTotalDiscountForBill;
        private System.Windows.Forms.Label lblTotalPayableForBill;
        private System.Windows.Forms.Label lblCutomerNameForBill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlSalesumm;
        private System.Windows.Forms.GroupBox grpBillSummary;
        private System.Windows.Forms.PrintPreviewDialog BillPrintPreviewDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument BillPrintDocument;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox drpdwnCustomerName;
        private System.Windows.Forms.TextBox txtSoldBy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox drpdwnPaymentMethod;
        private System.Windows.Forms.Label label4;
    }
}