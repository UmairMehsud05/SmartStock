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
using System.Drawing; // For image
using System.Windows.Forms; // If not added

namespace SmartStock.Forms
{
    public partial class SalesHistory : Form
    {
        int saleid;
        Main mainform;
        public SalesHistory(Main mform)
        {
            InitializeComponent();
            mainform = mform;
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            DGVSaleHistory();
        }


        private void DGVSaleHistory()
        {
            Sale_Methods sm = new Sale_Methods();
            dgvSalesHistory.DataSource = sm.GetAllData();
            dgvSalesHistory.Columns["CustomerID"].Visible = false;
            dgvSalesHistory.Columns["IsDeleted"].Visible = false;
            dgvSalesHistory.Columns["SoldBy"].Visible = false;
        }

        private void txtSearchByProductORSaleID_MouseEnter(object sender, EventArgs e)
        {
            txtSearchByProductORSaleID.BackColor = Color.AliceBlue;
        }


        private void txtSearchByProductORSaleID_MouseLeave(object sender, EventArgs e)
        {
            txtSearchByProductORSaleID.BackColor = Color.White;
        }

        private void dgvSalesHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                saleid = Convert.ToInt32(dgvSalesHistory.Rows[e.RowIndex].Cells["SaleID"].Value);

                if (e.ColumnIndex == dgvSalesHistory.Columns["Delete"].Index)
                {
                    DialogResult result= MessageBox.Show("Are you sure you want to delete this Sale Data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Sale_Methods sm = new Sale_Methods();
                        sm.DeleteSaleData(saleid);
                        MessageBox.Show("Sale Data Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DGVSaleHistory();
                    }
                    
                }
                else if (e.ColumnIndex == dgvSalesHistory.Columns["View"].Index)
                {
                    SalesReport sp = new SalesReport(saleid);
                    mainform.LoadForm(sp);
                }
            }
        }


        private void FilterSalesHistory()
        {
            string searchText = txtSearchByProductORSaleID.Text.Trim().ToLower();        // Your Search TextBox
            DateTime fromDate = datetimeSearchStartFrom.Value.Date;
            DateTime toDate = datetimeSearchByTo.Value.Date;

            Sale_Methods sm = new Sale_Methods();
            List<Sales> salesList = sm.GetAllData();   // Assuming this returns List<Sale>

            // Apply filtering using LINQ
            var filteredList = salesList.Where(s =>
                (string.IsNullOrEmpty(searchText) ||
                 s.InvoiceNo.Contains(searchText) ||
                 s.SaleID.ToString().Contains(searchText) ||
                 s.CustomerName.Contains(searchText))
                &&
                // Apply date filter only if user sets a date range
                (fromDate == toDate ? true : (s.SaleDate.Date >= fromDate && s.SaleDate.Date <= toDate))
            ).ToList();

            // Bind filtered list to DataGridView
            dgvSalesHistory.DataSource = filteredList;
        }
        


        private void txtSearchByProductORSaleID_TextChanged(object sender, EventArgs e)
        {
            FilterSalesHistory();
        }

        private void dgvSalesHistory_Paint(object sender, PaintEventArgs e)
        {
            if (dgvSalesHistory.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvSalesHistory.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvSalesHistory.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }

        private void datetimeSearchStartFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterSalesHistory();
        }

        private void datetimeSearchByTo_ValueChanged(object sender, EventArgs e)
        {
            FilterSalesHistory();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchByProductORSaleID.Text = string.Empty;
            datetimeSearchStartFrom.Text = DateTime.Now.ToShortDateString();
            datetimeSearchByTo.Text = DateTime.Now.ToShortDateString();
        }


        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "SalesHistory.pdf";

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
                    Paragraph reportTitle = new Paragraph("Sales History",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD))
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 20f
                    };
                    pdfDoc.Add(reportTitle);

                    // --- Define columns to hide ---
                    List<string> columnsToHide = new List<string> { "CustomerID", "SoldBy", "View Details", "Delete" };

                    // Calculate visible columns count
                    int totalVisibleCols = dgvSalesHistory.Columns.Cast<DataGridViewColumn>()
                                            .Count(col => col.Visible && !columnsToHide.Contains(col.HeaderText));

                    PdfPTable pdfTable = new PdfPTable(totalVisibleCols)
                    {
                        WidthPercentage = 100
                    };

                    // --- Add Headers ---
                    foreach (DataGridViewColumn column in dgvSalesHistory.Columns)
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
                    foreach (DataGridViewRow row in dgvSalesHistory.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewColumn column in dgvSalesHistory.Columns)
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

                    MessageBox.Show("Sales History Exported to PDF Successfully!", "Success");
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
                excelWorksheet.Name = "Sale History";

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
                excelWorksheet.Cells[currentRow, 1] = "Sale History";
                Microsoft.Office.Interop.Excel.Range titleRange = excelWorksheet.get_Range("A" + currentRow, "G" + currentRow);
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                currentRow += 2;

                // Prepare filtered column list (excluding unwanted columns/buttons)
                List<int> exportColumns = new List<int>();
                for (int i = 0; i < dgvSalesHistory.Columns.Count; i++)
                {
                    string colName = dgvSalesHistory.Columns[i].Name;
                    if (colName != "Delete" && colName != "View" &&
                        colName != "SoldBy" && colName != "CustomerID" && colName != "IsDeleted")
                    {
                        exportColumns.Add(i);
                    }
                }

                // Export Column Headers
                int colPos = 1;
                foreach (int colIndex in exportColumns)
                {
                    excelWorksheet.Cells[currentRow, colPos] = dgvSalesHistory.Columns[colIndex].HeaderText;
                    colPos++;
                }

                // Export Data Rows
                for (int i = 0; i < dgvSalesHistory.Rows.Count; i++)
                {
                    if (dgvSalesHistory.Rows[i].IsNewRow) continue;
                    colPos = 1;
                    foreach (int colIndex in exportColumns)
                    {
                        object cellValue = dgvSalesHistory.Rows[i].Cells[colIndex].Value;
                        excelWorksheet.Cells[currentRow + 1 + i, colPos] = cellValue != null ? cellValue.ToString() : "";
                        colPos++;
                    }
                }

                // AutoFit the columns
                excelWorksheet.Columns.AutoFit();

                // Save Dialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveDialog.FileName = "SaleHistory_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    excelWorkbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Sale History Exported Successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
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