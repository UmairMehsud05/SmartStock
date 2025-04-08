namespace SmartStock.Forms
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.txtPurchasedBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.datetimePurchase = new System.Windows.Forms.DateTimePicker();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.drpdwnProduct = new System.Windows.Forms.ComboBox();
            this.drpdwnSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnPurchaseSearch = new System.Windows.Forms.PictureBox();
            this.txtPurchaseSearch = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.grounboxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurchaseSearch)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.grounboxAddCategory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1070, 285);
            this.pnlTop.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "Purchase";
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.txtPurchasedBy);
            this.grounboxAddCategory.Controls.Add(this.label2);
            this.grounboxAddCategory.Controls.Add(this.txtTotalCost);
            this.grounboxAddCategory.Controls.Add(this.datetimePurchase);
            this.grounboxAddCategory.Controls.Add(this.txtUnitPrice);
            this.grounboxAddCategory.Controls.Add(this.txtQuantity);
            this.grounboxAddCategory.Controls.Add(this.drpdwnProduct);
            this.grounboxAddCategory.Controls.Add(this.drpdwnSupplier);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label7);
            this.grounboxAddCategory.Controls.Add(this.label4);
            this.grounboxAddCategory.Controls.Add(this.lblprice);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Controls.Add(this.btnAddPurchase);
            this.grounboxAddCategory.Location = new System.Drawing.Point(63, 43);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(945, 214);
            this.grounboxAddCategory.TabIndex = 10;
            this.grounboxAddCategory.TabStop = false;
            // 
            // txtPurchasedBy
            // 
            this.txtPurchasedBy.BackColor = System.Drawing.Color.White;
            this.txtPurchasedBy.Enabled = false;
            this.txtPurchasedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasedBy.Location = new System.Drawing.Point(480, 134);
            this.txtPurchasedBy.Name = "txtPurchasedBy";
            this.txtPurchasedBy.ReadOnly = true;
            this.txtPurchasedBy.Size = new System.Drawing.Size(210, 35);
            this.txtPurchasedBy.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Purchased By";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.White;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(39, 134);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(210, 35);
            this.txtTotalCost.TabIndex = 11;
            this.txtTotalCost.MouseEnter += new System.EventHandler(this.txtTotalCost_MouseEnter);
            this.txtTotalCost.MouseLeave += new System.EventHandler(this.txtTotalCost_MouseLeave);
            // 
            // datetimePurchase
            // 
            this.datetimePurchase.Enabled = false;
            this.datetimePurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePurchase.Location = new System.Drawing.Point(260, 133);
            this.datetimePurchase.Margin = new System.Windows.Forms.Padding(9);
            this.datetimePurchase.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimePurchase.Name = "datetimePurchase";
            this.datetimePurchase.Size = new System.Drawing.Size(210, 35);
            this.datetimePurchase.TabIndex = 12;
            this.datetimePurchase.Value = new System.DateTime(2025, 3, 12, 16, 9, 9, 0);
            this.datetimePurchase.MouseEnter += new System.EventHandler(this.datetimePurchase_MouseEnter);
            this.datetimePurchase.MouseLeave += new System.EventHandler(this.datetimePurchase_MouseLeave);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(703, 57);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 35);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            this.txtUnitPrice.MouseEnter += new System.EventHandler(this.txtUnitPrice_MouseEnter);
            this.txtUnitPrice.MouseLeave += new System.EventHandler(this.txtUnitPrice_MouseLeave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(480, 57);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 35);
            this.txtQuantity.TabIndex = 2;
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
            this.drpdwnProduct.Location = new System.Drawing.Point(39, 56);
            this.drpdwnProduct.Name = "drpdwnProduct";
            this.drpdwnProduct.Size = new System.Drawing.Size(210, 38);
            this.drpdwnProduct.TabIndex = 0;
            this.drpdwnProduct.MouseEnter += new System.EventHandler(this.drpdwnProduct_MouseEnter);
            this.drpdwnProduct.MouseLeave += new System.EventHandler(this.drpdwnProduct_MouseLeave);
            // 
            // drpdwnSupplier
            // 
            this.drpdwnSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnSupplier.FormattingEnabled = true;
            this.drpdwnSupplier.Location = new System.Drawing.Point(260, 56);
            this.drpdwnSupplier.Name = "drpdwnSupplier";
            this.drpdwnSupplier.Size = new System.Drawing.Size(210, 38);
            this.drpdwnSupplier.TabIndex = 1;
            this.drpdwnSupplier.MouseEnter += new System.EventHandler(this.drpdwnSupplier_MouseEnter);
            this.drpdwnSupplier.MouseLeave += new System.EventHandler(this.drpdwnSupplier_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Cost";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(699, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier";
            // 
            // lblprice
            // 
            this.lblprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(476, 33);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(77, 21);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPurchase.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchase.Location = new System.Drawing.Point(703, 123);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(113, 45);
            this.btnAddPurchase.TabIndex = 4;
            this.btnAddPurchase.Text = "Add";
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMiddle.Controls.Add(this.btnPurchaseSearch);
            this.pnlMiddle.Controls.Add(this.txtPurchaseSearch);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 285);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1070, 78);
            this.pnlMiddle.TabIndex = 1;
            // 
            // btnPurchaseSearch
            // 
            this.btnPurchaseSearch.BackColor = System.Drawing.Color.Teal;
            this.btnPurchaseSearch.Image = global::SmartStock.Properties.Resources.searchicon;
            this.btnPurchaseSearch.Location = new System.Drawing.Point(617, 22);
            this.btnPurchaseSearch.Name = "btnPurchaseSearch";
            this.btnPurchaseSearch.Size = new System.Drawing.Size(39, 35);
            this.btnPurchaseSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPurchaseSearch.TabIndex = 7;
            this.btnPurchaseSearch.TabStop = false;
            // 
            // txtPurchaseSearch
            // 
            this.txtPurchaseSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseSearch.Location = new System.Drawing.Point(414, 22);
            this.txtPurchaseSearch.Name = "txtPurchaseSearch";
            this.txtPurchaseSearch.Size = new System.Drawing.Size(242, 35);
            this.txtPurchaseSearch.TabIndex = 5;
            this.txtPurchaseSearch.TextChanged += new System.EventHandler(this.txtPurchaseSearch_TextChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBottom.Controls.Add(this.dgvPurchase);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 363);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1070, 245);
            this.pnlBottom.TabIndex = 2;
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchase.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchase.Name = "dgvPurchase";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchase.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchase.RowTemplate.Height = 42;
            this.dgvPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPurchase.Size = new System.Drawing.Size(1070, 245);
            this.dgvPurchase.TabIndex = 1;
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellClick);
            this.dgvPurchase.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvPurchase_Paint);
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 526);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurchaseSearch)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.DateTimePicker datetimePurchase;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.ComboBox drpdwnProduct;
        private System.Windows.Forms.ComboBox drpdwnSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnPurchaseSearch;
        private System.Windows.Forms.TextBox txtPurchaseSearch;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPurchasedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}