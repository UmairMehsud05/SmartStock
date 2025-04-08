namespace SmartStock.Forms
{
    partial class SalesHistory
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
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.datetimeSearchByTo = new System.Windows.Forms.DateTimePicker();
            this.datetimeSearchStartFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearchForProductORSaleID = new System.Windows.Forms.PictureBox();
            this.txtSearchByProductORSaleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBottomTop = new System.Windows.Forms.Panel();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.pnlbotmBottem = new System.Windows.Forms.Panel();
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grounboxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchForProductORSaleID)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBottomTop.SuspendLayout();
            this.pnlbotmBottem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.btnReset);
            this.grounboxAddCategory.Controls.Add(this.datetimeSearchByTo);
            this.grounboxAddCategory.Controls.Add(this.datetimeSearchStartFrom);
            this.grounboxAddCategory.Controls.Add(this.btnSearchForProductORSaleID);
            this.grounboxAddCategory.Controls.Add(this.txtSearchByProductORSaleID);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Location = new System.Drawing.Point(63, 19);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(947, 132);
            this.grounboxAddCategory.TabIndex = 10;
            this.grounboxAddCategory.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(781, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 45);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // datetimeSearchByTo
            // 
            this.datetimeSearchByTo.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchByTo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchByTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSearchByTo.Location = new System.Drawing.Point(551, 72);
            this.datetimeSearchByTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeSearchByTo.Name = "datetimeSearchByTo";
            this.datetimeSearchByTo.Size = new System.Drawing.Size(210, 35);
            this.datetimeSearchByTo.TabIndex = 3;
            this.datetimeSearchByTo.ValueChanged += new System.EventHandler(this.datetimeSearchByTo_ValueChanged);
            // 
            // datetimeSearchStartFrom
            // 
            this.datetimeSearchStartFrom.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchStartFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSearchStartFrom.Location = new System.Drawing.Point(309, 71);
            this.datetimeSearchStartFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeSearchStartFrom.Name = "datetimeSearchStartFrom";
            this.datetimeSearchStartFrom.Size = new System.Drawing.Size(210, 35);
            this.datetimeSearchStartFrom.TabIndex = 2;
            this.datetimeSearchStartFrom.ValueChanged += new System.EventHandler(this.datetimeSearchStartFrom_ValueChanged);
            // 
            // btnSearchForProductORSaleID
            // 
            this.btnSearchForProductORSaleID.BackColor = System.Drawing.Color.Teal;
            this.btnSearchForProductORSaleID.Image = global::SmartStock.Properties.Resources.searchicon;
            this.btnSearchForProductORSaleID.Location = new System.Drawing.Point(241, 71);
            this.btnSearchForProductORSaleID.Name = "btnSearchForProductORSaleID";
            this.btnSearchForProductORSaleID.Size = new System.Drawing.Size(36, 35);
            this.btnSearchForProductORSaleID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchForProductORSaleID.TabIndex = 1;
            this.btnSearchForProductORSaleID.TabStop = false;
            // 
            // txtSearchByProductORSaleID
            // 
            this.txtSearchByProductORSaleID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByProductORSaleID.Location = new System.Drawing.Point(56, 71);
            this.txtSearchByProductORSaleID.Name = "txtSearchByProductORSaleID";
            this.txtSearchByProductORSaleID.Size = new System.Drawing.Size(221, 35);
            this.txtSearchByProductORSaleID.TabIndex = 0;
            this.txtSearchByProductORSaleID.TextChanged += new System.EventHandler(this.txtSearchByProductORSaleID_TextChanged);
            this.txtSearchByProductORSaleID.MouseEnter += new System.EventHandler(this.txtSearchByProductORSaleID_MouseEnter);
            this.txtSearchByProductORSaleID.MouseLeave += new System.EventHandler(this.txtSearchByProductORSaleID_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "To";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By ID or Invoice";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sales History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grounboxAddCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 171);
            this.panel1.TabIndex = 6;
            // 
            // pnlBottomTop
            // 
            this.pnlBottomTop.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBottomTop.Controls.Add(this.btnExportToPDF);
            this.pnlBottomTop.Controls.Add(this.btnExportToExcel);
            this.pnlBottomTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomTop.Location = new System.Drawing.Point(0, 171);
            this.pnlBottomTop.Name = "pnlBottomTop";
            this.pnlBottomTop.Size = new System.Drawing.Size(1070, 82);
            this.pnlBottomTop.TabIndex = 7;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.BackColor = System.Drawing.Color.Teal;
            this.btnExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(387, 24);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(144, 45);
            this.btnExportToPDF.TabIndex = 4;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = false;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(552, 24);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(139, 45);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // pnlbotmBottem
            // 
            this.pnlbotmBottem.BackColor = System.Drawing.Color.LightBlue;
            this.pnlbotmBottem.Controls.Add(this.dgvSalesHistory);
            this.pnlbotmBottem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbotmBottem.Location = new System.Drawing.Point(0, 253);
            this.pnlbotmBottem.Name = "pnlbotmBottem";
            this.pnlbotmBottem.Size = new System.Drawing.Size(1070, 355);
            this.pnlbotmBottem.TabIndex = 8;
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.AllowUserToAddRows = false;
            this.dgvSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesHistory.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.View});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesHistory.RowTemplate.Height = 42;
            this.dgvSalesHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSalesHistory.Size = new System.Drawing.Size(1070, 355);
            this.dgvSalesHistory.TabIndex = 2;
            this.dgvSalesHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesHistory_CellClick);
            this.dgvSalesHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSalesHistory_Paint);
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
            // View
            // 
            this.View.HeaderText = "View Details";
            this.View.Name = "View";
            this.View.Text = "View Details";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.pnlbotmBottem);
            this.Controls.Add(this.pnlBottomTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 526);
            this.Name = "SalesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesHistory_Load);
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchForProductORSaleID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBottomTop.ResumeLayout(false);
            this.pnlbotmBottem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.DateTimePicker datetimeSearchByTo;
        private System.Windows.Forms.DateTimePicker datetimeSearchStartFrom;
        private System.Windows.Forms.PictureBox btnSearchForProductORSaleID;
        private System.Windows.Forms.TextBox txtSearchByProductORSaleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBottomTop;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Panel pnlbotmBottem;
        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Button btnReset;
    }
}