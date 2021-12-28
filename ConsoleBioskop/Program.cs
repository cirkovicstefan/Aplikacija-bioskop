using Common.Model;
using System.Collections.Generic;
using System;
using BusinessLayer;
using Common.Interface.Business;

namespace ConsoleBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            IKartaBusiness kartaBusiness = new KartaBusiness();
           Karta karta = new Karta()
            {
                IdKarte = 1005,
                IdFilma = 1,
                IdGledaoca = 1,
                IdSale = 1,
                BrojSedista = 100,
                Cena = 200,
                DatumOdrzavanja = "25.12.2021"
            };
            Karta karta2 = new Karta()
            {
                IdKarte = 3,
                IdFilma = 1,
                IdGledaoca = 2,
                IdSale = 1,
                BrojSedista = 100,
                Cena = 200,
                DatumOdrzavanja = "25.12.2021"
            };


          Console.WriteLine(kartaBusiness.Dodaj(karta));
            


          
            if (kartaBusiness.Obrisi(karta))
            {
                Console.WriteLine("uspesno");
            }
            else
            {
                Console.WriteLine("greska");
            }

            Console.WriteLine(kartaBusiness.ZaradaOdFilma("Alisa u zemlji cuda"));
           
           
            
        }
    }
}
