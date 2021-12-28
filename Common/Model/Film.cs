using System.Collections.Generic;

namespace Common.Model
{
    public class Film
    {
        public int IdFilma { get; set; }
        public string Naziv { get; set; }
        public string Trajanje { get; set; }
        public string Zanr { get; set; }
        List<Film> ListFilmova { get; set; }
        List<Gledalac> ListaGledaoca { get; set; }
        List<Sala> ListaSala { get; set; }
    }
}
