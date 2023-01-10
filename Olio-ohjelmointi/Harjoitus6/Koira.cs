using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Koira : Eläimet
    {
        public string rotu;

        public Koira(string rotu, string nimi, int paino, int ikä)
        {
            this.rotu = rotu;
            this.nimi = nimi;
            this.paino = paino;
            this.ikä = ikä;
        }

        public void TulostaTiedotKoira()
        {
            Console.WriteLine("Koiran rotu on " + rotu);
            Console.WriteLine("Koiran nimi on " + nimi);
            Console.WriteLine("Koira painaa " + paino + " kg");
            Console.WriteLine("Koira on " + ikä + " vuotias");
        }
    }
}
