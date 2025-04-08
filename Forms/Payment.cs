using SmartStock.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SmartStock.Forms
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dateTimeTransactionDate.Text = DateTime.Now.ToShortDateString();
            SaleIDLoad();
            CustomerLoad();
            DGVTransaction();
            transactionID();
        }

        private void transactionID()
        {
            Transaction_Methods tm = new Transaction_Methods();
            txtTransactionID.Text = Convert.ToString(tm.MaxTransactionID() + 1) ;
        }

        private void SaleIDLoad()
        {
            Sale_Methods sm = new Sale_Methods();
            drpdwnSaleID.DataSource = sm.GetAllData();
            drpdwnSaleID.DisplayMember = "SaleID";
            drpdwnSaleID.ValueMember = "SaleID";
        }


        private void CustomerLoad()
        {
            Customer_Methods cm = new Customer_Methods();
            drpdwnCustomerName.DataSource = cm.GetAllData();
            drpdwnCustomerName.DisplayMember = "CustomerName";
            drpdwnCustomerName.ValueMember = "CustomerID";
        }


        private void drpdwnSaleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpdwnSaleID.SelectedIndex != -1 && drpdwnSaleID.SelectedValue != null && drpdwnSaleID.SelectedValue is int)
            {
                int saleid = (int)drpdwnSaleID.SelectedValue;

                Sale_Methods sm = new Sale_Methods();
                Sales s = sm.GetDataByID(saleid);

                if (s != null)
                {
                    decimal totalPrice = s.TotalAmount - s.Discount;

                    txtTotalAmount.Text = Convert.ToString(totalPrice);
                    txtPaymentMethodSelectInSale.Text = Convert.ToString(s.PaymentMethod);
                }


            }

        }




        private void txtTransactionID_MouseEnter(object sender, EventArgs e)
        {
            txtTransactionID.BackColor = Color.AliceBlue;
        }

        private void drpdwnSaleID_MouseEnter(object sender, EventArgs e)
        {
            drpdwnSaleID.BackColor = Color.AliceBlue;
        }

        private void txtPaymentMethodSelectInSale_MouseEnter(object sender, EventArgs e)
        {
            txtPaymentMethodSelectInSale.BackColor = Color.AliceBlue;
        }

        private void txtPaidAmount_MouseEnter(object sender, EventArgs e)
        {
            txtPaidAmount.BackColor = Color.AliceBlue;
        }

        private void txtTransactionID_MouseLeave(object sender, EventArgs e)
        {
            txtTransactionID.BackColor = Color.White;
        }

        private void drpdwnSaleID_MouseLeave(object sender, EventArgs e)
        {
            drpdwnSaleID.BackColor = Color.White;
        }

        private void txtPaymentMethodSelectInSale_MouseLeave(object sender, EventArgs e)
        {
            txtPaymentMethodSelectInSale.BackColor = Color.White;
        }

        private void txtPaidAmount_MouseLeave(object sender, EventArgs e)
        {
            txtPaidAmount.BackColor = Color.White;
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid price (e.g., 100.50)", txtPaidAmount, 0, txtPaidAmount.Height, 2000);
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) //only one decimal point is allowed
            {
                e.Handled = true;
            }
        }


        private void DGVTransaction()
        {
            Transaction_Methods tm = new Transaction_Methods();
            List<Transactions> t = tm.GetAllData();
            dgvTransactionHistory.DataSource = t;
            dgvTransactionHistory.Columns["CustomerID"].Visible = false;
            dgvTransactionHistory.Columns["IsDeleted"].Visible = false;
        }

        private void ResetForm()
        {
            txtTransactionID.Text = string.Empty; //should show the next transactionid
            drpdwnSaleID.SelectedIndex = -1;
            drpdwnCustomerName.SelectedIndex = -1;
            txtPaidAmount.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtPaymentMethodSelectInSale.Text = string.Empty;
            dateTimeTransactionDate.Text = Convert.ToString(DateTime.Now);
        }

        private bool ValidateForm()
        {
            bool isvalid = true;
            if (drpdwnSaleID.SelectedIndex == -1)
            {
                MessageBox.Show("Sale ID is required, select sale", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("CustomerName is required, select Customer", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                MessageBox.Show("Paid Amount is required, enter Paid Amount", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Transactions t = new Transactions();
                Transaction_Methods tm = new Transaction_Methods();
                t.SaleID = Convert.ToInt32(drpdwnSaleID.SelectedValue);
                t.CustomerID = Convert.ToInt32(drpdwnCustomerName.SelectedValue);
                t.PaymentMethod = txtPaymentMethodSelectInSale.Text;
                t.AmountPaid = Convert.ToDecimal(txtPaidAmount.Text);
                if (txtPaidAmount.Text == txtTotalAmount.Text)
                {
                    t.PaymentStatus = "Amount Paid";
                }
                else
                {
                    t.PaymentStatus = "Pending";
                }
                t.TransactionDate = DateTime.Now;
                t.IsDeleted = false;

                bool IstransactionSuccessful = tm.Insert(t);

                if (IstransactionSuccessful)
                {
                    MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVTransaction();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Transaction Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "TransactionHistory.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // --- Header with Logo on the Left and Company Name on Right ---
                    PdfPTable headerTable = new PdfPTable(2);
                    headerTable.WidthPercentage = 100;
                    float[] headerWidths = { 15f, 85f };
                    headerTable.SetWidths(headerWidths);

                    // Logo - Left Side
                    string imagePath = @"E:\Projects\SmartStock\CompanyLogo.png"; // Adjust path
                    if (File.Exists(imagePath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                        logo.ScaleAbsolute(80f, 40f);
                        PdfPCell logoCell = new PdfPCell(logo)
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_LEFT,
                            VerticalAlignment = Element.ALIGN_MIDDLE
                        };
                        headerTable.AddCell(logoCell);
                    }
                    else
                    {
                        PdfPCell emptyLogoCell = new PdfPCell(new Phrase(""))
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER,
                        };
                        headerTable.AddCell(emptyLogoCell);
                    }

                    // Company Name - Right Side
                    PdfPCell companyCell = new PdfPCell(new Phrase("SmartStock - Advanced Inventory & Sales Management System",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };
                    headerTable.AddCell(companyCell);

                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n"));

                    // --- Report Title ---
                    Paragraph reportTitle = new Paragraph("Transaction History",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD))
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 20f
                    };
                    pdfDoc.Add(reportTitle);

                    // --- Define columns to hide ---
                    List<string> columnsToHide = new List<string> { "TransactionID", "Delete" };

                    // Calculate visible columns count
                    int totalVisibleCols = dgvTransactionHistory.Columns.Cast<DataGridViewColumn>()
                                            .Count(col => col.Visible && !columnsToHide.Contains(col.HeaderText));

                    PdfPTable pdfTable = new PdfPTable(totalVisibleCols)
                    {
                        WidthPercentage = 100
                    };

                    // --- Add Headers ---
                    foreach (DataGridViewColumn column in dgvTransactionHistory.Columns)
                    {
                        if (column.Visible && !columnsToHide.Contains(column.HeaderText))
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(headerCell);
                        }
                    }

                    // --- Add Data Rows ---
                    foreach (DataGridViewRow row in dgvTransactionHistory.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewColumn column in dgvTransactionHistory.Columns)
                            {
                                if (column.Visible && !columnsToHide.Contains(column.HeaderText))
                                {
                                    pdfTable.AddCell(row.Cells[column.Index].Value?.ToString() ?? "");
                                }
                            }
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();

                    MessageBox.Show("Transaction History Exported to PDF Successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Excel
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1];
                excelWorksheet.Name = "Transaction History";

                int currentRow = 1;
                int logoSize = 80; // Logo size (width and height)

                // Insert Company Logo (positioned top-left)
                string logoPath = Application.StartupPath + @"E:\Projects\SmartStock\CompanyLogo.png";
                if (System.IO.File.Exists(logoPath))
                {
                    // Add the picture at cell A1
                    excelWorksheet.Shapes.AddPicture(
                        logoPath,
                        Microsoft.Office.Core.MsoTriState.msoFalse,
                        Microsoft.Office.Core.MsoTriState.msoCTrue,
                        10, // Left (can adjust for spacing)
                        10, // Top
                        logoSize,
                        logoSize
                    );
                }

                // Company Name (to the right of logo)
                excelWorksheet.Cells[currentRow, 3] = "SmartStock - Advanced Inventory & Sales Management System";
                Microsoft.Office.Interop.Excel.Range companyNameRange = excelWorksheet.get_Range("C" + currentRow, "G" + currentRow);
                companyNameRange.Merge();
                companyNameRange.Font.Size = 18;
                companyNameRange.Font.Bold = true;
                companyNameRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                companyNameRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                // Add space after logo and company name
                currentRow += 4;

                // Title "Sale History"
                excelWorksheet.Cells[currentRow, 1] = "Transaction History";
                Microsoft.Office.Interop.Excel.Range titleRange = excelWorksheet.get_Range("A" + currentRow, "G" + currentRow);
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                currentRow += 2;

                // Prepare filtered column list (excluding unwanted columns/buttons)
                List<int> exportColumns = new List<int>();
                for (int i = 0; i < dgvTransactionHistory.Columns.Count; i++)
                {
                    string colName = dgvTransactionHistory.Columns[i].Name;
                    if (colName != "TransactionID")
                    {
                        exportColumns.Add(i);
                    }
                }

                // Export Column Headers
                int colPos = 1;
                foreach (int colIndex in exportColumns)
                {
                    excelWorksheet.Cells[currentRow, colPos] = dgvTransactionHistory.Columns[colIndex].HeaderText;
                    colPos++;
                }

                // Export Data Rows
                for (int i = 0; i < dgvTransactionHistory.Rows.Count; i++)
                {
                    if (dgvTransactionHistory.Rows[i].IsNewRow) continue;
                    colPos = 1;
                    foreach (int colIndex in exportColumns)
                    {
                        object cellValue = dgvTransactionHistory.Rows[i].Cells[colIndex].Value;
                        excelWorksheet.Cells[currentRow + 1 + i, colPos] = cellValue != null ? cellValue.ToString() : "";
                        colPos++;
                    }
                }

                // AutoFit the columns
                excelWorksheet.Columns.AutoFit();

                // Save Dialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveDialog.FileName = "TransactionHistory_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    excelWorkbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Transaction History Exported Successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cleanup
                excelWorkbook.Close(false);
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
