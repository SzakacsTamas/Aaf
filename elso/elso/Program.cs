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
            double szam2 = 1;
            while (szam2<5)
            {
                Console.WriteLine(szam2);
                szam2 += 0.1;
            }
            do
            {
                szam2 -= .2;
                Console.WriteLine(szam2);
            }
            while (szam2 > 2);

            char betu = 'a';
            while (betu<='z')
            {
                Console.Write(betu);
                betu = (char)(betu + 1);
            }
            int szam32 = 32;
            while (szam32<=250)
                
            {

                Console.Write((char)szam32 + " ");
                if (szam32 % 8 == 7)
                {
                    Console.WriteLine();
                }
                szam32++;
              
                


            }
            Console.WriteLine();
            Console.WriteLine();
            for (int k=0; k<10; k++)
            {
                Console.WriteLine(k);
            }
            int szamol=0;
            for (int f = 1; f <=15; f++)
            {
                szamol += f;
            }
            Console.WriteLine(szamol);

            for (int g=9; g>0; g--)
            {
                Console.WriteLine(g);
            }
            for (int h = 0; h < 10; h++)
            {
                Console.WriteLine(9 - h);
            }
        }
    }
}
