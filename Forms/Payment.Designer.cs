namespace SmartStock.Forms
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.drpdwnCustomerName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaymentMethodSelectInSale = new System.Windows.Forms.TextBox();
            this.dateTimeTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.drpdwnSaleID = new System.Windows.Forms.ComboBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottomTop = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.grounboxAddCategory.SuspendLayout();
            this.pnlBottomTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1070, 261);
            this.pnlTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transaction";
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.drpdwnCustomerName);
            this.grounboxAddCategory.Controls.Add(this.label8);
            this.grounboxAddCategory.Controls.Add(this.txtTotalAmount);
            this.grounboxAddCategory.Controls.Add(this.label7);
            this.grounboxAddCategory.Controls.Add(this.txtPaymentMethodSelectInSale);
            this.grounboxAddCategory.Controls.Add(this.dateTimeTransactionDate);
            this.grounboxAddCategory.Controls.Add(this.txtPaidAmount);
            this.grounboxAddCategory.Controls.Add(this.txtTransactionID);
            this.grounboxAddCategory.Controls.Add(this.drpdwnSaleID);
            this.grounboxAddCategory.Controls.Add(this.btnAddTransaction);
            this.grounboxAddCategory.Controls.Add(this.label6);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label4);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Location = new System.Drawing.Point(56, 25);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(957, 224);
            this.grounboxAddCategory.TabIndex = 10;
            this.grounboxAddCategory.TabStop = false;
            // 
            // drpdwnCustomerName
            // 
            this.drpdwnCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnCustomerName.FormattingEnabled = true;
            this.drpdwnCustomerName.Location = new System.Drawing.Point(484, 80);
            this.drpdwnCustomerName.Name = "drpdwnCustomerName";
            this.drpdwnCustomerName.Size = new System.Drawing.Size(210, 38);
            this.drpdwnCustomerName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Customer Name";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(29, 161);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(210, 35);
            this.txtTotalAmount.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Amount";
            // 
            // txtPaymentMethodSelectInSale
            // 
            this.txtPaymentMethodSelectInSale.BackColor = System.Drawing.Color.White;
            this.txtPaymentMethodSelectInSale.Enabled = false;
            this.txtPaymentMethodSelectInSale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethodSelectInSale.Location = new System.Drawing.Point(710, 86);
            this.txtPaymentMethodSelectInSale.Name = "txtPaymentMethodSelectInSale";
            this.txtPaymentMethodSelectInSale.ReadOnly = true;
            this.txtPaymentMethodSelectInSale.Size = new System.Drawing.Size(210, 35);
            this.txtPaymentMethodSelectInSale.TabIndex = 20;
            this.txtPaymentMethodSelectInSale.MouseEnter += new System.EventHandler(this.txtPaymentMethodSelectInSale_MouseEnter);
            this.txtPaymentMethodSelectInSale.MouseLeave += new System.EventHandler(this.txtPaymentMethodSelectInSale_MouseLeave);
            // 
            // dateTimeTransactionDate
            // 
            this.dateTimeTransactionDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTransactionDate.Enabled = false;
            this.dateTimeTransactionDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransactionDate.Location = new System.Drawing.Point(484, 161);
            this.dateTimeTransactionDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeTransactionDate.Name = "dateTimeTransactionDate";
            this.dateTimeTransactionDate.Size = new System.Drawing.Size(210, 35);
            this.dateTimeTransactionDate.TabIndex = 11;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(258, 164);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(210, 35);
            this.txtPaidAmount.TabIndex = 3;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            this.txtPaidAmount.MouseEnter += new System.EventHandler(this.txtPaidAmount_MouseEnter);
            this.txtPaidAmount.MouseLeave += new System.EventHandler(this.txtPaidAmount_MouseLeave);
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.BackColor = System.Drawing.Color.White;
            this.txtTransactionID.Enabled = false;
            this.txtTransactionID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionID.Location = new System.Drawing.Point(29, 83);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.Size = new System.Drawing.Size(210, 35);
            this.txtTransactionID.TabIndex = 0;
            this.txtTransactionID.MouseEnter += new System.EventHandler(this.txtTransactionID_MouseEnter);
            this.txtTransactionID.MouseLeave += new System.EventHandler(this.txtTransactionID_MouseLeave);
            // 
            // drpdwnSaleID
            // 
            this.drpdwnSaleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnSaleID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnSaleID.FormattingEnabled = true;
            this.drpdwnSaleID.Location = new System.Drawing.Point(255, 83);
            this.drpdwnSaleID.Name = "drpdwnSaleID";
            this.drpdwnSaleID.Size = new System.Drawing.Size(210, 38);
            this.drpdwnSaleID.TabIndex = 1;
            this.drpdwnSaleID.SelectedIndexChanged += new System.EventHandler(this.drpdwnSaleID_SelectedIndexChanged);
            this.drpdwnSaleID.MouseEnter += new System.EventHandler(this.drpdwnSaleID_MouseEnter);
            this.drpdwnSaleID.MouseLeave += new System.EventHandler(this.drpdwnSaleID_MouseLeave);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTransaction.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Location = new System.Drawing.Point(710, 160);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(97, 36);
            this.btnAddTransaction.TabIndex = 4;
            this.btnAddTransaction.Text = "Add";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transaction Date";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount Paid";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sale ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction ID";
            // 
            // pnlBottomTop
            // 
            this.pnlBottomTop.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBottomTop.Controls.Add(this.btnExportToExcel);
            this.pnlBottomTop.Controls.Add(this.btnExportToPDF);
            this.pnlBottomTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomTop.Location = new System.Drawing.Point(0, 261);
            this.pnlBottomTop.Name = "pnlBottomTop";
            this.pnlBottomTop.Size = new System.Drawing.Size(1070, 82);
            this.pnlBottomTop.TabIndex = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(540, 23);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(139, 45);
            this.btnExportToExcel.TabIndex = 6;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.BackColor = System.Drawing.Color.Teal;
            this.btnExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(377, 23);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(144, 45);
            this.btnExportToPDF.TabIndex = 5;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = false;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.dgvTransactionHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 265);
            this.panel1.TabIndex = 2;
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.AllowUserToAddRows = false;
            this.dgvTransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionHistory.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactionHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.RowTemplate.Height = 42;
            this.dgvTransactionHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTransactionHistory.Size = new System.Drawing.Size(1070, 265);
            this.dgvTransactionHistory.TabIndex = 2;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottomTop);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 526);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            this.pnlBottomTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.DateTimePicker dateTimeTransactionDate;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.ComboBox drpdwnSaleID;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBottomTop;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPaymentMethodSelectInSale;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox drpdwnCustomerName;
        private System.Windows.Forms.Label label8;
    }
}