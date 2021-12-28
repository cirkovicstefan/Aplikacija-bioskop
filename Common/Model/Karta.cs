using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Karta
    {
        public int IdKarte { get; set; }
        public int BrojSedista { get; set; }
        public int IdFilma { get; set; }
        public int IdSale { get; set; }
        public int IdGledaoca { get; set; }
        public decimal Cena { get; set; }
        public string DatumOdrzavanja { get; set; }
        public List<Film> ListFilmova { get; set; } = new List<Film>();
        public List<Sala> ListSala { get; set; } = new List<Sala>();
        public List<Gledalac> ListGledaoci { get; set; } = new List<Gledalac>();
    }
}
