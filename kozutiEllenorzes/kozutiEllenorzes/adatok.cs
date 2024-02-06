using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozutiEllenorzes
{
    internal class adatok
    {
        public int ora;
        public int perc;
        public int masodperc;
        public string rendSzam;
        
        

        public adatok(string line)
        {
            string[] darab = line.Split(' ');
            ora = Convert.ToInt32(darab[0]);
            perc = Convert.ToInt32(darab[1]);
            masodperc = Convert.ToInt32(darab[2]);
            rendSzam = darab[3];
            
        }





    }
}
