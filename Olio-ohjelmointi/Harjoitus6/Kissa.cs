using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Kissa : Eläimet
    {
        public string väri;
        public string rotu;

        public Kissa(string väri, string rotu,string nimi, int paino, int ikä)
        {
            this.väri = väri;
            this.rotu = rotu;
            this.nimi = nimi;
            this.paino = paino;
            this.ikä = ikä;
        }

        public void TulostaTiedotKissa()
        {
            Console.WriteLine("Kissan väri on " + väri);
            Console.WriteLine("Kissan rotu on " + rotu);
            Console.WriteLine("Kissan nimi on " + nimi);
            Console.WriteLine("Kissa painaa " + paino + " kg");
            Console.WriteLine("Kissa on " + ikä + " vuotias");
        }
    }
}
