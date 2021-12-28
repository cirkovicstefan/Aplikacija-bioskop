using System;
using System.Collections.Generic;

namespace Common.Model
{
    public class SeIgraUSali
    {
        public int IdFilma { get; set; }
        public int IdSale { get; set; }
        public string DatumOdrzavanja { get; set; }
        public string VremeOdrzavanja { get; set; }
        public int BrojProdatihKarata { get; set; }
        public List<Film> ListFilmova { get; set; } = new List<Film>();
        public List<Sala> ListSala { get; set; } = new List<Sala>();
    }
}
