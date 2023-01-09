using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class Koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;

        // Constructori jolla pakotetaan olion luonti tilanteessa
        // Antamaan tarvittavat tiedot oliolle ( nimi ro,u ja ikä)
        public Koira(string nimi, string rotu, int ikä)
        {
            Nimi = nimi;
            Rotu = rotu;
            Ikä = ikä;
        }

        public void HaeTiedot()
        {
            Console.WriteLine("Koira nimi on " + Nimi);
            Console.WriteLine("Koira ikä on " + Ikä);
            Console.WriteLine("Koira rotu on " + Rotu);
        }
        public void Hauku()
        {
            Console.WriteLine(Nimi + " Woof woof");
        }
    }
}
