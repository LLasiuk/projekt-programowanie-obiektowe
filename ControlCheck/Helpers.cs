using System;
using System.Collections.Generic;
using System.Text;

namespace ControlCheck
{
    class Helpers
    {

        public List<Stanowiska> WygenerowanieDanychStanowiska()
        {
            var stanowiska = new List<Stanowiska>();

            var stanowisko1 = new Stanowiska()
            {
                Id = 1,
                NazwaStanowiska = "Junior",
                ZarobkiOd = 1000,
                ZarobkiDo = 4000
            };
            stanowiska.Add(stanowisko1);

            var stanowisko2 = new Stanowiska()
            {
                Id = 2,
                NazwaStanowiska = "Middle",
                ZarobkiOd = 4001,
                ZarobkiDo = 6000
            };
            stanowiska.Add(stanowisko2);

            var stanowisko3 = new Stanowiska()
            {
                Id = 3,
                NazwaStanowiska = "Senior",
                ZarobkiOd = 6001,
                ZarobkiDo = 9000
            };
            stanowiska.Add(stanowisko3);

            return stanowiska;
        }

        public List<Pracownik> WygenerowanieDanycPracownika()
        {
            var pracownik = new List<Pracownik>();

            //var person = new Bogus.Person();

            var pracownik1 = new Pracownik()
            {
                Id = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Wiek = 25,
                Zarobki = 2500,
                Stanowisko = "Junior"
            };
            pracownik.Add(pracownik1);

            var pracownik2 = new Pracownik()
            {
                Id = 2,
                Imie = "Marta",
                Nazwisko = "Martyszewska",
                Wiek = 30,
                Zarobki = 5000,
                Stanowisko = "Middle"
            };
            pracownik.Add(pracownik2);

            var pracownik3 = new Pracownik()
            {
                Id = 3,
                Imie = "Grazyna",
                Nazwisko = "Boo",
                Wiek = 35,
                Zarobki = 7000,
                Stanowisko = "Senior"
            };
            pracownik.Add(pracownik3);

            return pracownik;
        }

        public List<Menu> DisplayMenu()
        {

            var options = new List<Menu>();

            var option1 = new Menu()
            {
                MenuOption = "1. Wyszukaj po stanowisku"
            };
            options.Add(option1);

            var option2 = new Menu()
            {
                MenuOption = "2. Wyszukaj po zarobkach"
            };
            options.Add(option2);

            var option3 = new Menu()
            {
                MenuOption = "3. Wyszukaj nazwe stanowiska wg. kwoty"
            };
            options.Add(option3);

            return options;
        }

        public void WyszukajPoStanowisku()
        {


        }

        public void WyszukajPoZarobkach()
        {


        }

        public void WyszukaNazweStanowiskaWgKwoty()
        {


        }
    }
}