using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 95; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
