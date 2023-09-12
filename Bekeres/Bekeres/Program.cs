using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bekeres
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Kérek egy szöveget: ");
            string szoveg=Console.ReadLine();
            Console.WriteLine("A bekért szöveg: " + szoveg);

            //üres sor végjelig
            szoveg = " ";
            while(szoveg!="")
            {
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();
            }
            //HÁZIIIIIIIIIIIIIII szavak bekérése, üres végjlelig, 
            //összegyűjtve egy váltózóban, valahogy elválasztva

            Console.Write("Kérek egy nem egész számot");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szám négyzete"+(szam *szam+1));
            Kérj be egy egész számot és annyiszor fusson le a szöveg bekérés és pl 5, 5x kérjeb be efy szót

            */
            Console.Write("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                Console.Write("Kérem a(z) " + (i + 1) + ". szöveget: ");
                Console.ReadLine();
            }
        }
    }
}
