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

namespace SmartStock.Forms
{
    public partial class Purchase : Form
    {
        int totalcost;


        public Purchase()
        {
            InitializeComponent();
        }
        
        private void Purchase_Load(object sender, EventArgs e)
        {
            txtPurchasedBy.Text = Session.Name;
            DGVPurchase();
            ProductLoads();
            SupplierLoads();
        }

        public void ProductLoads()
        {
            Product_Methods pm = new Product_Methods();
            List<Products> p = pm.GetAllData();
            drpdwnProduct.DataSource = p;
            drpdwnProduct.DisplayMember = "ProductName";
            drpdwnProduct.ValueMember = "ProductID";

        }


        public void SupplierLoads()
        {
            Supplier_Methods sm = new Supplier_Methods();
            List<Suppliers> s = sm.GetAllData();
            drpdwnSupplier.DataSource = s;
            drpdwnSupplier.DisplayMember = "SupplierName";
            drpdwnSupplier.ValueMember = "SupplierID";
        }

        public void CalculateTotalCost()
        {
            int qty, price;

            qty = Convert.ToInt32(txtQuantity.Value);
            price = string.IsNullOrWhiteSpace(txtUnitPrice.Text) ? 0 : Convert.ToInt32(txtUnitPrice.Text);
            totalcost = qty * price;
            txtTotalCost.Text = Convert.ToString(totalcost);
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                toolTip1.Show("❌ Invalid! Enter a valid Quantity value (e.g., 10)", txtQuantity, 0, txtQuantity.Height, 2000);
            }
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

        private void drpdwnProduct_MouseEnter(object sender, EventArgs e)
        {
            drpdwnProduct.BackColor = Color.AliceBlue;
        }

        private void drpdwnSupplier_MouseEnter(object sender, EventArgs e)
        {
            drpdwnSupplier.BackColor = Color.AliceBlue;
        }

        private void txtUnitPrice_MouseEnter(object sender, EventArgs e)
        {
            txtUnitPrice.BackColor = Color.AliceBlue;
        }

        private void txtTotalCost_MouseEnter(object sender, EventArgs e)
        {
            txtTotalCost.BackColor = Color.AliceBlue;
        }

        private void datetimePurchase_MouseEnter(object sender, EventArgs e)
        {
            datetimePurchase.BackColor = Color.AliceBlue;
        }

        private void drpdwnProduct_MouseLeave(object sender, EventArgs e)
        {
            drpdwnProduct.BackColor = Color.White;
        }

        private void drpdwnSupplier_MouseLeave(object sender, EventArgs e)
        {
            drpdwnSupplier.BackColor = Color.White;
        }

        private void txtUnitPrice_MouseLeave(object sender, EventArgs e)
        {
            txtUnitPrice.BackColor = Color.White;
        }

        private void txtTotalCost_MouseLeave(object sender, EventArgs e)
        {
            txtTotalCost.BackColor = Color.White;
        }

        private void datetimePurchase_MouseLeave(object sender, EventArgs e)
        {
            datetimePurchase.BackColor = Color.White;
        }

        private void DGVPurchase()
        {
            Purchase_Methods pm = new Purchase_Methods();
            dgvPurchase.DataSource = pm.GetAllData();
            dgvPurchase.Columns["PurchaseID"].Visible = false;
            dgvPurchase.Columns["ProductID"].Visible = false;
            dgvPurchase.Columns["SupplierID"].Visible = false;
            dgvPurchase.Columns["IsDeleted"].Visible = false;
            dgvPurchase.Columns["PurchasedBy"].Visible = false;
            dgvPurchase.Columns["CategoryName"].Visible = false;
        }


        private bool ValidateForm()
        {
            bool isvalid = true;
            if (drpdwnProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Select Product");
                isvalid = false;
            }
            else if (drpdwnSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Select Supplier");
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity is required.");
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Price is required.");
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity is required.");
                isvalid = false;
            }

            return isvalid;
        }


        private void ResetForm()
        {
            drpdwnProduct.SelectedIndex = -1;
            drpdwnSupplier.SelectedIndex = -1;
            txtQuantity.Text = "0";
            txtUnitPrice.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
            txtPurchasedBy.Text = string.Empty;
        }


        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Purchases p = new Purchases();
                Purchase_Methods pm = new Purchase_Methods();
                p.ProductID = Convert.ToInt32(drpdwnProduct.SelectedValue);
                p.SupplierID = Convert.ToInt32(drpdwnSupplier.SelectedValue);
                p.QuantityPurchased = Convert.ToInt32(txtQuantity.Text);
                p.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                p.PurchaseDate = DateTime.Now;
                p.PurchasedBy = Session.UserId;
                p.IsDeleted = false;

                pm.Insert(p);
                MessageBox.Show("Purchase Added");
                ResetForm();
                DGVPurchase();
            }
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int purchaseid = Convert.ToInt32(dgvPurchase.Rows[e.ColumnIndex].Cells["PurchaseID"].Value);
                if (e.ColumnIndex == dgvPurchase.Columns["Delete"].Index)
                {
                    Purchase_Methods pm = new Purchase_Methods();
                    pm.DeletePurchase(purchaseid);
                    MessageBox.Show("Purchase Deleted");
                    DGVPurchase();
                }
            }
        }

        private void txtPurchaseSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtPurchaseSearch.Text.Trim().ToLower();  // Get search value

            Purchase_Methods pm = new Purchase_Methods();
            List<Purchases> purchaseList = pm.GetAllData();  // Fetch all purchase data

            // Filter using LINQ (search in ProductName, Supplier, and PurchasedBy)
            var filteredList = purchaseList.Where(p =>
                string.IsNullOrEmpty(searchValue) ||
                p.ProductName.ToLower().Contains(searchValue) ||  // Search by Product Name
                p.SupplierName.ToLower().Contains(searchValue) // Search by Supplier Name
            ).ToList();

            // Bind filtered data to DataGridView
            dgvPurchase.DataSource = filteredList;

            // Refresh DataGridView to apply changes
            dgvPurchase.Refresh();
        }

        private void dgvPurchase_Paint(object sender, PaintEventArgs e)
        {
            if (dgvPurchase.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvPurchase.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvPurchase.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
