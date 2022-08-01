using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using Interfaces;


namespace Repositories
{
    public class AdminRepository 
    {
        DataAccess dataAccess;
        public AdminRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Admin> GetAll()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Admin> admin = new List<Admin>();
            while (reader.Read())
            {
                Admin ap = new Admin();
                ap.Id = (int)reader["Id"];
                ap.Name = reader["Name"].ToString();
                ap.UserName = reader["UserName"].ToString();
                ap.Email = reader["Email"].ToString();
                ap.Contact= reader["Phone_No"].ToString();
                
                //ap.Category_Id = (int)reader["Category_Id"];
                admin.Add(ap);
            }
            return admin;
        }

        public int Insert(Admin entity)
        {
            string sql1;
            string sql = "INSERT INTO Users(Name,Email,Phone_No) VALUES ('" + entity.Name + "','" + entity.Email + "','" + entity.Contact + "')";
            sql1 = "INSERT INTO Credentials(UserName,Password,UserType,UserId) VALUES ('" + entity.UserName + "','" + entity.Password + "','" + entity.UserType + "','" + entity.UserId + ")";
            return dataAccess.ExecuteQuery(sql);
            return dataAccess.ExecuteQuery(sql1);
           
        }
    }
}
