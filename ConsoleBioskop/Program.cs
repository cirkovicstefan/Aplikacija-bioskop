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
            string str = "1 stefan";
            str = str.Substring(2);
            Console.WriteLine(str);
            
        }
    }
}
