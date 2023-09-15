using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            while (szam < 99999)
            {
                Console.Write("Kérek egy számot: ");

                szam = Convert.ToInt32(Console.ReadLine());
                if (szam < 10)
                {
                    Console.WriteLine("A szám egy jegyű");
                }
                

            }
        }
    }
}
