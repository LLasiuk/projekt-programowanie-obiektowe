using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Sklep
    {
        public List<Piekarnik> piekarniks;

        private List<Klient> klients;

        public Sklep()
        {
            piekarniks = new List<Piekarnik>();
            klients = new List<Klient>();
        }

        
        public Sklep(List<Piekarnik> piekarniksList)
        {
            piekarniks = piekarniksList;
        }

        public Sklep(List<Klient> klientsList)
        {
            klients = klientsList;
        }

        public void PrintPiekarniks()
        {

            foreach (var item in piekarniks)
            {
                Console.WriteLine($"{item.name},{item.tempreture}");
            }

            int i = 0;
       
            do
            {
                Console.WriteLine($"{piekarniks[i].name},{piekarniks[i].tempreture}");
                i++;

            } while (i < piekarniks.Count);
        }

        public void PrintKlients()
        {

            //foreach (var item in klients)
            //{
            //    Console.WriteLine($"{item.Id},{item.klientImie},{item.klientNazwisko},{item.accountStatus}");
            //}

            int i = 0;

            do
            {
                Console.WriteLine($"{klients[i].Id},{klients[i].klientImie}, {klients[i].klientNazwisko},{klients[i].accountStatus}");
                i++;

            } while (i < klients.Count);
        }


        public void KlientWchodziDoSklepu(Klient klient)
        {
            klients.Add(klient);
        }

        public void KlientWchodziDoSklepu(string imie, string nazwisko, double stanKonta)
        {
            Klient klient = new Klient();
            klient.klientImie = imie;
            klient.klientNazwisko = nazwisko;
            klient.accountStatus = stanKonta;
            klients.Add(klient);
        }

        public void KlientWychodziZeSklepu(Klient klient)
        {
            klients.Remove(klient);

        }

        public void KlientWychodziZeSklepu(int id)
        {
            
            Klient klient = new Klient();

            foreach (var item in klients)
            {
                if (item.Id == id)
                {
                    klient = item;
                }
            }

            if (klient.Id != null)
            {
                klients.Remove(klient);
            }
        }

        public void KlienciWchodzaDoSklepu(List<Klient> klientsFromApp )
        {
            //klients.AddRange(klientsFromApp);
            foreach (var item in klientsFromApp)
            {
                klients.Add(item);
            }
        }

        public void KlientVIP_Plus_GrupaKlientow(Klient vipKlient,List<Klient> grupaKlientow)
        {
            klients.Add(vipKlient);
            klients.AddRange(grupaKlientow);
        }
      
    }
}
