using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginBusiness : ILogInBusiness
    {
        private readonly ILogInRepository logInRepository;
        public LoginBusiness()
        {
            logInRepository = new LoginRepository();
        }
        public bool Dodaj(Login login)
        {
            return logInRepository.Dodaj(login);
        }

        public bool Obrisi(Login login)
        {
            return logInRepository.Obrisi(login);
        }

        public List<Login> SviRadnici()
        {
            return logInRepository.SviRadnici();
        }
    }
}
