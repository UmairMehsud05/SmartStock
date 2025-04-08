using SmartStock.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartStock.Forms
{
    public partial class Sale : Form
    {

        DataTable dtList = new DataTable();

        public Sale()
        {
            InitializeComponent();

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            datetimeSale.Text = Convert.ToString(DateTime.Now.Date);
            GenerateInvoiceNumber();  //Generate invoice number

            txtSoldBy.Text = Session.Name;

            CustomersLoad();
            ProductsLoad();

        }


        private void CustomersLoad()
        {
            Customer_Methods cm = new Customer_Methods();
            List<Customers> c = cm.GetAllData();
            drpdwnCustomerName.DataSource = c;
            drpdwnCustomerName.DisplayMember = "CustomerName";
            drpdwnCustomerName.ValueMember = "CustomerID";
        }


        private void drpdwnProduct_MouseEnter(object sender, EventArgs e)
        {
            drpdwnProduct.BackColor = Color.AliceBlue;
        }

        private void txtUnitPrice_MouseEnter(object sender, EventArgs e)
        {
            txtUnitPrice.BackColor = Color.AliceBlue;
        }

        private void txtDiscount_MouseEnter(object sender, EventArgs e)
        {
            txtDiscount.BackColor = Color.AliceBlue;
        }

        private void txtTotalCost_MouseEnter(object sender, EventArgs e)
        {
            txtTotalCost.BackColor = Color.AliceBlue;
        }

        private void drpdwnCustomerName_MouseEnter(object sender, EventArgs e)
        {
            drpdwnCustomerName.BackColor = Color.AliceBlue;
        }

        private void drpdwnPaymentMethod_MouseEnter(object sender, EventArgs e)
        {
            drpdwnPaymentMethod.BackColor = Color.AliceBlue;
        }

        private void txtInvoice_MouseEnter(object sender, EventArgs e)
        {
            txtInvoice.BackColor = Color.AliceBlue;
        }

        private void txtSoldBy_MouseEnter(object sender, EventArgs e)
        {
            txtInvoice.BackColor = Color.AliceBlue;
        }

        private void drpdwnProduct_MouseLeave(object sender, EventArgs e)
        {
            drpdwnProduct.BackColor = Color.White;
        }

        private void txtUnitPrice_MouseLeave(object sender, EventArgs e)
        {
            txtUnitPrice.BackColor = Color.White;
        }

        private void txtDiscount_MouseLeave(object sender, EventArgs e)
        {
            txtDiscount.BackColor = Color.White;
        }

        private void txtTotalCost_MouseLeave(object sender, EventArgs e)
        {
            txtTotalCost.BackColor = Color.White;
        }

        private void drpdwnCustomerName_MouseLeave(object sender, EventArgs e)
        {
            drpdwnCustomerName.BackColor = Color.White;
        }

        private void drpdwnPaymentMethod_MouseLeave(object sender, EventArgs e)
        {
            drpdwnPaymentMethod.BackColor = Color.White;
        }

        private void txtInvoice_MouseLeave(object sender, EventArgs e)
        {
            txtInvoice.BackColor = Color.White;
        }
        private void txtSoldBy_MouseLeave(object sender, EventArgs e)
        {
            txtInvoice.BackColor = Color.White;
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid price (e.g., 100.50)", txtUnitPrice, 0, txtUnitPrice.Height, 2000);
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) //only one decimal point is allowed
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid stock quantity (e.g., 10)", txtQuantity, 0, txtQuantity.Height, 2000);
            }
        }


        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid stock quantity (e.g., 10)", txtDiscount, 0, txtDiscount.Height, 2000);
            }
        }


        private void ProductsLoad()
        {
            Product_Methods pm = new Product_Methods();
            List<Products> p = pm.GetAllData();
            drpdwnProduct.DataSource = p;
            drpdwnProduct.DisplayMember = "ProductName";
            drpdwnProduct.ValueMember = "ProductID";
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }



        public void CalculateTotalCost()
        {

            int qty = Convert.ToInt32(txtQuantity.Value);
            float price = String.IsNullOrWhiteSpace(txtUnitPrice.Text) ? 0 : Convert.ToInt32(txtUnitPrice.Text);
            float discount = string.IsNullOrWhiteSpace(txtDiscount.Text) ? 0 : Convert.ToInt32(txtDiscount.Text);

            float totalcost;

            if (discount > 0)
            {
                float subtotal = qty * price;
                float discountAmount = (discount / 100) * subtotal;
                totalcost = subtotal - discountAmount;
            }
            else
            {
                totalcost = qty * price;
            }

            txtTotalCost.Text = Convert.ToString(totalcost);
        }


        private void GenerateInvoiceNumber()
        {
            Sale_Methods sm = new Sale_Methods();
            string invoice = sm.MaxInvoiceNo();
            txtInvoice.Text = invoice;
            lblInoiceNoForBill.Text = invoice;
        }

        private void drpdwnCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblCutomerNameForBill.Text = drpdwnCustomerName.Text;
        }

        private void drpdwnPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPaymentMethodForBill.Text = drpdwnPaymentMethod.SelectedItem.ToString();
        }

        private void ClearInputFields()
        {
            txtQuantity.Text = Convert.ToString(1);
            txtUnitPrice.Text = "";
            txtDiscount.Text = "";
            txtTotalCost.Text = "";
            drpdwnProduct.SelectedIndex = -1; // Reset dropdown selection
        }


        private void UpdateSaleSummary()
        {
            decimal totalDiscount = 0;
            decimal subTotal = 0;
            decimal totalPayable = 0;

            decimal discount;
            decimal total;

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                if (row.Cells["Discount"].Value != null && decimal.TryParse(row.Cells["Discount"].Value.ToString(), out discount))
                {
                    totalDiscount += discount;
                }

                if (row.Cells["TotalPrice"].Value != null && decimal.TryParse(row.Cells["TotalPrice"].Value.ToString(), out total))
                {
                    subTotal += total;
                }
            }

            subTotal += totalDiscount;
            totalPayable = subTotal - totalDiscount;

            // Assign values to labels in the Sale Summary
            lblTotalDiscountForBill.Text = totalDiscount.ToString("0.00");
            lblSubTotalForBill.Text = subTotal.ToString("0.00");
            lblTotalPayableForBill.Text = totalPayable.ToString("0.00");
        }


        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the PrintPage event is not added multiple times
                BillPrintDocument.PrintPage -= new PrintPageEventHandler(BillPrintDocument_PrintPage);
                BillPrintDocument.PrintPage += new PrintPageEventHandler(BillPrintDocument_PrintPage);

                // Assign the PrintDocument to PrintPreviewDialog
                BillPrintPreviewDialog.Document = BillPrintDocument;

                // Show Print Preview Dialog
                BillPrintPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BillPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontHeading = new Font("Arial", 14, FontStyle.Bold);
            Font fontSubHeading = new Font("Arial", 12, FontStyle.Bold);
            Font fontBody = new Font("Arial", 11, FontStyle.Regular);
            Font fontTotal = new Font("Arial", 12, FontStyle.Bold);

            int pageWidth = e.MarginBounds.Width;
            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top;
            int offsetY = 0;
            int lineHeight = 25;
            int tableRowHeight = 22;

            try
            {
                // Draw Logo
                string imagePath = @"E:\Projects\SmartStock\CompanyLogo.png";
                if (File.Exists(imagePath))
                {
                    Image logo = Image.FromFile(imagePath);
                    e.Graphics.DrawImage(logo, startX, startY, 120, 50);
                }

                // Draw Date Right-Aligned
                string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
                e.Graphics.DrawString($"Date: {currentDate}", fontSubHeading, Brushes.Black, startX + pageWidth - 150, startY);

                // System Title - Centered
                offsetY = 60;
                string title = "SmartStock - Advanced Inventory & Sales Management System";
                SizeF titleSize = e.Graphics.MeasureString(title, fontHeading);
                e.Graphics.DrawString(title, fontHeading, Brushes.Black, startX + (pageWidth - titleSize.Width) / 2, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + pageWidth, startY + offsetY);
                offsetY += lineHeight;

                // Invoice Details
                e.Graphics.DrawString($"Invoice #: {lblInoiceNoForBill.Text}", fontSubHeading, Brushes.Black, startX, startY + offsetY);
                offsetY += lineHeight;
                e.Graphics.DrawString($"Customer: {lblCutomerNameForBill.Text}", fontSubHeading, Brushes.Black, startX, startY + offsetY);
                offsetY += lineHeight;
                e.Graphics.DrawString($"Payment: {lblPaymentMethodForBill.Text}", fontSubHeading, Brushes.Black, startX, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + pageWidth, startY + offsetY);
                offsetY += lineHeight;

                // Column Headers - Distribute width dynamically
                int colProductX = startX;
                int colQtyX = startX + (int)(pageWidth * 0.40);
                int colUnitPriceX = startX + (int)(pageWidth * 0.55);
                int colDiscountX = startX + (int)(pageWidth * 0.70);
                int colTotalX = startX + (int)(pageWidth * 0.85);

                e.Graphics.DrawString("Product", fontSubHeading, Brushes.Black, colProductX, startY + offsetY);
                e.Graphics.DrawString("Qty", fontSubHeading, Brushes.Black, colQtyX, startY + offsetY);
                e.Graphics.DrawString("Unit Price", fontSubHeading, Brushes.Black, colUnitPriceX, startY + offsetY);
                e.Graphics.DrawString("Discount", fontSubHeading, Brushes.Black, colDiscountX, startY + offsetY);
                e.Graphics.DrawString("Total", fontSubHeading, Brushes.Black, colTotalX, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + pageWidth, startY + offsetY);
                offsetY += 5;

                // Loop through Products
                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    if (row.Cells["ProductName"].Value != null)
                    {
                        string product = row.Cells["ProductName"].Value.ToString();
                        string qty = row.Cells["quantity"].Value?.ToString() ?? "0";
                        string unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value ?? 0).ToString("0.00");
                        string discount = Convert.ToDecimal(row.Cells["Discount"].Value ?? 0).ToString("0.00");
                        string total = Convert.ToDecimal(row.Cells["totalPrice"].Value ?? 0).ToString("0.00");

                        e.Graphics.DrawString(product, fontBody, Brushes.Black, colProductX, startY + offsetY);
                        e.Graphics.DrawString(qty, fontBody, Brushes.Black, colQtyX, startY + offsetY);
                        e.Graphics.DrawString($"${unitPrice}", fontBody, Brushes.Black, colUnitPriceX, startY + offsetY);
                        e.Graphics.DrawString($"${discount}", fontBody, Brushes.Black, colDiscountX, startY + offsetY);
                        e.Graphics.DrawString($"${total}", fontBody, Brushes.Black, colTotalX, startY + offsetY);

                        offsetY += tableRowHeight;
                    }
                }

                offsetY += 10;
                e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + pageWidth, startY + offsetY);
                offsetY += lineHeight;

                // Totals Section (Right-Aligned)
                int totalLabelX = startX + (int)(pageWidth * 0.65);
                int totalAmountX = startX + (int)(pageWidth * 0.85);

                e.Graphics.DrawString("Sub Total:", fontSubHeading, Brushes.Black, totalLabelX, startY + offsetY);
                e.Graphics.DrawString($"${Convert.ToDecimal(lblSubTotalForBill.Text).ToString("0.00")}", fontTotal, Brushes.Black, totalAmountX, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawString("Total Discount:", fontSubHeading, Brushes.Black, totalLabelX, startY + offsetY);
                e.Graphics.DrawString($"${Convert.ToDecimal(lblTotalDiscountForBill.Text).ToString("0.00")}", fontTotal, Brushes.Black, totalAmountX, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawString("Total Payable:", fontSubHeading, Brushes.Black, totalLabelX, startY + offsetY);
                e.Graphics.DrawString($"${Convert.ToDecimal(lblTotalPayableForBill.Text).ToString("0.00")}", fontTotal, Brushes.Black, totalAmountX, startY + offsetY);
                offsetY += lineHeight;

                e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + pageWidth, startY + offsetY);
                offsetY += lineHeight;

                // Thank You Message - Centered
                string thankYou = "Thank you for your purchase!";
                SizeF thankYouSize = e.Graphics.MeasureString(thankYou, fontHeading);
                e.Graphics.DrawString(thankYou, fontHeading, Brushes.Black, startX + (pageWidth - thankYouSize.Width) / 2, startY + offsetY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                fontTotal.Dispose();
                fontBody.Dispose();
                fontSubHeading.Dispose();
                fontHeading.Dispose();
            }


        }



        private bool ValidateForm()
        {
            bool isvalid = true;
            if (drpdwnProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Select Product", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Unit Price is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                txtDiscount.Text = Convert.ToString(0);
            }

            return isvalid;
        }


        private bool ValidateFormForConfirmSale()
        {
            bool isvalid = true;

            if (drpdwnCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select Payment Method", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            return isvalid;
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
           

            if (ValidateForm())
            {
                if (dtList.Rows.Count == 0 || dtList==null)
                {       // Optional if needed
                    dtList.Columns.Add("ProductID", typeof(int));
                    dtList.Columns.Add("ProductName", typeof(string));
                    dtList.Columns.Add("Quantity", typeof(int));
                    dtList.Columns.Add("UnitPrice", typeof(decimal));
                    dtList.Columns.Add("Discount", typeof(decimal));
                    dtList.Columns.Add("TotalPrice", typeof(decimal));

                    dgvSale.DataSource = dtList; // Bind the table once
                    dgvSale.Columns["ProductID"].Visible = false;
                }


                // Get product data from controls
                int ProductId = Convert.ToInt32(drpdwnProduct.SelectedValue);
                string productName = drpdwnProduct.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                decimal discountpercentage = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : decimal.Parse(txtDiscount.Text);
                decimal discount = 0;
                decimal totalPrice = 0;
                if (discountpercentage > 0)
                {
                    decimal subtotal = quantity * unitPrice;
                    decimal discountAmount = (discountpercentage / 100) * subtotal;
                    totalPrice = subtotal - discountAmount;
                    discount = discountAmount;
                }
                else
                {
                    discount = 0;
                    totalPrice = quantity * unitPrice;
                }


                // Check if product already exists in DataGridView
                bool productExists = false;
                foreach (DataRow row in dtList.Rows)
                {
                    if (row["ProductName"].ToString() == productName)
                    {
                        // Product exists, update quantity and total
                        row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                        row["TotalPrice"] = (Convert.ToInt32(row["Quantity"]) * unitPrice) - discount;
                        productExists = true;
                        break;
                    }
                }

                // If product not found, add as new row
                if (!productExists)
                {
                    dtList.Rows.Add(ProductId, productName, quantity, unitPrice, discount, totalPrice);
                }

                // Refresh DataGridView (optional if DataSource is already set)
                dgvSale.Refresh();

                UpdateSaleSummary();
                ClearInputFields();
            }
        }



        private void btnConfirmSell_Click(object sender, EventArgs e)
        {
            if (dtList == null)
            {
                MessageBox.Show("Selete the Product by clicking on More? button", "Confirm Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateFormForConfirmSale())
            {
                if (dtList != null)
                {
                    Sale_Methods sm = new Sale_Methods();
                    int saleid = sm.MaxSaleID() + 1;

                    decimal NetAmount = 0;
                    decimal NetDiscount = 0;
                    foreach (DataRow dr in dtList.Rows)
                    {
                        SalesDetails sd = new SalesDetails();
                        sd.SaleID = saleid;
                        sd.ProductID = Convert.ToInt32(dr["ProductID"]);
                        sd.QuantitySold = Convert.ToInt32(dr["Quantity"]);
                        sd.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                        sd.Discount = Convert.ToDecimal(dr["Discount"]);
                        sd.IsDeleted = false;

                        SalesDetail_Methods sdm = new SalesDetail_Methods();
                        sdm.Insert(sd);


                        NetDiscount += Convert.ToDecimal(dr["Discount"]);
                        NetAmount += Convert.ToDecimal(dr["TotalPrice"]) + NetDiscount;

                    }

                    Sales s = new Sales();
                    s.InvoiceNo = txtInvoice.Text;
                    s.CustomerID = Convert.ToInt32(drpdwnCustomerName.SelectedValue);
                    s.SaleDate = Convert.ToDateTime(datetimeSale.Text);
                    s.TotalAmount = NetAmount;
                    s.Discount = NetDiscount;
                    s.PaymentMethod = Convert.ToString(drpdwnPaymentMethod.SelectedItem);
                    s.SoldBy = Session.UserId;
                    s.IsDeleted = false;

                    sm.Insert(s);
                    MessageBox.Show("Sale Confirmed!", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtList = null;
                    lblCutomerNameForBill.Text = string.Empty;
                    lblInoiceNoForBill.Text = string.Empty;
                    lblPaymentMethodForBill.Text = string.Empty;
                    lblSubTotalForBill.Text = string.Empty;
                    lblTotalDiscountForBill.Text = string.Empty;
                    lblTotalPayableForBill.Text = string.Empty;
                    dgvSale.DataSource=null;
                }
            }
            else
            {
                return;
            }

        }
    }


}
