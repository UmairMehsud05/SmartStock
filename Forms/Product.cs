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
    public partial class Product : Form
    {
        int productid;
        Main mainform;
        public Product(Main ma)
        {
            InitializeComponent();
            mainform = ma;

        }

        private void Product_Load(object sender, EventArgs e)
        {
            DGVProduct();
            categoryload();
        }


        private void categoryload()
        {
            Categories_Methods cm = new Categories_Methods();
            List<Categories> c = cm.GetAllCategories();
            drpdwnCategory.DataSource = c;
            drpdwnCategory.DisplayMember = "CategoryName";
            drpdwnCategory.ValueMember = "CategoryID";
        }

        private void txtProduct_MouseEnter(object sender, EventArgs e)
        {
            txtProduct.BackColor = Color.AliceBlue;
        }

        private void drpdwnCategory_MouseEnter(object sender, EventArgs e)
        {
            drpdwnCategory.BackColor = Color.AliceBlue;
        }

        private void txtPrice_MouseEnter(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.AliceBlue;
        }

        private void txtDescription_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.AliceBlue;
        }


        private void txtProduct_MouseLeave(object sender, EventArgs e)
        {
            txtProduct.BackColor = Color.White;
        }

        private void drpdwnCategory_MouseLeave(object sender, EventArgs e)
        {
            drpdwnCategory.BackColor = Color.White;
        }

        private void txtPrice_MouseLeave(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
        }

        private void txtDescription_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.White;
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only alphabets and spaces are allowed.", txtProduct, 0, txtProduct.Height, 2000);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid price (e.g., 100.50)", txtPrice, 0, txtPrice.Height, 2000);
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) //only one decimal point is allowed
            {
                e.Handled = true;
            }
        }

        private void txtStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Enter a valid stock quantity (e.g., 10)", txtStockQuantity, 0, txtStockQuantity.Height, 2000);
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '/' || e.KeyChar == '\\')
            {
                e.Handled = true;
                toolTip1.Show("❌ Avoid special symbols like <, >, /, \\ in the description.", txtDescription, 0, txtDescription.Height, 2000);
            }
        }


        private bool validateForm()
        {
            bool isvalid = true;
            int quantity;

            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("Product is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category is required, Please Select Category.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtStockQuantity.Text) ||
                !int.TryParse(txtStockQuantity.Text, out quantity) ||
                quantity < 1)
            {
                MessageBox.Show("Quantity is required and must be 1 or more.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }


        private void DGVProduct()
        {
            Product_Methods pm = new Product_Methods();
            dgvProduct.DataSource = pm.GetAllData();
            dgvProduct.Columns["IsDeleted"].Visible = false;
            dgvProduct.Columns["LowStockThreshold"].Visible = false;
            dgvProduct.Columns["ProductID"].Visible = false;
        }

        private void ResetForm()
        {
            txtProduct.Text = string.Empty;
            drpdwnCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            txtStockQuantity.Text = string.Empty;
            txtDescription.Text = string.Empty;

            btnAddProduct.Text = "Add";
            productid = 0;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Products prd = new Products();
                Product_Methods pm = new Product_Methods();

                prd.ProductID = productid;
                prd.ProductName = txtProduct.Text;
                prd.CategoryID = Convert.ToInt32(drpdwnCategory.SelectedValue);
                prd.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
                prd.Price = Convert.ToDecimal(txtPrice.Text);
                prd.Description = txtDescription.Text;
                prd.CreatedAt = DateTime.Now;
                prd.IsDeleted = false;

                bool IsInsertOrUpdate = pm.InsertOrUpdate(prd);

                if (!IsInsertOrUpdate)
                {
                    MessageBox.Show("Product already exists!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(productid > 0 ? "Product Updated" : "Product Added");
                ResetForm();
                DGVProduct();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productid = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value);
                Product_Methods pm = new Product_Methods();
                if (e.ColumnIndex == dgvProduct.Columns["Edit"].Index)
                {

                    Products p = pm.GetDataByID(productid);
                    txtProduct.Text = p.ProductName;
                    drpdwnCategory.SelectedValue = p.CategoryID;
                    txtPrice.Text = Convert.ToString(p.Price);
                    txtStockQuantity.Text = Convert.ToString(p.StockQuantity);
                    txtDescription.Text = p.Description;
                    btnAddProduct.Text = "Update";
                }
                else if (e.ColumnIndex == dgvProduct.Columns["Delete"].Index)
                {
                    pm.Delete(productid);
                    MessageBox.Show("Product Deleted");
                    DGVProduct();
                }
                else if (e.ColumnIndex == dgvProduct.Columns["View"].Index)
                {
                    mainform.LoadForm(new ProductDetails(productid, mainform));
                }
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtProductSearch.Text.Trim().ToLower();

            Product_Methods pm = new Product_Methods();
            List<Products> productList = pm.GetAllData();  // Fetch all categories

            // Filter the list using LINQ
            var filteredList = productList.Where(c =>
                string.IsNullOrEmpty(searchValue) ||
                c.ProductName.ToLower().Contains(searchValue)
            ).ToList();

            // Bind filtered data (empty list will trigger custom drawing)
            dgvProduct.DataSource = filteredList;

            // Refresh the DataGridView to trigger CellPainting event
            dgvProduct.Refresh();
        }

        private void dgvProduct_Paint(object sender, PaintEventArgs e)
        {
            if (dgvProduct.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvProduct.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvProduct.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
