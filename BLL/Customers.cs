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
    public class Customers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CustomerType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool HasPurchased { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class Customer_Methods
    {

        private readonly DatabaseHelper db;

        public Customer_Methods()
        {
            db = new DatabaseHelper();
        }


        public bool InserOrUpdate(Customers c)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",c.CustomerID>0?DbAction.Update:DbAction.Insert),
                new SqlParameter("@CustomerID",c.CustomerID),
                new SqlParameter("@CustomerName",c.CustomerName),
                new SqlParameter("@Contact",c.Contact),
                new SqlParameter("@Email",c.Email),
                new SqlParameter("@Address",c.Address),
                new SqlParameter("@City",c.City),
                new SqlParameter("@CustomerType",c.CustomerType),
                new SqlParameter("@RegistrationDate",c.RegistrationDate),
                new SqlParameter("@HasPurchased",c.HasPurchased),
                new SqlParameter("@IsDeleted",c.IsDeleted)
            };

            db.NonExecutableSp("sp_Customers", prm);
            return true;
        }


        public bool DeleteCustomer(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Delete),
                new SqlParameter("@CustomerID",id)
            };

            int rowAffected = db.NonExecutableSp("sp_Customers", prm);

            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Customers GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@CustomerID",id)
            };

            DataTable dt = db.ExecuteSp("sp_Customers", prm);
            Customers c = null;
            if (dt.Rows.Count > 0)
            {
                c = new Customers();
                c.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                c.CustomerName = Convert.ToString(dt.Rows[0]["CustomerName"]);
                c.Contact = Convert.ToString(dt.Rows[0]["Contact"]);
                c.Email = Convert.ToString(dt.Rows[0]["Email"]);
                c.Address = Convert.ToString(dt.Rows[0]["Address"]);
                c.City = Convert.ToString(dt.Rows[0]["City"]);
                c.CustomerType = Convert.ToString(dt.Rows[0]["CustomerType"]);
                c.RegistrationDate = Convert.ToDateTime(dt.Rows[0]["RegistrationDate"]);
                c.HasPurchased = Convert.ToBoolean(dt.Rows[0]["HasPurchased"]);
                c.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
            }

            return c;
        }


        public List<Customers> GetAllData()
        {
            SqlParameter[] prm = new SqlParameter[]
            {
                new SqlParameter("@Action",DbAction.Select),
                new SqlParameter("@IsDeleted",0)
            };

            DataTable dt = db.ExecuteSp("sp_Customers", prm);
            List<Customers> list = new List<Customers>();
            foreach(DataRow dr in dt.Rows)
            {
                Customers c = new Customers();
                c.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                c.CustomerName = Convert.ToString(dr["CustomerName"]);
                c.Contact = Convert.ToString(dr["Contact"]);
                c.Email = Convert.ToString(dr["Email"]);
                c.Address = Convert.ToString(dr["Address"]);
                c.City = Convert.ToString(dr["City"]);
                c.CustomerType = Convert.ToString(dr["CustomerType"]);
                c.RegistrationDate = Convert.ToDateTime(dr["RegistrationDate"]);
                c.HasPurchased = Convert.ToBoolean(dr["HasPurchased"]);
                c.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                list.Add(c);
            }

            return list;
        }

    }
}
