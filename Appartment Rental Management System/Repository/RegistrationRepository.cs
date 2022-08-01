using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repositories
{
   public class RegistrationRepository
    {
       DataAccess dataAccess;
        public RegistrationRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Register(string name,string email,string phone,string username,string password,int userType)
        {
            string sql = "INSERT INTO Users(Name,Email,Phone_No) VALUES('"+name+"','"+email+"','"+phone+"')";
            int result = dataAccess.ExecuteQuery(sql);
            if (result > 0)
            {
                dataAccess = new DataAccess();
                sql = "SELECT * FROM Users WHERE Email='"+email+"'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int id = (int)reader["Id"];

                dataAccess = new DataAccess();
                sql = "INSERT INTO Credentials(Username,Password,UserType,UserId) VALUES('"+username+"','"+password+"',"+userType+","+id+")";
                result = dataAccess.ExecuteQuery(sql);
                if (result > 0)
                {
                    return 1;
                }
                else { return 0; }
            }
            else { return 0; }
        }
    }
    }

