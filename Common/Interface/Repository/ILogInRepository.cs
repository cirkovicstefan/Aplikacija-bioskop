using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface.Repository
{
    public interface ILogInRepository
    {
        bool Dodaj(Login login);
        bool Obrisi(Login login);
        List<Login> SviRadnici();
    }
}
