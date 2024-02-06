using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class Absztark:Interface1
    {
        public int szam()
        {
            return 1000000;
        }
        public abstract void kiir();
        int privatTusko;
        public int tusko
        {
            get { return privatTusko; }
            set { privatTusko=value;}
        }
    }
}
