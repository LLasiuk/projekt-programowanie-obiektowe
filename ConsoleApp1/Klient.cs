using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Klient
    {
        //---2.1. Klient ma nazwisk, imie, stan portfela(z wartoscia po przycinku, np. 100.00)---//
        public int? Id { get; set; }
        public string klientImie { get; set; }
        public string klientNazwisko { get; set; }
        public double accountStatus { get; set; }


    }
}
