using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class SalesReport : Form
    {
        int SaleId;
        ReportDocument cryRpt;

        public SalesReport(int id)
        {
            InitializeComponent();
            this.SaleId = id;
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            if (SaleId > 0)
            {
                cryRpt = new ReportDocument();
                string reportPath = Application.StartupPath + @"\Reports\rptSaleReport.rpt";
                cryRpt.Load(reportPath);

                foreach (CrystalDecisions.CrystalReports.Engine.Table table in cryRpt.Database.Tables)
                {
                    TableLogOnInfo logonInfo = table.LogOnInfo;
                    logonInfo.ConnectionInfo.ServerName = @"DESKTOP-USIKR4F";
                    logonInfo.ConnectionInfo.DatabaseName = "SmartStockDB";
                    logonInfo.ConnectionInfo.IntegratedSecurity = true;
                    table.ApplyLogOnInfo(logonInfo);
                }

                // Set the parameter
                cryRpt.SetParameterValue("SaleID", SaleId);

                // Force the report to refresh
                crystalreportForSale.ReportSource = null; // Clear previous report
                crystalreportForSale.ReportSource = cryRpt;
                crystalreportForSale.RefreshReport();
                crystalreportForSale.Refresh();
            }

        }

        private void crystalreportForSale_Load(object sender, EventArgs e)
        {
            crystalreportForSale.Zoom(1);
        }

        private void txtSearchByProductORSaleID_MouseEnter(object sender, EventArgs e)
        {
            txtSearchByProductORSaleID.BackColor = Color.AliceBlue;
        }

        private void drpdwnSearchByProduct_MouseEnter(object sender, EventArgs e)
        {
            drpdwnSearchByProduct.BackColor = Color.AliceBlue;
        }

        private void txtSearchByProductORSaleID_MouseLeave(object sender, EventArgs e)
        {
            txtSearchByProductORSaleID.BackColor = Color.White;
        }

        private void drpdwnSearchByProduct_MouseLeave(object sender, EventArgs e)
        {
            drpdwnSearchByProduct.BackColor = Color.White;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string reportPath = Application.StartupPath + @"\Reports\rptSaleReport.rpt";
            cryRpt.Load(reportPath);

            foreach (CrystalDecisions.CrystalReports.Engine.Table table in cryRpt.Database.Tables)
            {
                TableLogOnInfo logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo.ServerName = @"DESKTOP-USIKR4F";
                logonInfo.ConnectionInfo.DatabaseName = "SmartStockDB";
                logonInfo.ConnectionInfo.IntegratedSecurity = true;
                table.ApplyLogOnInfo(logonInfo);
            }



            int saleID;
            string filter = "";

            if (!string.IsNullOrEmpty(txtSearchByProductORSaleID.Text))
            {
                if (int.TryParse(txtSearchByProductORSaleID.Text, out saleID))
                {
                    filter = "{Sales.SaleID} = " + saleID;
                }
                else
                {
                    filter = "{Sales.InvoiceNo} = '" + txtSearchByProductORSaleID.Text + "'";
                }
            }
            else if (!string.IsNullOrEmpty(drpdwnSearchByProduct.Text))
            {
                filter = "{SalesDetails.ProductName} = '" + drpdwnSearchByProduct.Text + "'";
            }
            else if (datetimeSearchStartFrom.Value <= datetimeSearchByTo.Value)
            {
                filter = "{Sales.SaleDate} in DateTime('" + datetimeSearchStartFrom.Value.ToString("yyyy,MM,dd") + "') to DateTime('" + datetimeSearchByTo.Value.ToString("yyyy,MM,dd") + "')";
            }

            cryRpt.RecordSelectionFormula = filter;
            crystalreportForSale.ReportSource = cryRpt;
            crystalreportForSale.Refresh();

        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string reportPath = Application.StartupPath + @"\Reports\rptSaleReport.rpt";
                cryRpt.Load(reportPath);

                // Apply DB Login Info
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in cryRpt.Database.Tables)
                {
                    TableLogOnInfo logonInfo = table.LogOnInfo;
                    logonInfo.ConnectionInfo.ServerName = @"DESKTOP-USIKR4F";
                    logonInfo.ConnectionInfo.DatabaseName = "SmartStockDB";
                    logonInfo.ConnectionInfo.IntegratedSecurity = true;
                    table.ApplyLogOnInfo(logonInfo);
                }

                // Set Parameter if needed
                cryRpt.SetParameterValue("SaleID", SaleId);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save Report as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cryRpt.Close();
                cryRpt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting report: " + ex.Message);
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string reportPath = Application.StartupPath + @"\Reports\rptSaleReport.rpt";
                cryRpt.Load(reportPath);

                // Apply DB Login Info with Integrated Security
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in cryRpt.Database.Tables)
                {
                    TableLogOnInfo logonInfo = table.LogOnInfo;
                    logonInfo.ConnectionInfo.ServerName = @"DESKTOP-USIKR4F";
                    logonInfo.ConnectionInfo.DatabaseName = "SmartStockDB";
                    logonInfo.ConnectionInfo.IntegratedSecurity = true;
                    table.ApplyLogOnInfo(logonInfo);
                }

                // Set your parameters if any
                cryRpt.SetParameterValue("SaleID", SaleId);

                // Optional: You can select a printer, or leave blank to use default
                // cryRpt.PrintOptions.PrinterName = "Your Printer Name";

                // Direct print without showing any dialog
                cryRpt.PrintToPrinter(1, false, 0, 0);

                MessageBox.Show("Report sent to printer.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Always close to release memory
                cryRpt.Close();
                cryRpt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing report: " + ex.Message);
            }
        }

        private void SalesReport_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (cryRpt != null)
            {
                cryRpt.Close();
                cryRpt.Dispose();
                cryRpt = null;
            }
        }
    }
}
