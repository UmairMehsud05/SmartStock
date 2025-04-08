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
    public class Suppliers
    {

        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }


    public class Supplier_Methods
    {
        private readonly DatabaseHelper db;

        public Supplier_Methods()
        {
            db = new DatabaseHelper();
        }


        public bool InsertOrUpdate(Suppliers s)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@Action", DbAction.Select);
            pr[1] = new SqlParameter("@SupplierName", s.SupplierName);

            DataTable dt = db.ExecuteSp("sp_Suppliers", pr);
            if(dt.Rows.Count>0 && Convert.ToInt32(dt.Rows[0]["SupplierID"]) != s.SupplierID){
                return false;
            }
            else
            {
                SqlParameter[] prm = new SqlParameter[]
                {
                    new SqlParameter("@Action",s.SupplierID>0?DbAction.Update:DbAction.Insert),
                    new SqlParameter("@SupplierID",s.SupplierID),
                    new SqlParameter("@SupplierName",s.SupplierName),
                    new SqlParameter("@CompanyName",s.CompanyName),
                    new SqlParameter("@Contact",s.Contact),
                    new SqlParameter("@Email",s.Email),
                    new SqlParameter("@Address",s.Address),
                    new SqlParameter("@CreatedAt",s.CreatedAt),
                    new SqlParameter("@IsDeleted",s.IsDeleted)
                };

                db.NonExecutableSp("sp_Suppliers", prm);
                return true;
            }
        }



        public bool DeteleSupplier(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Delete);
            prm[1] = new SqlParameter("@SupplierID", id);

            int rowAffected= db.NonExecutableSp("sp_Suppliers", prm);

            if (rowAffected > 0)
            {
                return true;
            }
            else
                return false;
        }



        public Suppliers GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@SupplierID", id);
            DataTable dt = db.ExecuteSp("sp_Suppliers", prm);
            Suppliers s = null;
            if (dt.Rows.Count > 0)
            {
                s = new Suppliers();
                s.SupplierID = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                s.SupplierName = dt.Rows[0]["SupplierName"].ToString();
                s.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                s.Contact = dt.Rows[0]["Contact"].ToString();
                s.Email = dt.Rows[0]["Email"].ToString();
                s.Address = dt.Rows[0]["Address"].ToString();
                s.CreatedAt = Convert.ToDateTime(dt.Rows[0]["CreatedAt"]);
                s.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }
            return s;
        }


        public List<Suppliers> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@IsDeleted", 0);
            DataTable dt = db.ExecuteSp("sp_Suppliers", prm);
            List<Suppliers> list = new List<Suppliers>();
            foreach(DataRow dr in dt.Rows)
            {
                Suppliers s = new Suppliers();
                s = new Suppliers();
                s.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                s.SupplierName = dr["SupplierName"].ToString();
                s.CompanyName = dr["CompanyName"].ToString();
                s.Contact = dr["Contact"].ToString();
                s.Email = dr["Email"].ToString();
                s.Address = dr["Address"].ToString();
                s.CreatedAt = Convert.ToDateTime(dr["CreatedAt"]);
                s.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(s);
            }
            return list;
        }
    }
}
