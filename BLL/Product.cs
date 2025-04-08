using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartStock.DAL;
using System.Data;
using System.Data.SqlClient;

namespace SmartStock.BLL
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int LowStockThreshold { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string CategoryName { get; set; }

    }


    public class Product_Methods
    {
        private readonly DatabaseHelper db;
        public Product_Methods()
        {
            db = new DatabaseHelper();
        }


        public bool InsertOrUpdate(Products p) //if product is already exists then it return false
        {
            SqlParameter[] pm = new SqlParameter[2];
            pm[0] = new SqlParameter("@Action", DbAction.Select);
            pm[1] = new SqlParameter("@ProductName", p.ProductName);
            DataTable dt = db.ExecuteSp("sp_Products", pm);
            if(dt.Rows.Count>0 && Convert.ToInt32(dt.Rows[0]["ProductID"]) != p.ProductID)
            {
                return false;
            }
            else
            {
                SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",p.ProductID>0?DbAction.Update:DbAction.Insert),
                new SqlParameter("@ProductID",p.ProductID),
                new SqlParameter("@ProductName",p.ProductName),
                new SqlParameter("@CategoryID",p.CategoryID),
                new SqlParameter("@StockQuantity",p.StockQuantity),
                new SqlParameter("@Price",p.Price),
                new SqlParameter("@Description",p.Description),
                new SqlParameter("@LowStockThreshold",p.LowStockThreshold),
                new SqlParameter("@CreatedAt",p.CreatedAt),
                new SqlParameter("@IsDeleted",p.IsDeleted),
            };

                db.NonExecutableSp("sp_Products", prm);

                return true;
            }
            
        }



        public bool Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Delete);
            prm[1] = new SqlParameter("@ProductID", id);
            int rowAffected = db.NonExecutableSp("sp_Products", prm);

            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Products GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@ProductID", id);
            DataTable dt = db.ExecuteSp("sp_Products", prm);
            Products list = null;
            if (dt.Rows.Count > 0)
            {
                list = new Products();
                list.ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"]);
                list.ProductName = dt.Rows[0]["ProductName"].ToString();
                list.CategoryID = Convert.ToInt32(dt.Rows[0]["CategoryID"]);
                list.StockQuantity = Convert.ToInt32(dt.Rows[0]["StockQuantity"]);
                list.Price = Convert.ToDecimal(dt.Rows[0]["Price"]);
                list.Description = Convert.ToString(dt.Rows[0]["Description"]);
                list.LowStockThreshold = Convert.ToInt32(dt.Rows[0]["LowStockThreshold"]);
                list.CreatedAt = Convert.ToDateTime(dt.Rows[0]["CreatedAt"]);
                list.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
                list.CategoryName = Convert.ToString(dt.Rows[0]["CategoryName"]);
            }
            return list;
        }


        public List<Products> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Action", DbAction.Select);
            prm[1] = new SqlParameter("@IsDeleted", 0);
            DataTable dt = db.ExecuteSp("sp_Products", prm);
            List<Products> list = new List<Products>();
            foreach(DataRow dr in dt.Rows)
            {
                Products p = new Products();
                p.ProductID = Convert.ToInt32(dr["ProductID"]);
                p.ProductName = dr["ProductName"].ToString();
                p.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                p.StockQuantity = Convert.ToInt32(dr["StockQuantity"]);
                p.Price = Convert.ToDecimal(dr["Price"]);
                p.Description = Convert.ToString(dr["Description"]);
                p.LowStockThreshold = Convert.ToInt32(dr["LowStockThreshold"]);
                p.CreatedAt = Convert.ToDateTime(dr["CreatedAt"]);
                p.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                p.CategoryName = Convert.ToString(dr["CategoryName"]);
                list.Add(p);
            }
            return list;
        }


    }
}
