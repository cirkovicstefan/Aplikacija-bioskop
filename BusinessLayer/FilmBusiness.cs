using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class FilmBusiness : IFilmBusiness
    {
        private readonly IFilmRepository filmRepository;
        public FilmBusiness()
        {
            filmRepository = new FilmRepository();
        }

        public bool Dodaj(Film film)
        {
            foreach (var item in filmRepository.SviFilmovi())
            {
                if (item.Naziv.Equals(film.Naziv) && item.Zanr.Equals(film.Zanr) && item.IdFilma.Equals(film.IdFilma))
                    throw new Exception("Film vec postoji!!!");
            }
            return filmRepository.Dodaj(film);
        }

        public bool Izmeni(Film film)
        {
            return filmRepository.Izmeni(film);
        }

        public bool Obrisi(int idFilma)
        {
            foreach (var item in filmRepository.SviFilmovi())
            {
                if (item.IdFilma != idFilma) throw new Exception("Film koji zelite da obriste ne postoji!!!");
            }
            return filmRepository.Obrisi(idFilma);
        }

        public List<Film> SviFilmovi()
        => filmRepository.SviFilmovi();

    }
}
