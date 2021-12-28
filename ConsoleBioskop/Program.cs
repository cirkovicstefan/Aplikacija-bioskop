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
            IGledalacBusiness gledalacBusiness = new GledalacBusiness();
            IFilmBusiness filmBusiness = new FilmBusiness();
          
            foreach(var item in filmBusiness.SviFilmovi())
            {
                Console.WriteLine(item.Naziv+item.Zanr+item.Trajanje+item.IdFilma);
            }
            


          
           
            
        }
    }
}
