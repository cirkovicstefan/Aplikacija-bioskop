using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface.Business
{
    public interface ISalaBusiness
    {
        bool Dodaj(Sala sala);
        bool Izmeni(Sala sala);
        bool Obrisi(int idSale);
        List<Sala> SveSale();
    }
}
