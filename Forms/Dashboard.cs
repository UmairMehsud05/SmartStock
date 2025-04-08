using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SmartStock.BLL;

namespace SmartStock.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            TodaySales();
            TodayPurchases();
            TodayTransactions();

            totalSales();
            totaltransactions();
            totalProducts();
            totalPurchase();
            totalCategories();
            totalSuppliers();
            totalCustomers();
        }
        

        private void totalSales()
        {
            Sale_Methods sm = new Sale_Methods();
            List<Sales> s = sm.GetAllData();
            if (s.Count == 0)
                lblTotalSales.Text = "0";
            else
                lblTotalSales.Text = s.Count.ToString();
        }

        private void totaltransactions()
        {
            Transaction_Methods tm = new Transaction_Methods();
            List<Transactions> t = tm.GetAllData();
            if (t.Count == 0)
                lblTotalTransactions.Text = "0";
            else
                lblTotalTransactions.Text = t.Count.ToString();
        }
        private void totalProducts()
        {
            Product_Methods pm = new Product_Methods();
            List<Products> p = pm.GetAllData();
            if (p.Count == 0)
                lblTotalProducts.Text = "0";
            else
                lblTotalProducts.Text = p.Count.ToString();
        }
        private void totalPurchase()
        {
            Purchase_Methods pm = new Purchase_Methods();
            List<Purchases> p = pm.GetAllData();
            if (p.Count == 0)
                lblTotalPurchases.Text = "0";
            else
                lblTotalPurchases.Text = p.Count.ToString();
        }
        private void totalCategories()
        {
            Categories_Methods cm = new Categories_Methods();
            List<Categories> c = cm.GetAllCategories();
            if (c.Count == 0)
                lblTotalCategories.Text = "0";
            else
                lblTotalCategories.Text = c.Count.ToString();
        }
        private void totalSuppliers()
        {
            Supplier_Methods sm = new Supplier_Methods();
            List<Suppliers> s = sm.GetAllData();
            if (s.Count == 0)
                lblTotalSuppliers.Text = "0";
            else
                lblTotalSuppliers.Text = s.Count.ToString();
        }
        private void totalCustomers()
        {
            Customer_Methods cm = new Customer_Methods();
            List<Customers> c = cm.GetAllData();
            if (c.Count == 0)
                lblTotalCustomers.Text = "0";
            else
                lblTotalCustomers.Text = c.Count.ToString();
        }


        private void TodaySales()
        {
            Sale_Methods sm = new Sale_Methods();
            dgvTodaySales.DataSource = sm.GetTodayAllData();
            dgvTodaySales.Columns["CustomerID"].Visible = false;
            dgvTodaySales.Columns["IsDeleted"].Visible = false;
            dgvTodaySales.Columns["SoldBy"].Visible = false;
            dgvTodaySales.Columns["SaleID"].Visible = false;
        }


        private void TodayPurchases()
        {
            Purchase_Methods pm = new Purchase_Methods();
            dgvTodayPurchases.DataSource = pm.GetTodaysAllData();
            dgvTodayPurchases.Columns["PurchaseID"].Visible = false;
            dgvTodayPurchases.Columns["ProductID"].Visible = false;
            dgvTodayPurchases.Columns["SupplierID"].Visible = false;
            dgvTodayPurchases.Columns["IsDeleted"].Visible = false;
            dgvTodayPurchases.Columns["PurchasedBy"].Visible = false;
            dgvTodayPurchases.Columns["CategoryName"].Visible = false;
        }



        private void TodayTransactions()
        {
            Transaction_Methods tm = new Transaction_Methods();
            dgvTodayTransactions.DataSource = tm.GetTodaysAllData();
            dgvTodayTransactions.Columns["CustomerID"].Visible = false;
            dgvTodayTransactions.Columns["IsDeleted"].Visible = false;
        }



        private void dgvTodaySales_Paint(object sender, PaintEventArgs e)
        {
            if (dgvTodaySales.Rows.Count == 0)  // Check if DataGridView is empty
            {
                dgvTodaySales.DataSource = null;
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvTodaySales.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvTodaySales.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }

        private void dgvTodayPurchases_Paint(object sender, PaintEventArgs e)
        {
            if (dgvTodayPurchases.Rows.Count == 0)  // Check if DataGridView is empty
            {
                dgvTodayPurchases.DataSource = null;

                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvTodayPurchases.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvTodayPurchases.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }

        private void dgvTodayTransactions_Paint(object sender, PaintEventArgs e)
        {
            if (dgvTodayTransactions.Rows.Count == 0)  // Check if DataGridView is empty
            {
                dgvTodayTransactions.DataSource = null;

                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvTodayTransactions.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvTodayTransactions.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
