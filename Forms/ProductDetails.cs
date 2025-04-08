using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.BLL;

namespace SmartStock.Forms
{
    public partial class ProductDetails : Form
    {
        int ProductId = 0;
        private Main mainform;
        public ProductDetails(int productid, Main m)
        {
            InitializeComponent();
            ProductId = productid;
            mainform = m;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            ProductData();
            DGVProductPurchase();
        }

        private void ProductData()
        {
            Products p = new Products();
            Product_Methods pm = new Product_Methods();
            p = pm.GetDataByID(ProductId);

            if (p != null)
            {
            lblProductName.Text = p.ProductName;
            lblCategoryName.Text = Convert.ToString(p.CategoryName);
            lblProductStock.Text = Convert.ToString(p.StockQuantity);
            lblProductPrice.Text = Convert.ToString(p.Price);
            lblProductDescription.Text = Convert.ToString(p.Description);
            }
            
        }
        
        private void DGVProductPurchase()
        {
            Purchase_Methods prm = new Purchase_Methods();
            Purchases pr = prm.GetDataByProductID(ProductId); // Single record

            if (pr != null)
            {
                List<Purchases> purchaseList = new List<Purchases>();
                purchaseList.Add(pr); // Add the single record into the list
                dgvProductPurchaseHistory.DataSource = purchaseList;
                dgvProductPurchaseHistory.Columns["ProductID"].Visible = false;
                dgvProductPurchaseHistory.Columns["SupplierID"].Visible = false;
                dgvProductPurchaseHistory.Columns["PurchaseID"].Visible = false;
                dgvProductPurchaseHistory.Columns["PurchasedBy"].Visible = false;
                dgvProductPurchaseHistory.Columns["IsDeleted"].Visible = false;

                dgvProductPurchaseHistory.Columns["ProductName"].DisplayIndex = 0;
                dgvProductPurchaseHistory.Columns["CategoryName"].DisplayIndex = 1;
                dgvProductPurchaseHistory.Columns["SupplierName"].DisplayIndex = 2;
                dgvProductPurchaseHistory.Columns["CompanyName"].DisplayIndex = 3;
                dgvProductPurchaseHistory.Columns["QuantityPurchased"].DisplayIndex = 4;
                dgvProductPurchaseHistory.Columns["UnitPrice"].DisplayIndex = 5;
                dgvProductPurchaseHistory.Columns["PurchaseDate"].DisplayIndex = 6;
                dgvProductPurchaseHistory.Columns["NamePurchasedBy"].DisplayIndex = 7;

                dgvProductPurchaseHistory.Columns["ProductName"].HeaderText = "Product";
                dgvProductPurchaseHistory.Columns["CategoryName"].HeaderText = "Category";
                dgvProductPurchaseHistory.Columns["SupplierName"].HeaderText = "Supplier";
                dgvProductPurchaseHistory.Columns["CompanyName"].HeaderText = "Company";
                dgvProductPurchaseHistory.Columns["QuantityPurchased"].HeaderText = "Quantity";
                dgvProductPurchaseHistory.Columns["UnitPrice"].HeaderText = "Price";
                dgvProductPurchaseHistory.Columns["PurchaseDate"].HeaderText = "Date";
                dgvProductPurchaseHistory.Columns["NamePurchasedBy"].HeaderText = "Purchased By";
            }
        }
        


        private void btnBackToProductForm_Click(object sender, EventArgs e)
        {
            mainform.LoadForm(new Product(mainform));
        }

        private void dgvProductPurchaseHistory_Paint(object sender, PaintEventArgs e)
        {
            if (dgvProductPurchaseHistory.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvProductPurchaseHistory.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvProductPurchaseHistory.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
