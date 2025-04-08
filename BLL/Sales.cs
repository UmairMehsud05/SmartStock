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
    public class Sales
    {
        public int SaleID { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public string PaymentMethod { get; set; }
        public int SoldBy { get; set; }
        public bool IsDeleted { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
    }


    public class Sale_Methods
    {
        private readonly DatabaseHelper db;

        public Sale_Methods()
        {
            db = new DatabaseHelper();
        }

        public bool Insert(Sales s)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Insert),
                new SqlParameter("@SaleID",s.SaleID),
                new SqlParameter("@InvoiceNo",s.InvoiceNo),
                new SqlParameter("@CustomerID",s.CustomerID),
                new SqlParameter("@SaleDate",s.SaleDate),
                new SqlParameter("@TotalAmount",s.TotalAmount),
                new SqlParameter("@Discount",s.Discount),
                new SqlParameter("@PaymentMethod",s.PaymentMethod),
                new SqlParameter("@SoldBy",s.SoldBy),
                new SqlParameter("@IsDeleted",s.IsDeleted)
            };

            db.NonExecutableSp("sp_Sales", prm);
            return true;

        }


        public bool DeleteSaleData(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Delete),
                new SqlParameter("@SaleID",id)
            };
            int rowAffected = db.NonExecutableSp("sp_Sales", prm);
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Sales GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@SaleID",id)
            };

            DataTable dt = db.ExecuteSp("sp_Sales", prm);
            Sales s = null;
            if (dt.Rows.Count > 0)
            {
                s = new Sales();
                s.SaleID = Convert.ToInt32(dt.Rows[0]["SaleId"]);
                s.InvoiceNo = Convert.ToString(dt.Rows[0]["InvoiceNo"]);
                s.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                s.CustomerName = Convert.ToString(dt.Rows[0]["CustomerName"]);
                s.SaleDate = Convert.ToDateTime(dt.Rows[0]["SaleDate"]);
                s.TotalAmount = Convert.ToDecimal(dt.Rows[0]["TotalAmount"]);
                s.Discount = Convert.ToDecimal(dt.Rows[0]["Discount"]);
                s.PaymentMethod = Convert.ToString(dt.Rows[0]["PaymentMethod"]);
                s.SoldBy = Convert.ToInt32(dt.Rows[0]["SoldBy"]);
                s.UserName = Convert.ToString(dt.Rows[0]["FullName"]);
                s.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }

            return s;
        }


        public List<Sales> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Sales", prm);
            List<Sales> list = new List<Sales>();
            foreach (DataRow dr in dt.Rows)
            {
                Sales s = new Sales();
                s.SaleID = Convert.ToInt32(dr["SaleId"]);
                s.InvoiceNo = Convert.ToString(dr["InvoiceNo"]);
                s.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                s.CustomerName = Convert.ToString(dr["CustomerName"]);
                s.SaleDate = Convert.ToDateTime(dr["SaleDate"]);
                s.TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                s.Discount = Convert.ToDecimal(dr["Discount"]);
                s.PaymentMethod = Convert.ToString(dr["PaymentMethod"]);
                s.SoldBy = Convert.ToInt32(dr["SoldBy"]);
                s.UserName = Convert.ToString(dr["FullName"]);
                s.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(s);
            }
            return list;
        }




        public List<Sales> GetTodayAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@SaleDate",DateTime.Today),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Sales", prm);
            List<Sales> list = new List<Sales>();
            foreach (DataRow dr in dt.Rows)
            {
                Sales s = new Sales();
                s.SaleID = Convert.ToInt32(dr["SaleId"]);
                s.InvoiceNo = Convert.ToString(dr["InvoiceNo"]);
                s.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                s.CustomerName = Convert.ToString(dr["CustomerName"]);
                s.SaleDate = Convert.ToDateTime(dr["SaleDate"]);
                s.TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                s.Discount = Convert.ToDecimal(dr["Discount"]);
                s.PaymentMethod = Convert.ToString(dr["PaymentMethod"]);
                s.SoldBy = Convert.ToInt32(dr["SoldBy"]);
                s.UserName = Convert.ToString(dr["FullName"]);
                s.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(s);
            }
            return list;
        }


        public int MaxSaleID()
        {
            int maxSaleId = 0;
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action", 5),
                new SqlParameter("@IsDeleted", 0) // Or DBNull.Value if you want all
            };

            DataTable dt = db.ExecuteSp("sp_Sales", prm);

            if (dt.Rows.Count > 0 && dt.Rows[0]["maxSaleID"] != DBNull.Value)
            {
                maxSaleId = Convert.ToInt32(dt.Rows[0]["maxSaleID"]);
            }
            return maxSaleId;
        }





        public string MaxInvoiceNo()
        {

            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",6), // select max invoiceNo
                new SqlParameter("@IsDeleted",0)
            };


            DataTable dt = db.ExecuteSp("sp_Sales", prm);
            int maxInvoice = 0;
            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxInvoiceNo"] != DBNull.Value)
            {
                maxInvoice = Convert.ToInt32(dt.Rows[0]["MaxInvoiceNo"]);
            }

            maxInvoice += 1;

            string newInvoiceNo = "INV-" + maxInvoice;

            return newInvoiceNo;
        }




    }
}
