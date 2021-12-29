using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System;
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
            foreach(var item in salaRepository.SveSale())
            {
                if (sala.Kapacitet == sala.Kapacitet && sala.NazivSale.Equals(item.NazivSale))
                    throw new Exception("Salu koju zelite da unesete vec postoji");
            }
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

        public List<Sala> Pretraga(string by, Sala sala)
        => salaRepository.Pretraga(by, sala);

        public List<Sala> SveSale()
        {
            return salaRepository.SveSale();
        }
    }
}
