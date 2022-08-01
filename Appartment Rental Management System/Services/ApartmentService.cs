using Entity;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Services
{
    public class ApartmentService
    {
        ApartmentRepository apRepo;
        public ApartmentService()
        {
            apRepo = new ApartmentRepository();
        }

        public List<Apartment> GetAllApartments()
        {
            return apRepo.GetAll();
        }
        public Apartment GetById(int id)
        {
            return apRepo.Get(id);
        }
        public Apartment GetByName(string name)
        {
            return apRepo.Get(name);
        }
        public int Insert(Apartment cat)
        {
            return apRepo.Insert(cat);
        }
        public int Update(Apartment cat)
        {
            return apRepo.Update(cat);
        }
        public int Delete(int id)
        {
            return apRepo.Delete(id);
        }
    }
}
