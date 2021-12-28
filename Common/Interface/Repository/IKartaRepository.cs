using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface.Repository
{
    public interface IKartaRepository
    {
        bool Dodaj(Karta karta);
        bool Izmeni(Karta karta);
        bool Obrisi(Karta karta);
        List<Karta> SveKarte();
    }
}
