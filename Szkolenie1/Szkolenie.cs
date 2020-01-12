using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Szkolenie1
{
    [TestFixture]

    public class Szkolenie
    {

        [Test]
        public void Test()
        {
            Piekarnik piekarnik1 = new Piekarnik();
            piekarnik1.name = "Samsung";
            piekarnik1.tempreture = 100;
            piekarnik1.isON = true;

            Piekarnik piekarnik2 = new Piekarnik()
            {
                isON = true,
                tempreture = 200,
                name = "Amica"
            };
            Console.WriteLine("To jest piekarnik o nazwie" + piekarnik1.name);

        }



    }
}
