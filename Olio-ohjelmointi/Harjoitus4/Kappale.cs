using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Kappale
    {
        public string nimi;
        public string kesto; //esim 3:50

        // konstruktori, jolla pakotetaan asettamaan arvot olioille luonti vaiheessa
        public Kappale(string nimi, string kesto)
        {
            this.nimi = nimi;
            this.kesto = kesto;
        }

        // Tulostaa kappaleen tiedot
        public void TulostaTiedot()
        {
            Console.WriteLine("---Nimi: " + nimi + " - " + kesto);
        }
    }
}
