using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SmartStock.BLL;

namespace SmartStock.Forms
{
    public partial class Supplier : Form
    {
        int supplierid;

        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            DGVSupplier();
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only alphabets and spaces are allowed.", txtSupplierName, 0, txtSupplierName.Height, 2000);
            }
        }

        private void txtCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only alphabets, numbers and spaces are allowed.", txtCompanyName, 0, txtCompanyName.Height, 2000);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only numeric values are allowed!", txtContact, 0, txtContact.Height, 2000);
            }
        }
        

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' &&
                e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only letters, numbers, spaces, ',', '.', and '-' are allowed!", txtAddress, 0, txtAddress.Height, 2000);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                toolTip1.Show("❌ Invalid! Email format! Example: user@example.com", txtEmail, 0, txtEmail.Height, 2000);
            }
        }

        private void txtSupplierName_MouseEnter(object sender, EventArgs e)
        {
            txtSupplierName.BackColor = Color.AliceBlue;
        }

        private void txtCompanyName_MouseEnter(object sender, EventArgs e)
        {
            txtCompanyName.BackColor = Color.AliceBlue;
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

        private void txtSupplierName_MouseLeave(object sender, EventArgs e)
        {
            txtSupplierName.BackColor = Color.White;
        }

        private void txtCompanyName_MouseLeave(object sender, EventArgs e)
        {
            txtCompanyName.BackColor = Color.White;
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


        private void DGVSupplier()
        {
            Supplier_Methods sm = new Supplier_Methods();
            dgvSupplier.DataSource = sm.GetAllData();
            dgvSupplier.Columns["SupplierID"].Visible = false;
            dgvSupplier.Columns["IsDeleted"].Visible = false;
        }



        private bool validateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Contact is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }


        private void ResetForm()
        {
            txtSupplierName.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;

            btnAddSupplier.Text = "Add";
            supplierid = 0;
        }


        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Suppliers s = new Suppliers();
                s.SupplierID = supplierid;
                s.SupplierName = txtSupplierName.Text;
                s.CompanyName = txtCompanyName.Text;
                s.Contact = txtContact.Text;
                s.Email = txtEmail.Text;
                s.Address = txtAddress.Text;
                s.CreatedAt = DateTime.Now;
                s.IsDeleted = false;

                Supplier_Methods sm = new Supplier_Methods();
                bool Isinsertorupdate = sm.InsertOrUpdate(s);

                if (!Isinsertorupdate)
                {
                    MessageBox.Show("Supplier already exists", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(supplierid > 0 ? "Supplier Updated" : "Supplier Added");
                ResetForm();
                DGVSupplier();
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                supplierid = Convert.ToInt32(dgvSupplier.Rows[e.ColumnIndex].Cells["SupplierID"].Value);
                Supplier_Methods sm = new Supplier_Methods();

                if (e.ColumnIndex == dgvSupplier.Columns["Edit"].Index)
                {
                    Suppliers s = sm.GetDataByID(supplierid);
                    txtSupplierName.Text = s.SupplierName;
                    txtCompanyName.Text = s.CompanyName;
                    txtContact.Text = s.Contact;
                    txtEmail.Text = s.Email;
                    txtAddress.Text = s.Address;

                    btnAddSupplier.Text = "Update";
                }
                else if(e.ColumnIndex == dgvSupplier.Columns["Delete"].Index)
                {
                    sm.DeteleSupplier(supplierid);
                    MessageBox.Show("Supplier Deleted");
                    DGVSupplier();
                }
            }
        }

        private void txtSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSupplierSearch.Text.Trim().ToLower();

            Supplier_Methods sm = new Supplier_Methods();
            List<Suppliers> supplierList = sm.GetAllData();  // Fetch all categories

            // Filter the list using LINQ
            var filteredList = supplierList.Where(c =>
                string.IsNullOrEmpty(searchValue) ||
                c.SupplierName.ToLower().Contains(searchValue)
            ).ToList();

            // Bind filtered data (empty list will trigger custom drawing)
            dgvSupplier.DataSource = filteredList;

            // Refresh the DataGridView to trigger CellPainting event
            dgvSupplier.Refresh();
        }

        private void dgvSupplier_Paint(object sender, PaintEventArgs e)
        {
            if (dgvSupplier.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvSupplier.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvSupplier.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
