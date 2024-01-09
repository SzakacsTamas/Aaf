using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_09_2024
{
    internal class diak:udvariasember
    {
        private int kor;
        public diak(string vNev, string kNev, int kor):base(vNev,kNev) 
        {
            this.kor = kor;
        }

        public void iskola()
        {
            if (kor<2)
            {
                Console.WriteLine("Gügyög");
            }
            else if(kor<3)
            {
                Console.WriteLine("Bölcsöde");
            }
            else if (kor < 7) { Console.WriteLine("Ovodás vagyok"); }
            else if (kor < 11) { Console.WriteLine("Alsós vagyok"); }
            else if (kor < 15) { Console.WriteLine("Felső tagozatos vagyok"); }
            else if (kor < 20) { Console.WriteLine("Technikumba járok vagyok"); }
            else if (kor < 25) { Console.WriteLine("EGYETEM!"); }
            else { Console.WriteLine("Felnőttem"); }
        }

       
    }
}
