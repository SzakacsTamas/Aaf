using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helló Világ!");
            Console.WriteLine("Helló Világ!"[4]);
            double szam = 8.5;
            Console.WriteLine(szam);
            char s = 'k';
            Console.WriteLine(s);
            Console.WriteLine((char)(s+2));
            int i = 0;
            ++i;
            int a;
            a =4;

            Console.WriteLine(i);
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if(a % 2 ==0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Egyenlő");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("kettő");
                    break;
                case 3:
                    Console.WriteLine("három");
                    break;
                case 4:
                    Console.WriteLine("négy");
                    break;
                default:
                    Console.WriteLine("valami más");
                    break;
            }
            
        }
    }
}
