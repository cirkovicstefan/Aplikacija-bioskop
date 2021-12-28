using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class SalaBusiness : ISalaBusiness
    {
        private ISalaRepository salaRepository;

        public SalaBusiness()
        {
            salaRepository = new SalaRepository();
        }


        public bool Dodaj(Sala sala)
        {
            return salaRepository.Dodaj(sala);
        }

        public bool Izmeni(Sala sala)
        {
            return salaRepository.Izmeni(sala);
        }

        public bool Obrisi(int idSale)
        {
            return salaRepository.Obrisi(idSale);
        }

        public List<Sala> SveSale()
        {
            return salaRepository.SveSale();
        }
    }
}
