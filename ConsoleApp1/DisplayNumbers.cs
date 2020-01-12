using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DisplayNumbers
    {
        public void DisplayNumbersFromOneToThousand()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Separate line for each number: \n" + i);
            }
        }
    }
}
