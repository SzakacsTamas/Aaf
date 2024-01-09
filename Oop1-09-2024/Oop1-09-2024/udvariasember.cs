using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_09_2024
{
    internal class udvariasember : ember
    {
        public udvariasember(string vNev, string kNev) : base(vNev, kNev)
        {

        }

        public void koszon()
        {
            Console.WriteLine("Szia uram!");

        }
        public void koszon(ember emberValtozoNev)
        {
            Console.WriteLine("Szia {0} uram!",emberValtozoNev.teljesNev);

        }

        public void koszonNevvel(ember e)
        {
            Console.WriteLine("Szia {0} uram! {1}-vagyok",teljesNev,e.keresztNev);
        }
    }
}
