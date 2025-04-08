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
    public class Purchases
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int QuantityPurchased { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchasedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string NamePurchasedBy { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
    }


    public class Purchase_Methods
    {
        private readonly DatabaseHelper db;

        public Purchase_Methods()
        {
            db = new DatabaseHelper();
        }

        public bool Insert(Purchases p)
        {
            SqlParameter[] pr = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Insert),
                new SqlParameter("@PurchaseID",p.PurchaseID),
                new SqlParameter("@ProductID",p.ProductID),
                new SqlParameter("@SupplierID",p.SupplierID),
                new SqlParameter("@QuantityPurchased",p.QuantityPurchased),
                new SqlParameter("@UnitPrice",p.UnitPrice),
                new SqlParameter("@PurchaseDate",p.PurchaseDate),
                new SqlParameter("@PurchasedBy",p.PurchasedBy),
                new SqlParameter("@IsDeleted",p.IsDeleted)
            };

            db.NonExecutableSp("sp_Purchases", pr);
            return true;
        }



        public bool DeletePurchase(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Delete);
            prm[1] = new SqlParameter("@PurchaseID", id);

            int rowAffected = db.NonExecutableSp("sp_Purchases", prm);

            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Purchases GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@PurchaseID",id)
            };

            DataTable dt = db.ExecuteSp("sp_Purchases", prm);
            Purchases p = null;
            if (dt.Rows.Count > 0)
            {
                p = new Purchases();
                p.PurchaseID = Convert.ToInt32(dt.Rows[0]["PurchaseID"]);
                p.ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"]);
                p.SupplierID = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                p.QuantityPurchased = Convert.ToInt32(dt.Rows[0]["QuantityPurchased"]);
                p.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);
                p.PurchaseDate = Convert.ToDateTime(dt.Rows[0]["PurchaseDate"]);
                p.PurchasedBy = Convert.ToInt32(dt.Rows[0]["PurchasedBy"]);
                p.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
                p.NamePurchasedBy = Convert.ToString(dt.Rows[0]["FullName"]);
                p.ProductName = Convert.ToString(dt.Rows[0]["ProductName"]);
                p.SupplierName = Convert.ToString(dt.Rows[0]["SupplierName"]);
                p.CompanyName = Convert.ToString(dt.Rows[0]["CompanyName"]);
                p.CategoryName = Convert.ToString(dt.Rows[0]["CategoryName"]);
            }
            return p;
        }


        public Purchases GetDataByProductID(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@ProductID",id)
            };

            DataTable dt = db.ExecuteSp("sp_Purchases", prm);
            Purchases p = null;
            if (dt.Rows.Count > 0)
            {
                p = new Purchases();
                p.PurchaseID = Convert.ToInt32(dt.Rows[0]["PurchaseID"]);
                p.ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"]);
                p.SupplierID = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                p.QuantityPurchased = Convert.ToInt32(dt.Rows[0]["QuantityPurchased"]);
                p.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);
                p.PurchaseDate = Convert.ToDateTime(dt.Rows[0]["PurchaseDate"]);
                p.PurchasedBy = Convert.ToInt32(dt.Rows[0]["PurchasedBy"]);
                p.NamePurchasedBy = Convert.ToString(dt.Rows[0]["FullName"]);
                p.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
                p.ProductName = Convert.ToString(dt.Rows[0]["ProductName"]);
                p.SupplierName = Convert.ToString(dt.Rows[0]["SupplierName"]);
                p.CompanyName = Convert.ToString(dt.Rows[0]["CompanyName"]);
                p.CategoryName = Convert.ToString(dt.Rows[0]["CategoryName"]);
            }
            return p;
        }



        public List<Purchases> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Purchases", prm);
            List<Purchases> list = new List<Purchases>();
            foreach(DataRow dr in dt.Rows)
            {
                Purchases p = new Purchases();
                p.PurchaseID = Convert.ToInt32(dr["PurchaseID"]);
                p.ProductID = Convert.ToInt32(dr["ProductID"]);
                p.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                p.QuantityPurchased = Convert.ToInt32(dr["QuantityPurchased"]);
                p.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                p.PurchaseDate = Convert.ToDateTime(dr["PurchaseDate"]);
                p.PurchasedBy = Convert.ToInt32(dr["PurchasedBy"]);
                p.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                p.NamePurchasedBy = Convert.ToString(dr["FullName"]);
                p.ProductName = Convert.ToString(dr["ProductName"]);
                p.SupplierName = Convert.ToString(dr["SupplierName"]);
                p.CompanyName = Convert.ToString(dr["CompanyName"]);
                list.Add(p);
            }
            return list;
        }

        public List<Purchases> GetTodaysAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@PurchaseDate",DateTime.Today),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Purchases", prm);
            List<Purchases> list = new List<Purchases>();
            foreach (DataRow dr in dt.Rows)
            {
                Purchases p = new Purchases();
                p.PurchaseID = Convert.ToInt32(dr["PurchaseID"]);
                p.ProductID = Convert.ToInt32(dr["ProductID"]);
                p.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                p.QuantityPurchased = Convert.ToInt32(dr["QuantityPurchased"]);
                p.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                p.PurchaseDate = Convert.ToDateTime(dr["PurchaseDate"]);
                p.PurchasedBy = Convert.ToInt32(dr["PurchasedBy"]);
                p.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                p.NamePurchasedBy = Convert.ToString(dr["FullName"]);
                p.ProductName = Convert.ToString(dr["ProductName"]);
                p.SupplierName = Convert.ToString(dr["SupplierName"]);
                p.CompanyName = Convert.ToString(dr["CompanyName"]);
                list.Add(p);
            }
            return list;
        }


    }


}
