using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System.Collections.Generic;
using System;
namespace BusinessLayer
{
    public class IgraSeUSaliBusiness : ISeIgraUSaliBusiness
    {
        private readonly ISeIgraUSaliRepository seIgraUSaliRepository;

        public IgraSeUSaliBusiness()
        {
            seIgraUSaliRepository = new IgraSeUSaliRepository();
        }

        public bool Dodaj(SeIgraUSali seIgraUSali)
        {
            return seIgraUSaliRepository.Dodaj(seIgraUSali);
        }

        public bool Izmeni(SeIgraUSali seIgraUSali)
        {
            return seIgraUSaliRepository.Izmeni(seIgraUSali);
        }

        public bool Obrisi(SeIgraUSali seIgraUSali)
        {
            return seIgraUSaliRepository.Obrisi(seIgraUSali);
        }

        public List<SeIgraUSali> Pretraga(string by, Film film)
        {
            return seIgraUSaliRepository.Pretraga(by, film);
        }

        public List<SeIgraUSali> SviSeIgraUSali()
        {
            return seIgraUSaliRepository.SviSeIgraUSali();
        }
    }
}
