using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    class GledalacBusiness : IGledalacBusiness
    {
        private readonly IGledalacRepository gledalacRepository;

        public GledalacBusiness()
        {
            gledalacRepository = new GledalacRepository();
        }

        public bool Dodaj(Gledalac gledalac)
        {
            foreach (var item in gledalacRepository.SviGledaoci())
            {
                if (item.Email.Equals(gledalac.Email))
                    throw new Exception("Gledalac vec postoji !!!");
            }
            return gledalacRepository.Dodaj(gledalac);
        }

        public bool Izmeni(Gledalac gledalac)
        {
            return gledalacRepository.Izmeni(gledalac);
        }

        public bool Obrisi(int idGledaoca)
        {
            return gledalacRepository.Obrisi(idGledaoca);
        }

        public List<Gledalac> SviGledaoci()
        {
            return gledalacRepository.SviGledaoci();
        }
    }
}
