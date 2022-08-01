using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Dataaccesslayer;

namespace WindowsFormsApp1.Bsinesslogiclayer
{
   public class Userdataaccess
    {
        DataAccess da;
        User user;
        public Userdataaccess()
        {
            da = new DataAccess();
        }


        public User GetUser(string userName)
        {
            user = new User();
            string sql = "SELECT * FROM Users WHERE Name='" + userName + "'";
            SqlDataReader reader = da.GetData(sql);
            reader.Read();
            user.Name = reader["Name"].ToString();
            user.Password = reader["Password"].ToString();
            user.Id = (int)reader["Id"];
            return user;
        }
        public int AddUser(User p)
        {
            string sql = "INSERT INTO Users (Name,Password) VALUES('" + p.Name + "','" + p.Password + "')";
            return da.ExecuteQuery(sql);

        }




    }
}
