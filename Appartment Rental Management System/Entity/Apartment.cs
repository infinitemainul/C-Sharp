using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public int RoadNo { get; set; }
        public int HouseNo { get; set; }
        public double Rent { get; set; }
        public int BedRoom { get; set; }
        public int WashRoom { get; set; }
        public int Balcony { get; set; }

    }
}
