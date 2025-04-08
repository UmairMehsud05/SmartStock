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
    public class SalesDetails
    {
            public int SaleDetailID { get; set; }
            public int SaleID { get; set; }
            public int ProductID { get; set; }
            public int QuantitySold { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Discount { get; set; }
            public bool IsDeleted { get; set; }

    }
        public class SalesDetail_Methods
        {
            private readonly DatabaseHelper db;
            public SalesDetail_Methods()
            {
                db = new DatabaseHelper();
            }

            public bool Insert(SalesDetails s)
            {
                SqlParameter[] prm = new SqlParameter[]
                {
                    new SqlParameter("@Action",DbAction.Insert),
                    new SqlParameter("@SaleDetailID",s.SaleDetailID),
                    new SqlParameter("@SaleID",s.SaleID),
                    new SqlParameter("@ProductID",s.ProductID),
                    new SqlParameter("@QuantitySold",s.QuantitySold),
                    new SqlParameter("@UnitPrice",s.UnitPrice),
                    new SqlParameter("@Discount",s.Discount),
                    new SqlParameter("@IsDeleted",s.IsDeleted)
                };

                db.NonExecutableSp("sp_SaleDetails", prm);
                return true;
            }


            public SalesDetails GetSaleDetailsDataByID(int id)
            {
                SqlParameter[] prm = new SqlParameter[]
                {
                    new SqlParameter("@Action",DbAction.Select),
                    new SqlParameter("@SaleID",id)
                };
                DataTable dt = db.ExecuteSp("sp_SaleDetails", prm);
                SalesDetails sd = null;
                if (dt.Rows.Count > 0)
                {
                    sd = new SalesDetails();
                    sd.SaleDetailID = Convert.ToInt32(dt.Rows[0]["SaleDetails"]);
                    sd.SaleID = Convert.ToInt32(dt.Rows[0]["SaleId"]);
                    sd.ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"]);
                    sd.QuantitySold = Convert.ToInt32(dt.Rows[0]["QuantitySold"]);
                    sd.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);
                    sd.Discount = Convert.ToDecimal(dt.Rows[0]["Discount"]);
                    sd.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
                }
                return sd;
            }


            public List<SalesDetails> GetAllSaleDetails()
            {
                SqlParameter[] prm = new SqlParameter[]
                {
                    new SqlParameter("@Action",DbAction.Select),
                    new SqlParameter("@IsDeleted",0)
                };
                DataTable dt = db.ExecuteSp("sp_SaleDetails", prm);
                List<SalesDetails> list = new List<SalesDetails>();
                foreach(DataRow dr in dt.Rows)
                {
                    SalesDetails sd = new SalesDetails();
                    sd.SaleDetailID = Convert.ToInt32(dr["SaleDetails"]);
                    sd.SaleID = Convert.ToInt32(dr["SaleId"]);
                    sd.ProductID = Convert.ToInt32(dr["ProductID"]);
                    sd.QuantitySold = Convert.ToInt32(dr["QuantitySold"]);
                    sd.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                    sd.Discount = Convert.ToDecimal(dr["Discount"]);
                    sd.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                    list.Add(sd);
                }
                return list;
            }
        }
    }
