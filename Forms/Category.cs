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
    public partial class Category : Form
    {
        int categoryid;

        public Category()
        {
            InitializeComponent();
        }


        private void Category_Load(object sender, EventArgs e)
        {
            DGVData();
        }

        // ------------------------------------------ Hover For Input Fields ----------------------------------------------

        private void txtCategory_MouseEnter(object sender, EventArgs e)
        {
            txtCategory.BackColor = Color.AliceBlue;
        }

        private void txtCategory_MouseLeave(object sender, EventArgs e)
        {
            txtCategory.BackColor = Color.White;
        }

        private void btnAddCategory_MouseEnter(object sender, EventArgs e)
        {
            btnAddCategory.BackColor = Color.AliceBlue;
        }

        private void txtCategorySearch_MouseEnter(object sender, EventArgs e)
        {
            txtCategorySearch.BackColor = Color.AliceBlue;
        }

        private void txtCategorySearch_MouseLeave(object sender, EventArgs e)
        {
            txtCategorySearch.BackColor = Color.White;
        }


        // ------------------------------------------ Characters Restriction For Input Fields ----------------------------------------------


        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true; // Block the invalid character
                toolTip1.Show("❌ Invalid! Only alphabets and spaces are allowed.", txtCategory, 0, txtCategory.Height, 2000);
            }
        }


        // ------------------------------------------Check Validation for Input Fields if Empty or not ----------------------------------------------


        private bool ValidateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }


        // ------------------------------------------ Clear Fields ----------------------------------------------
        
        private void ResetForm()
        {
            txtCategory.Text = string.Empty;
            categoryid = 0;
            btnAddCategory.Text = "Add";
        }
        // ------------------------------------------ Click's button ----------------------------------------------

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Categories c = new Categories();
                Categories_Methods cm = new Categories_Methods();

                c.CategoryID = categoryid;
                c.CategoryName = txtCategory.Text;
                c.IsDeleted = false;
                
                bool IsCategoryExists = cm.InsertOrUpdate(c);

                if (!IsCategoryExists)
                {
                    MessageBox.Show("Category already exists!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show(categoryid > 0 ? "Category Updated" : "Category Added");
                ResetForm();
                DGVData();
            }
        }

        private void DGVData()
        {
            Categories_Methods cm = new Categories_Methods();
            dgvCategory.DataSource = cm.GetAllCategories();
            dgvCategory.Columns["IsDeleted"].Visible = false;
            dgvCategory.Columns["CategoryID"].Visible = false;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["CategoryID"].Value);
                Categories_Methods cm = new Categories_Methods();

                if (e.ColumnIndex == dgvCategory.Columns["Edit"].Index)
                {
                    Categories c = cm.GetDataByID(id);
                    txtCategory.Text = c.CategoryName;
                    categoryid = c.CategoryID;
                    btnAddCategory.Text = "Update";
                }
                else if (e.ColumnIndex == dgvCategory.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                    cm.DeleteCategory(id);
                    MessageBox.Show("Category Deleted.");
                    DGVData();
                    }
                }
            }
        }

        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtCategorySearch.Text.Trim().ToLower();

            Categories_Methods cm = new Categories_Methods();
            List<Categories> categoryList = cm.GetAllCategories();  // Fetch all categories

            // Filter the list using LINQ
            var filteredList = categoryList.Where(c =>
                string.IsNullOrEmpty(searchValue) ||
                c.CategoryName.ToLower().Contains(searchValue)
            ).ToList();

            // Bind filtered data (empty list will trigger custom drawing)
            dgvCategory.DataSource = filteredList;

            // Refresh the DataGridView to trigger CellPainting event
            dgvCategory.Refresh();
        }

        private void dgvCategory_Paint(object sender, PaintEventArgs e)
        {
            if (dgvCategory.Rows.Count == 0)  // Check if DataGridView is empty
            {
                using (Graphics g = e.Graphics)
                {
                    string message = "No Data Found";
                    Font font = new Font("Arial", 14, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(message, font);
                    PointF location = new PointF(
                        (dgvCategory.Width - textSize.Width) / 2,  // Center horizontally
                        (dgvCategory.Height - textSize.Height) / 2  // Center vertically
                    );

                    g.DrawString(message, font, Brushes.Gray, location);
                }
            }
        }
    }
}
