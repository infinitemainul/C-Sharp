using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repositories
{
    public class ApartmentRepository : IRepository<Apartment>, IDisposable
    {
         DataAccess dataAccess;
        public ApartmentRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Apartment> GetAll()
        {
            string sql = "SELECT * FROM Apartments";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Apartment> apartment = new List<Apartment>();
            while (reader.Read())
            {
                Apartment ap = new Apartment();
                ap.Id = (int)reader["Id"];
                ap.Area = reader["Area"].ToString();
                ap.RoadNo = (int)reader["Road_no"];
                ap.HouseNo = (int)reader["House_no"];
                ap.Rent = Convert.ToSingle(reader["Rent"]);
                ap.BedRoom = (int)reader["Bedroom"];
                ap.WashRoom = (int)reader["Washroom"];
                ap.Balcony = (int)reader["Bedroom"];
                //ap.Category_Id = (int)reader["Category_Id"];
              apartment.Add(ap);
            }
            return apartment;
        }

        public Apartment Get(int id)
        {
            string sql = "SELECT * FROM Apartments WHERE Id=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
          Apartment ap = new Apartment();
          ap.Id = (int)reader["Id"];
          ap.Area = reader["Area"].ToString();
          ap.RoadNo = (int)reader["Road_no"];
          ap.HouseNo = (int)reader["House_no"];
          ap.Rent = Convert.ToSingle(reader["Rent"]);
          ap.BedRoom = (int)reader["Bedroom"];
          ap.WashRoom = (int)reader["Washroom"];
          ap.Balcony = (int)reader["Balcony"];
           dataAccess.Dispose();
            return ap;

        }
        public Apartment Get(string area)
        {
            string sql = "SELECT * FROM Apartments WHERE Id=" + area;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Apartment ap = new Apartment();
            ap.Id = (int)reader["Id"];
            ap.Area = reader["Area"].ToString();
            ap.RoadNo = (int)reader["Road_no"];
            ap.HouseNo = (int)reader["House_no"];
            ap.Rent = Convert.ToSingle(reader["Rent"]);
            ap.BedRoom = (int)reader["Bedroom"];
            ap.WashRoom = (int)reader["Washroom"];
            ap.Balcony = (int)reader["Balcony"];
            dataAccess.Dispose();
            return ap;

        }

        public int Insert(Apartment entity)
        {
            string sql = "INSERT INTO Apartments(Area,Road_no,House_no,Rent,Bedroom,Washroom,Balcony) VALUES ('" + entity.Area + "'," + entity.RoadNo + ","+entity.HouseNo+"," + entity.Rent + "," + entity.BedRoom+ ","+entity.WashRoom+","+entity.Balcony+")";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Apartment entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Apartments SET Area='" + entity.Area + "', Road_no=" + entity.RoadNo + ",House_no=" + entity.HouseNo + ",Rent=" + entity.Rent + ",Bedroom=" + entity.BedRoom + ",Washroom=" + entity.WashRoom + ",Balcony=" + entity.Balcony;
            return dataAccess.ExecuteQuery(sql);
        }

        public int Delete(int id)
        {

            string sql = "DELETE FROM Apartments WHERE Id=" + id;
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
    }
}
