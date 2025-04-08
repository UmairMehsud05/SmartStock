namespace SmartStock.Forms
{
    partial class SalesReport
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grounboxAddCategory = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeSearchStartFrom = new System.Windows.Forms.DateTimePicker();
            this.datetimeSearchByTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearchForProductORSaleID = new System.Windows.Forms.PictureBox();
            this.drpdwnSearchByProduct = new System.Windows.Forms.ComboBox();
            this.txtSearchByProductORSaleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlbottemtop = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crystalreportForSale = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlTop.SuspendLayout();
            this.grounboxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchForProductORSaleID)).BeginInit();
            this.pnlbottemtop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.grounboxAddCategory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1070, 186);
            this.pnlTop.TabIndex = 0;
            // 
            // grounboxAddCategory
            // 
            this.grounboxAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grounboxAddCategory.Controls.Add(this.label6);
            this.grounboxAddCategory.Controls.Add(this.label2);
            this.grounboxAddCategory.Controls.Add(this.datetimeSearchStartFrom);
            this.grounboxAddCategory.Controls.Add(this.datetimeSearchByTo);
            this.grounboxAddCategory.Controls.Add(this.btnSearchForProductORSaleID);
            this.grounboxAddCategory.Controls.Add(this.drpdwnSearchByProduct);
            this.grounboxAddCategory.Controls.Add(this.txtSearchByProductORSaleID);
            this.grounboxAddCategory.Controls.Add(this.label5);
            this.grounboxAddCategory.Controls.Add(this.label3);
            this.grounboxAddCategory.Controls.Add(this.label4);
            this.grounboxAddCategory.Controls.Add(this.label1);
            this.grounboxAddCategory.Location = new System.Drawing.Point(69, 12);
            this.grounboxAddCategory.Name = "grounboxAddCategory";
            this.grounboxAddCategory.Size = new System.Drawing.Size(933, 153);
            this.grounboxAddCategory.TabIndex = 10;
            this.grounboxAddCategory.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, -15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales Reports";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search";
            // 
            // datetimeSearchStartFrom
            // 
            this.datetimeSearchStartFrom.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchStartFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSearchStartFrom.Location = new System.Drawing.Point(475, 73);
            this.datetimeSearchStartFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeSearchStartFrom.Name = "datetimeSearchStartFrom";
            this.datetimeSearchStartFrom.Size = new System.Drawing.Size(210, 35);
            this.datetimeSearchStartFrom.TabIndex = 2;
            // 
            // datetimeSearchByTo
            // 
            this.datetimeSearchByTo.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchByTo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSearchByTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSearchByTo.Location = new System.Drawing.Point(691, 74);
            this.datetimeSearchByTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimeSearchByTo.Name = "datetimeSearchByTo";
            this.datetimeSearchByTo.Size = new System.Drawing.Size(210, 35);
            this.datetimeSearchByTo.TabIndex = 3;
            // 
            // btnSearchForProductORSaleID
            // 
            this.btnSearchForProductORSaleID.BackColor = System.Drawing.Color.Teal;
            this.btnSearchForProductORSaleID.Image = global::SmartStock.Properties.Resources.searchicon;
            this.btnSearchForProductORSaleID.Location = new System.Drawing.Point(198, 74);
            this.btnSearchForProductORSaleID.Name = "btnSearchForProductORSaleID";
            this.btnSearchForProductORSaleID.Size = new System.Drawing.Size(40, 35);
            this.btnSearchForProductORSaleID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchForProductORSaleID.TabIndex = 1;
            this.btnSearchForProductORSaleID.TabStop = false;
            // 
            // drpdwnSearchByProduct
            // 
            this.drpdwnSearchByProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnSearchByProduct.FormattingEnabled = true;
            this.drpdwnSearchByProduct.Location = new System.Drawing.Point(254, 71);
            this.drpdwnSearchByProduct.Name = "drpdwnSearchByProduct";
            this.drpdwnSearchByProduct.Size = new System.Drawing.Size(210, 38);
            this.drpdwnSearchByProduct.TabIndex = 1;
            this.drpdwnSearchByProduct.MouseEnter += new System.EventHandler(this.drpdwnSearchByProduct_MouseEnter);
            this.drpdwnSearchByProduct.MouseLeave += new System.EventHandler(this.drpdwnSearchByProduct_MouseLeave);
            // 
            // txtSearchByProductORSaleID
            // 
            this.txtSearchByProductORSaleID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByProductORSaleID.Location = new System.Drawing.Point(28, 73);
            this.txtSearchByProductORSaleID.Name = "txtSearchByProductORSaleID";
            this.txtSearchByProductORSaleID.Size = new System.Drawing.Size(210, 35);
            this.txtSearchByProductORSaleID.TabIndex = 0;
            this.txtSearchByProductORSaleID.MouseEnter += new System.EventHandler(this.txtSearchByProductORSaleID_MouseEnter);
            this.txtSearchByProductORSaleID.MouseLeave += new System.EventHandler(this.txtSearchByProductORSaleID_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 50);
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
            this.label3.Location = new System.Drawing.Point(471, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // pnlbottemtop
            // 
            this.pnlbottemtop.BackColor = System.Drawing.Color.LightBlue;
            this.pnlbottemtop.Controls.Add(this.btnGenerateReport);
            this.pnlbottemtop.Controls.Add(this.btnExportToPDF);
            this.pnlbottemtop.Controls.Add(this.btnPrintReport);
            this.pnlbottemtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbottemtop.Location = new System.Drawing.Point(0, 186);
            this.pnlbottemtop.Name = "pnlbottemtop";
            this.pnlbottemtop.Size = new System.Drawing.Size(1070, 97);
            this.pnlbottemtop.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Teal;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(304, 30);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(144, 45);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.BackColor = System.Drawing.Color.Teal;
            this.btnExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(627, 30);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(139, 45);
            this.btnExportToPDF.TabIndex = 6;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = false;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.Teal;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(464, 30);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(144, 45);
            this.btnPrintReport.TabIndex = 5;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.crystalreportForSale);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 325);
            this.panel3.TabIndex = 2;
            // 
            // crystalreportForSale
            // 
            this.crystalreportForSale.ActiveViewIndex = -1;
            this.crystalreportForSale.AutoScroll = true;
            this.crystalreportForSale.AutoSize = true;
            this.crystalreportForSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalreportForSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalreportForSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalreportForSale.Location = new System.Drawing.Point(0, 0);
            this.crystalreportForSale.Name = "crystalreportForSale";
            this.crystalreportForSale.Size = new System.Drawing.Size(1070, 325);
            this.crystalreportForSale.TabIndex = 1;
            this.crystalreportForSale.Load += new System.EventHandler(this.crystalreportForSale_Load);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlbottemtop);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 526);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesReport_FormClosing_1);
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.grounboxAddCategory.ResumeLayout(false);
            this.grounboxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchForProductORSaleID)).EndInit();
            this.pnlbottemtop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlbottemtop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grounboxAddCategory;
        private System.Windows.Forms.DateTimePicker datetimeSearchStartFrom;
        private System.Windows.Forms.DateTimePicker datetimeSearchByTo;
        private System.Windows.Forms.PictureBox btnSearchForProductORSaleID;
        private System.Windows.Forms.ComboBox drpdwnSearchByProduct;
        private System.Windows.Forms.TextBox txtSearchByProductORSaleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnPrintReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreportForSale;
    }
}