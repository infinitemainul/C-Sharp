using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dataaccesslayer;

namespace WindowsFormsApp1.Bsinesslogiclayer
{
    public class Eventdataaccess
    {
        DataAccess da;
        public Eventdataaccess()
        {
            da = new DataAccess();
        }


        public List<Events> GetAllEvents(int Uid)
        {
            string sql = "SELECT * FROM Events where Uid=" + Uid;
            SqlDataReader reader = da.GetData(sql);
            List<Events> list = new List<Events>();
            while (reader.Read())
            {
                Events p = new Events();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Createdate = reader["Createdate"].ToString();
                p.Eventdate = reader["Eventdate"].ToString();
                p.Modifydate = reader["Modifydate"].ToString();
                p.Description = reader["Description"].ToString();
                p.Uid = (int)reader["Uid"];
                p.Importance = reader["Importance"].ToString();

                p.Pic = reader["Pic"].ToString();
                list.Add(p);
            }



            return list;
        }

        public Events GetthatEvent(int id)
        {
            string sql = "SELECT * FROM Events where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Events p = new Events();
            while (reader.Read())
            {

                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Createdate = reader["Createdate"].ToString();
                p.Eventdate = reader["Eventdate"].ToString();
                p.Modifydate = reader["Modifydate"].ToString();
                p.Description = reader["Description"].ToString();
                p.Uid = (int)reader["Uid"];
                p.Importance = reader["Importance"].ToString();

                p.Pic = reader["Pic"].ToString();
            }
            return p;
            

        }
        public int AddEvent(Events p)
        {
            string sql = "INSERT INTO Events (Name,Createdate,Eventdate,Modifydate,Pic,Description,Importance,Uid) VALUES('" + p.Name + "','" + p.Createdate + "','" + p.Eventdate + "','" + p.Modifydate + "','" + p.Pic +"','" + p.Description +"','" + p.Importance + "'," + p.Uid + ")";
            return da.ExecuteQuery(sql);

        }
        public int Updateevent(Events p, int eid)
        {
            string sql = "UPDATE Events SET Name='" + p.Name + "',Createdate='" + p.Createdate + "',Eventdate='" + p.Eventdate + "',Modifydate='" + p.Modifydate + "',Pic='" + p.Pic + "',Description='" + p.Description + "',Importance='" + p.Importance + "',Uid=" + p.Uid + "' WHERE Eventid=" + eid;
            return da.ExecuteQuery(sql);

        }
        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM Events WHERE Id=" + id;
            return da.ExecuteQuery(sql);

        }


    }
}
