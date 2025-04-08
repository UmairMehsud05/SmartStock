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
    public class Settings
    {
        public int SettingID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public decimal TaxPercentage { get; set; }
        public string Currency { get; set; }
        public bool EnableLowStockAlerts { get; set; }
        public bool IsDeleted { get; set; }

    }


    public class Setting_Methods
    {
        private readonly DatabaseHelper db;

        public Setting_Methods()
        {
            db = new DatabaseHelper();
        }


        public bool InsertOrUpdate(Settings s)
        {

            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@Action", DbAction.Select);
            pr[1] = new SqlParameter("@IsDeleted", 0);

            DataTable dt = db.ExecuteSp("sp_Settings", pr);


            SqlParameter[] prm = new SqlParameter[8];


            if (dt.Rows.Count > 0)
            {
                s.SettingID = Convert.ToInt32(dt.Rows[0]["SettingID"]);
                prm[0] = new SqlParameter("@Action", DbAction.Update);
                prm[1] = new SqlParameter("@SettingID", s.SettingID);
            }
            else
            {
                prm[0] = new SqlParameter("@Action", DbAction.Insert);
                prm[1] = new SqlParameter("@SettingID", s.SettingID);
            }

            prm[2] = new SqlParameter("@CompanyName", s.CompanyName);
            prm[3] = new SqlParameter("@CompanyLogo", s.CompanyLogo);
            prm[4] = new SqlParameter("@TaxPercentage", s.TaxPercentage);
            prm[5] = new SqlParameter("@Currency", s.Currency);
            prm[6] = new SqlParameter("@EnableLowStockAlerts", s.EnableLowStockAlerts);
            prm[7] = new SqlParameter("@IsDeleted", s.IsDeleted);

            db.NonExecutableSp("sp_Settings", prm);


            if (s.SettingID == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Settings GetSettingData()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@IsDeleted", 0);

            DataTable dt = db.ExecuteSp("sp_Settings", prm);
            Settings s = null;
            if (dt.Rows.Count > 0)
            {
                s = new Settings();
                s.SettingID = Convert.ToInt32(dt.Rows[0]["SettingID"]);
                s.CompanyName = Convert.ToString(dt.Rows[0]["CompanyName"]);
                s.CompanyLogo = Convert.ToString(dt.Rows[0]["CompanyLogo"]);
                s.TaxPercentage = Convert.ToDecimal(dt.Rows[0]["TaxPercentage"]);
                s.Currency = Convert.ToString(dt.Rows[0]["Currency"]);
                s.EnableLowStockAlerts = Convert.ToBoolean(dt.Rows[0]["EnableLowStockAlerts"]);
                s.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }
            return s;
        }



        //-------------------------------------------------------------------------------------------------



        public DataTable GetRoles()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Roles", prm);
            return dt;
        }
        

        //-------------------------------------------------------------------------------------------------



        public DataTable GetPermissionTypes()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_PermissionTypes", prm);
            return dt;
        }



        public bool SaveRolePermission(int roleID, List<int> permissionTypeIDs)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",5), //Delete 
                new SqlParameter("@RoleID",roleID)
            };

            DataTable dt = db.ExecuteSp("sp_Permissions", prm);


            foreach (int permissionTypeID in permissionTypeIDs)
            {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@Action", DbAction.Insert);
                parameters[1] = new SqlParameter("@RoleID", roleID);
                parameters[2] = new SqlParameter("@PermissionTypeID", permissionTypeID);
                parameters[3] = new SqlParameter("@CanAccess", 1);
                parameters[4] = new SqlParameter("@IsDeleted", 0);

                int result = db.NonExecutableSp("sp_Permissions", parameters);
                if (result <= 0)
                {
                    return false; // If one fails, return false
                }
            }

            return true; // If all succeed, return true
        }







    }
}
