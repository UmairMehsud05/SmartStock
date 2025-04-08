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
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        
    }

    public class Categories_Methods
    {
        private readonly DatabaseHelper db;

        public Categories_Methods()
        {
            db = new DatabaseHelper();
        }
        

        public bool InsertOrUpdate(Categories c) //if the category already exists it return false, as not update or insertion occurs.
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@Action", DbAction.Select);
            p[1] = new SqlParameter("@CategoryName", c.CategoryName);
            DataTable dt = db.ExecuteSp("sp_Categories", p);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["CategoryID"]) != c.CategoryID)
            {
                return false;
            }
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Action", c.CategoryID > 0 ? DbAction.Update : DbAction.Insert);
            prm[1] = new SqlParameter("@CategoryID", c.CategoryID);
            prm[2] = new SqlParameter("@CategoryName", c.CategoryName);
            prm[3] = new SqlParameter("@IsDeleted", c.IsDeleted);

            db.NonExecutableSp("sp_Categories", prm);
            return true;
        }



        public bool DeleteCategory(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Delete);
            prm[1] = new SqlParameter("@CategoryID", id);

            int rowAffected = db.NonExecutableSp("sp_Categories", prm);

            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Categories GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@CategoryID", id);

            DataTable dt = db.ExecuteSp("sp_Categories", prm);
            Categories clist = null;
            if (dt.Rows.Count > 0)
            {
                clist = new Categories();
                clist.CategoryID = Convert.ToInt32(dt.Rows[0]["CategoryID"]);
                clist.CategoryName = Convert.ToString(dt.Rows[0]["CategoryName"]);
                clist.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }
            return clist;
        }


        public List<Categories> GetAllCategories()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@IsDeleted", 0); //Only Fetch available Categories But Not Soft Deleted Categories

            DataTable dt = db.ExecuteSp("sp_Categories", prm);
            List<Categories> list = new List<Categories>();
            foreach(DataRow dr in dt.Rows)
            {
                Categories c = new Categories();
                c.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                c.CategoryName = Convert.ToString(dr["CategoryName"]);
                c.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(c);
            }
            return list;
        }



    }
}
