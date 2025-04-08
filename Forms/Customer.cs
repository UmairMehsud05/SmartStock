using SmartStock.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class Customer : Form
    {
        int customerid;
        public Customer()
        {
            InitializeComponent();
        }


        private void Customer_Load(object sender, EventArgs e)
        {
            datetimeRegistrationDate.Text = DateTime.Now.ToShortDateString();

            DGVCustomer();
        }

        private void txtCustomerName_MouseEnter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.AliceBlue;
        }

        private void txtContact_MouseEnter(object sender, EventArgs e)
        {
            txtContact.BackColor = Color.AliceBlue;
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.AliceBlue;
        }

        private void txtAddress_MouseEnter(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.AliceBlue;
        }

        private void drpdwnCity_MouseEnter(object sender, EventArgs e)
        {
            drpdwnCity.BackColor = Color.AliceBlue;
        }

        private void drpdwnCustomerType_MouseEnter(object sender, EventArgs e)
        {
            drpdwnCustomerType.BackColor = Color.AliceBlue;
        }

        private void txtCustomerName_MouseLeave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.White;
        }

        private void txtContact_MouseLeave(object sender, EventArgs e)
        {
            txtContact.BackColor = Color.White;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void txtAddress_MouseLeave(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void drpdwnCity_MouseLeave(object sender, EventArgs e)
        {
            drpdwnCity.BackColor = Color.White;
        }

        private void drpdwnCustomerType_MouseLeave(object sender, EventArgs e)
        {
            drpdwnCustomerType.BackColor = Color.White;
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only alphabets and spaces are allowed.", txtCustomerName, 0, txtCustomerName.Height, 2000);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only numbers (0-9) are allowed.", txtContact, 0, txtContact.Height, 2000);

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                toolTip1.Show("❌ Invalid! Email format! Example: user@example.com", txtEmail, 0, txtEmail.Height, 2000);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' &&
        e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only letters, numbers, '@', '.', '-', and '_' are allowed.", txtEmail, 0, txtEmail.Height, 2000);

            }
        }

        private void DGVCustomer()
        {
            Customer_Methods cm = new Customer_Methods();
            List<Customers> c = cm.GetAllData();
            dgvCustomer.DataSource = c;
            dgvCustomer.Columns["CustomerID"].Visible = false;
            dgvCustomer.Columns["IsDeleted"].Visible = false;
            dgvCustomer.Columns["HasPurchased"].Visible = false;
        }


        private bool ValidateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Contact is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnCity.SelectedIndex == -1)
            {
                MessageBox.Show("City is required, select city.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnCustomerType.SelectedIndex == -1)
            {
                MessageBox.Show("Customer Type is required, Select Customer Type.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }

        private void ResetForm()
        {
            txtCustomerName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            drpdwnCity.SelectedIndex = -1;
            drpdwnCustomerType.SelectedIndex = -1;

            btnAddCustomer.Text = "Add";
            customerid = 0;
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Customers c = new Customers();
                Customer_Methods cm = new Customer_Methods();

                c.CustomerID = customerid;
                c.CustomerName = txtCustomerName.Text;
                c.Contact = txtContact.Text;
                c.Email = txtEmail.Text;
                c.Address = txtAddress.Text;
                c.City = Convert.ToString(drpdwnCity.SelectedItem);
                c.CustomerType = Convert.ToString(drpdwnCustomerType.SelectedItem);
                c.RegistrationDate = DateTime.Now;
                c.HasPurchased = false;
                c.IsDeleted = false;

                cm.InserOrUpdate(c);
                MessageBox.Show(customerid > 0 ? "Customer Updated": "Customer Added");
                ResetForm();
                DGVCustomer();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerid = Convert.ToInt32(dgvCustomer.Rows[e.ColumnIndex].Cells["CustomerID"].Value);
                Customer_Methods cm = new Customer_Methods();
                if (e.ColumnIndex == dgvCustomer.Columns["Edit"].Index)
                {
                    Customers c = cm.GetDataByID(customerid);
                    txtCustomerName.Text = c.CustomerName;
                    txtContact.Text = c.Contact;
                    txtEmail.Text = c.Email;
                    txtAddress.Text = c.Address;
                    drpdwnCity.SelectedItem = c.City;
                    drpdwnCustomerType.SelectedItem = c.CustomerType;
                    datetimeRegistrationDate.Text = Convert.ToString(c.RegistrationDate);
                    btnAddCustomer.Text = "Update";
                }
                else
                {
                    cm.DeleteCustomer(customerid);
                    MessageBox.Show("Customer Deleted");
                    DGVCustomer();
                }
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtCustomerSearch.Text.Trim().ToLower();

            Customer_Methods cm = new Customer_Methods();
            List<Customers> customerlist = cm.GetAllData();  // Fetch all categories

            // Filter the list using LINQ
            var filteredList = customerlist.Where(c =>
                string.IsNullOrEmpty(searchValue) ||
                c.CustomerName.ToLower().Contains(searchValue)
            ).ToList();

            // Bind filtered data (empty list will trigger custom drawing)
            dgvCustomer.DataSource = filteredList;

            // Refresh the DataGridView to trigger CellPainting event
            dgvCustomer.Refresh();
        }

        private void dgvCustomer_Paint(object sender, PaintEventArgs e)
        {
            if (dgvCustomer.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvCustomer.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvCustomer.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
