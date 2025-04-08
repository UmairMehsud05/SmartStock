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
    public partial class ManageUser : Form
    {
        int userid;
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            DGVUsers();
            LoadRoles();
        }


        private void LoadRoles()
        {
            Setting_Methods sm = new Setting_Methods();
            drpdwnAssignNewRole.DataSource = sm.GetRoles();
            drpdwnAssignNewRole.DisplayMember = "RoleName";
            drpdwnAssignNewRole.ValueMember = "RoleID";
        }

        private void DGVUsers()
        {
            User_Methods um = new User_Methods();
            dgvUserList.DataSource = um.GetAllUserData();
            dgvUserList.Columns["IsDeleted"].Visible = false;
            dgvUserList.Columns["PasswordHash"].Visible = false;
            dgvUserList.Columns["PasswordSalt"].Visible = false;
            dgvUserList.Columns["UserID"].Visible = false;
            dgvUserList.Columns["SecurityQuestion1"].Visible = false;
            dgvUserList.Columns["SecurityAnswer1"].Visible = false;
            dgvUserList.Columns["SecurityQuestion2"].Visible = false;
            dgvUserList.Columns["SecurityAnswer2"].Visible = false;
            dgvUserList.Columns["IsSecurityQuestionSet"].Visible = false;
            dgvUserList.Columns["ProfileImage"].Visible = false;
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userid = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserID"].Value);
                User_Methods um = new User_Methods(); 
                if (e.ColumnIndex == dgvUserList.Columns["Edit"].Index)
                {
                    User u = um.GetDataByID(userid);
                    txtSelectedUser.Text = u.FullName;
                }
                else if (e.ColumnIndex == dgvUserList.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                    bool isdeleted = um.Delete(userid);
                    if (isdeleted)
                    {
                            MessageBox.Show("User Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    }
                    
                }
            }
            
        }

        private bool ValidateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtSelectedUser.Text))
            {
                MessageBox.Show("Select User from DGV.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isvalid = false;
            }
            else if (drpdwnAssignNewRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select Any Role", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isvalid = false;
            }

            return isvalid;
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int roleid=Convert.ToInt32(drpdwnAssignNewRole.SelectedValue);

                User_Methods um = new User_Methods();
                bool isupdate = um.UpdateUserRole(userid, roleid);
                if (isupdate)
                {
                    MessageBox.Show("User's Role Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
