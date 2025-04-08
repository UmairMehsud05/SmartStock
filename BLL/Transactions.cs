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
    public class Transactions
    {
        public int TransactionID { get; set; }
        public int SaleID { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsDeleted { get; set; }
        public string CustomerName { get; set; }
        public string SaleInvoiceNo { get; set; }
        public decimal SalesTotalAmount { get; set; }
    }


    public class Transaction_Methods
    {
        private readonly DatabaseHelper db;

        public Transaction_Methods()
        {
            db = new DatabaseHelper();
        }


        public bool Insert(Transactions t)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Insert),
                new SqlParameter("@TransactionID",t.TransactionID),
                new SqlParameter("@SaleID",t.SaleID),
                new SqlParameter("@CustomerID",t.CustomerID),
                new SqlParameter("@PaymentMethod",t.PaymentMethod),
                new SqlParameter("@AmountPaid",t.AmountPaid),
                new SqlParameter("@PaymentStatus",t.PaymentStatus),
                new SqlParameter("@TransactionDate",t.TransactionDate),
                new SqlParameter("@IsDeleted",t.IsDeleted)
            };

            int rowAffected = db.NonExecutableSp("sp_Transactions", prm);
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Transactions GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@TransactionID",id)
            };
            DataTable dt = db.ExecuteSp("sp_Transactions", prm);
            Transactions t = null;
            if (dt.Rows.Count > 0)
            {
                t = new Transactions();
                t.TransactionID = Convert.ToInt32(dt.Rows[0]["TransactionID"]);
                t.SaleID = Convert.ToInt32(dt.Rows[0]["SaleID"]);
                t.SaleInvoiceNo = Convert.ToString(dt.Rows[0]["InvoiceNo"]);
                t.SalesTotalAmount = (Convert.ToDecimal(dt.Rows[0]["TotalAmount"]) - Convert.ToDecimal(dt.Rows[0]["Discount"]));
                t.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                t.CustomerName = Convert.ToString(dt.Rows[0]["CustomerName"]);
                t.PaymentMethod = Convert.ToString(dt.Rows[0]["PaymentMethod"]);
                t.AmountPaid = Convert.ToDecimal(dt.Rows[0]["AmountPaid"]);
                t.PaymentStatus = Convert.ToString(dt.Rows[0]["PaymentStatus"]);
                t.TransactionDate = Convert.ToDateTime(dt.Rows[0]["TransactionDate"]);
                t.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }

            return t;
        }


        public List<Transactions> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };
            DataTable dt = db.ExecuteSp("sp_Transactions", prm);
            List<Transactions> list = new List<Transactions>();
            foreach(DataRow dr in dt.Rows)
            {
                Transactions t = new Transactions();
                t.TransactionID = Convert.ToInt32(dr["TransactionID"]);
                t.SaleID = Convert.ToInt32(dr["SaleID"]);
                t.SaleInvoiceNo = Convert.ToString(dr["InvoiceNo"]);
                t.SalesTotalAmount = (Convert.ToDecimal(dr["TotalAmount"]) - Convert.ToDecimal(dr["Discount"]));
                t.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                t.CustomerName = Convert.ToString(dr["CustomerName"]);
                t.PaymentMethod = Convert.ToString(dr["PaymentMethod"]);
                t.AmountPaid = Convert.ToDecimal(dr["AmountPaid"]);
                t.PaymentStatus = Convert.ToString(dr["PaymentStatus"]);
                t.TransactionDate = Convert.ToDateTime(dr["TransactionDate"]);
                t.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(t);
            }
            return list;
        }


        public List<Transactions> GetTodaysAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@TransactionDate",DateTime.Today),
                new SqlParameter("@IsDeleted",0)
            };
            DataTable dt = db.ExecuteSp("sp_Transactions", prm);
            List<Transactions> list = new List<Transactions>();
            foreach (DataRow dr in dt.Rows)
            {
                Transactions t = new Transactions();
                t.TransactionID = Convert.ToInt32(dr["TransactionID"]);
                t.SaleID = Convert.ToInt32(dr["SaleID"]);
                t.SaleInvoiceNo = Convert.ToString(dr["InvoiceNo"]);
                t.SalesTotalAmount = (Convert.ToDecimal(dr["TotalAmount"]) - Convert.ToDecimal(dr["Discount"]));
                t.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                t.CustomerName = Convert.ToString(dr["CustomerName"]);
                t.PaymentMethod = Convert.ToString(dr["PaymentMethod"]);
                t.AmountPaid = Convert.ToDecimal(dr["AmountPaid"]);
                t.PaymentStatus = Convert.ToString(dr["PaymentStatus"]);
                t.TransactionDate = Convert.ToDateTime(dr["TransactionDate"]);
                t.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(t);
            }
            return list;
        }


        public int MaxTransactionID()
        {
            int maxtransactionid = 0;
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",5), //5 select the max transaction id
                new SqlParameter("IsDeleted",0)
            };
            DataTable dt = db.ExecuteSp("sp_Transactions", prm);

            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxTransID"] !=DBNull.Value)
            {
                maxtransactionid = Convert.ToInt32(dt.Rows[0]["MaxTransID"]);
            }

            return maxtransactionid;
        }


    }
}
