
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegistrationService
    {
        RegistrationRepository regRepo;
        public RegistrationService()
        {
            regRepo = new RegistrationRepository();
        }
        public int UserRegistration(string name, string email, string phone, string username, string password, int userType)
        {
            return regRepo.Register(name, email, phone, username, password, userType);
        }
    }
}
