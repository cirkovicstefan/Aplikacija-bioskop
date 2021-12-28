using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface.Business
{
    public interface ISeIgraUSaliBusiness
    {
        bool Dodaj(SeIgraUSali seIgraUSali );
        bool Izmeni(SeIgraUSali seIgraUSali);
        bool Obrisi(SeIgraUSali seIgraUSali);
        List<SeIgraUSali> SviSeIgraUSali();
    }
}
