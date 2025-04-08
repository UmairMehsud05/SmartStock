using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmartStock.DAL;

namespace SmartStock.BLL
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int? RoleID { get; set; }
        public string SecurityQuestion1 { get; set; }
        public string SecurityAnswer1 { get; set; }
        public string SecurityQuestion2 { get; set; }
        public string SecurityAnswer2 { get; set; }
        public bool IsSecurityQuestionSet { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class User_Methods
    {
        private readonly DatabaseHelper db;

        public User_Methods()
        {
            db = new DatabaseHelper();
        }


        public void RegisterOrUpdate(User u)
        {
            SqlParameter[] prm = new SqlParameter[17];
            prm[0] = new SqlParameter("@Action", u.UserID > 0 ? DbAction.Update : DbAction.Insert);
            prm[1] = new SqlParameter("@UserID", u.UserID);
            prm[2] = new SqlParameter("@FullName", u.FullName);
            prm[3] = new SqlParameter("@Email", u.Email);
            prm[4] = new SqlParameter("@Contact", u.Contact);
            prm[5] = new SqlParameter("@PasswordHash", u.PasswordHash);
            prm[6] = new SqlParameter("@PasswordSalt", u.PasswordSalt);
            prm[7] = new SqlParameter("@RoleID", u.RoleID);
            prm[8] = new SqlParameter("@SecurityQuestion1", u.SecurityQuestion1);
            prm[9] = new SqlParameter("@SecurityAnswer1", u.SecurityAnswer1);
            prm[10] = new SqlParameter("@SecurityQuestion2", u.SecurityQuestion2);
            prm[11] = new SqlParameter("@SecurityAnswer2", u.SecurityAnswer2);
            prm[12] = new SqlParameter("@IsSecurityQuestionSet", u.IsSecurityQuestionSet);
            prm[13] = new SqlParameter("@ProfileImage", u.ProfileImage);
            prm[14] = new SqlParameter("@CreatedAt", u.CreatedAt);
            prm[15] = new SqlParameter("@LastUpdatedAt", u.LastUpdatedAt);
            prm[16] = new SqlParameter("@IsDeleted", u.IsDeleted);

            db.NonExecutableSp("sp_Users", prm);
        }


        public bool isEmailExist(string email)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("Action", DbAction.Select);
            prm[1] = new SqlParameter("Email", email);

            DataTable dt = db.ExecuteSp("sp_Users", prm);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public User GetDataByEmail(string email)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@Email", email);
            DataTable dt = db.ExecuteSp("sp_Users", prm);
            User ulist =null;
            if (dt.Rows.Count > 0)
            {
                ulist = new User();
                ulist.UserID=Convert.ToInt32(dt.Rows[0]["UserID"]);
                ulist.FullName = Convert.ToString(dt.Rows[0]["FullName"]);
                ulist.Email = Convert.ToString(dt.Rows[0]["Email"]);
                ulist.PasswordHash = Convert.ToString(dt.Rows[0]["PasswordHash"]);
                ulist.Contact = Convert.ToString(dt.Rows[0]["Contact"]);
                ulist.PasswordSalt = Convert.ToString(dt.Rows[0]["PasswordSalt"]);
                ulist.SecurityQuestion1 = Convert.ToString(dt.Rows[0]["SecurityQuestion1"]);
                ulist.SecurityAnswer1 = Convert.ToString(dt.Rows[0]["SecurityAnswer1"]);
                ulist.SecurityQuestion2 = Convert.ToString(dt.Rows[0]["SecurityQuestion2"]);
                ulist.SecurityAnswer2 = Convert.ToString(dt.Rows[0]["SecurityAnswer2"]);
                ulist.IsSecurityQuestionSet = Convert.ToBoolean(dt.Rows[0]["IsSecurityQuestionSet"]);
                ulist.ProfileImage = Convert.ToString(dt.Rows[0]["ProfileImage"]);
                ulist.CreatedAt = Convert.ToDateTime(dt.Rows[0]["CreatedAt"]);
                ulist.LastUpdatedAt = Convert.ToDateTime(dt.Rows[0]["LastUpdatedAt"]);
            }

            return ulist;

        }


        public User GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@UserID", id);
            DataTable dt = db.ExecuteSp("sp_Users", prm);
            User ulist = null;
            if (dt.Rows.Count > 0)
            {
                ulist = new User();
                ulist.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                ulist.FullName = Convert.ToString(dt.Rows[0]["FullName"]);
                ulist.Email = Convert.ToString(dt.Rows[0]["Email"]);
                ulist.PasswordHash = Convert.ToString(dt.Rows[0]["PasswordHash"]);
                ulist.Contact = Convert.ToString(dt.Rows[0]["Contact"]);
                ulist.PasswordSalt = Convert.ToString(dt.Rows[0]["PasswordSalt"]);
                ulist.SecurityQuestion1 = Convert.ToString(dt.Rows[0]["SecurityQuestion1"]);
                ulist.SecurityAnswer1 = Convert.ToString(dt.Rows[0]["SecurityAnswer1"]);
                ulist.SecurityQuestion2 = Convert.ToString(dt.Rows[0]["SecurityQuestion2"]);
                ulist.SecurityAnswer2 = Convert.ToString(dt.Rows[0]["SecurityAnswer2"]);
                ulist.IsSecurityQuestionSet = Convert.ToBoolean(dt.Rows[0]["IsSecurityQuestionSet"]);
                ulist.ProfileImage = Convert.ToString(dt.Rows[0]["ProfileImage"]);
                ulist.CreatedAt = Convert.ToDateTime(dt.Rows[0]["CreatedAt"]);
                ulist.LastUpdatedAt = Convert.ToDateTime(dt.Rows[0]["LastUpdatedAt"]);
            }

            return ulist;

        }





        public List<User> GetAllUserData()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@IsDeleted", 0);
            DataTable dt = db.ExecuteSp("sp_Users", prm);
            List<User> list = new List<User>();
            foreach(DataRow dr in dt.Rows)
            {
                User ulist = new User();
                ulist.UserID = Convert.ToInt32(dr["UserID"]);
                ulist.FullName = Convert.ToString(dr["FullName"]);
                ulist.Email = Convert.ToString(dr["Email"]);
                ulist.PasswordHash = Convert.ToString(dr["PasswordHash"]);
                ulist.Contact = Convert.ToString(dr["Contact"]);
                ulist.PasswordSalt = Convert.ToString(dr["PasswordSalt"]);
                ulist.SecurityQuestion1 = Convert.ToString(dr["SecurityQuestion1"]);
                ulist.SecurityAnswer1 = Convert.ToString(dr["SecurityAnswer1"]);
                ulist.SecurityQuestion2 = Convert.ToString(dr["SecurityQuestion2"]);
                ulist.SecurityAnswer2 = Convert.ToString(dr["SecurityAnswer2"]);
                ulist.IsSecurityQuestionSet = Convert.ToBoolean(dr["IsSecurityQuestionSet"]);
                ulist.ProfileImage = Convert.ToString(dr["ProfileImage"]);
                ulist.CreatedAt = Convert.ToDateTime(dr["CreatedAt"]);
                ulist.LastUpdatedAt = Convert.ToDateTime(dr["LastUpdatedAt"]);
                list.Add(ulist);
            }

            return list;

        }


        public bool SubmitSecurityQuestions(User u)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@Action", DbAction.Select);
            pr[1] = new SqlParameter("@UserID", u.UserID);
            DataTable dt = db.ExecuteSp("sp_Users", pr);
            if (dt.Rows.Count > 0)
            {
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Action", DbAction.UpdateSecurityQuestions);
            prm[1] = new SqlParameter("@SecurityQuestion1", u.SecurityQuestion1);
            prm[2] = new SqlParameter("@SecurityAnswer1", u.SecurityAnswer1);
            prm[3] = new SqlParameter("@SecurityQuestion2", u.SecurityQuestion2);
            prm[4] = new SqlParameter("@SecurityAnswer2", u.SecurityAnswer2);
            prm[5] = new SqlParameter("@UserID", u.UserID);
                db.NonExecutableSp("sp_Users", prm);
            return true;
            }
            else
            {
                return false;
            }
           
        }


        public bool ResetPassword(int id, string password)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Action", DbAction.ResetPassword);
            prm[1] = new SqlParameter("@UserID", id);
            prm[2] = new SqlParameter("@PasswordHash", password);
            db.NonExecutableSp("sp_Users", prm);
            return true;
        }


        public bool UpdateProfile(User u)
        {
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Action", DbAction.UpdateProfile);
            prm[1] = new SqlParameter("@FullName", u.FullName);
            prm[2] = new SqlParameter("@Email", u.Email);
            prm[3] = new SqlParameter("@Contact", u.Contact);
            prm[4] = new SqlParameter("@ProfileImage", u.ProfileImage);
            prm[5] = new SqlParameter("@UserID", u.UserID);
            db.NonExecutableSp("sp_Users", prm);
            return true;
        }


        public bool Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Delete);
            prm[1] = new SqlParameter("@UserID", id);

            int rowAffected = db.NonExecutableSp("sp_Users", prm);

            if (rowAffected>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool UpdateUserRole(int uid,int rid)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",8), //8 Update User Role
                new SqlParameter("@RoleID",rid),
                new SqlParameter("@UserID",uid)
            };

            int rowAffected = db.NonExecutableSp("sp_Users", prm);
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
