using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface.Repository
{
    public interface ISeIgraUSaliRepository
    {
        bool Dodaj(SeIgraUSali seIgraUSali );
        bool Izmeni(SeIgraUSali seIgraUSali);
        bool Obrisi(SeIgraUSali seIgraUSali);
        List<SeIgraUSali> SviSeIgraUSali();
        bool SetBrojKarti(SeIgraUSali seIgraUSali);
        List<SeIgraUSali> Pretraga(string by, Film film);
    }
}
