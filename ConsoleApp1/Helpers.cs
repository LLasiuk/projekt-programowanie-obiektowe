using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Helpers
    {

        public static void DisplayResult(int temperatureDisplay, bool isONDisplay, string nameDisplay)
        {
            Console.WriteLine($"To jest piekarnik o nazwie {nameDisplay}");
            Console.WriteLine($"Temperatura piekarnika to {temperatureDisplay}");
            Console.WriteLine($"Piekarnik jest wlaczony {isONDisplay}");
        }

        public static void DisplayKlient(string klientImieDisplay, string klientNazwiskoDisplay,double klientAccountStatusDisplay)
        {
            Console.WriteLine($"Klient ma na imie {klientImieDisplay}");
            Console.WriteLine($"Klient ma na nazwisko {klientNazwiskoDisplay}");
            Console.WriteLine($"Stan konta klienta wynosi {klientAccountStatusDisplay}");
        }

    }
}
