using Common.Model;
using System.Collections.Generic;
using System;
using BusinessLayer;
using Common.Interface.Business;
using Common.Interface.Repository;
using DataAccessLayers;

namespace ConsoleBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            IKartaRepository kartaRepository = new KartaRepository();
            foreach(var item in kartaRepository.ZaradaFilmova())
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
