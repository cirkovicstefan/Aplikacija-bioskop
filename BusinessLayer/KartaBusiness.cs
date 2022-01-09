using Common.Interface.Business;
using Common.Interface.Repository;
using Common.Model;
using DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class KartaBusiness : IKartaBusiness
    {
        private readonly IKartaRepository kartaRepository;
        private readonly ISalaRepository salaRepository;
        private readonly ISeIgraUSaliRepository seIgraUSaliRepository;

        public KartaBusiness()
        {
            kartaRepository = new KartaRepository();
            salaRepository = new SalaRepository();
            seIgraUSaliRepository = new IgraSeUSaliRepository();
        }

        public bool Dodaj(Karta karta)
        {
            bool result = true;
            int kapaciteSale = 0;

            foreach (Sala item in salaRepository.SveSale())
            {
                if (item.IdSale == karta.IdSale)
                    kapaciteSale += item.Kapacitet;
            }

            int brojProdatihKarata = 0;
            foreach (var item in seIgraUSaliRepository.SviSeIgraUSali())
            {
                if (item.IdFilma == karta.IdFilma && item.IdSale == karta.IdSale)
                    brojProdatihKarata += item.BrojProdatihKarata;
            }
            foreach (var item in kartaRepository.SveKarte())
            {
                if (item.IdGledaoca == karta.IdGledaoca && item.IdFilma == karta.IdFilma && item.DatumOdrzavanja.Equals(karta.DatumOdrzavanja))
                    throw new Exception("Već ste kupili kartu za odabrani film !!!");
            }
            foreach (var item in kartaRepository.SveKarte())
            {
                if (item.BrojSedista == karta.BrojSedista && item.IdFilma==karta.IdFilma && item.DatumOdrzavanja==karta.DatumOdrzavanja)
                    throw new Exception("Karta sa tim brojem sedista je vec prodata");
            }
            if (kapaciteSale == brojProdatihKarata)
            {
                throw new Exception("Ne mozete da kupite kartu sala je popunjena!!!");
            }
          
            else if (kapaciteSale != brojProdatihKarata)
            {
                result = kartaRepository.Dodaj(karta);
                SeIgraUSali seIgraUSali = new SeIgraUSali();
                seIgraUSali.IdFilma = karta.IdFilma;
                seIgraUSali.IdSale = karta.IdSale;
                seIgraUSali.BrojProdatihKarata = brojProdatihKarata + 1;
                return seIgraUSaliRepository.SetBrojKarti(seIgraUSali) && result == true;
            }
            return false;
        }

        public bool Izmeni(Karta karta)
        {
            return kartaRepository.Izmeni(karta);
        }

        public bool Obrisi(Karta karta)
        {
            bool result = true;
            
            int brojProdatihKarata = 0;
            foreach (var item in seIgraUSaliRepository.SviSeIgraUSali())
            {
                if (item.IdFilma == karta.IdFilma && item.IdSale == karta.IdSale)
                    brojProdatihKarata += item.BrojProdatihKarata;
            }
            result = kartaRepository.Obrisi(karta);
            SeIgraUSali seIgraUSali = new SeIgraUSali();
            seIgraUSali.IdFilma = karta.IdFilma;
            seIgraUSali.IdSale = karta.IdSale;
            seIgraUSali.BrojProdatihKarata = brojProdatihKarata - 1;
            return result == true && seIgraUSaliRepository.SetBrojKarti(seIgraUSali);
        }

        public List<Karta> SveKarte()
        {
            return kartaRepository.SveKarte();
        }

        public List<string> ZaradaFilmova()
        {
            return kartaRepository.ZaradaFilmova();
        }

       
    }
}
