using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lopputyö
{
    internal class Elokuva
    {
        public string Nimi;
        public int Vuosiluku;
        public int Kaudet;
        public string URIPath;

        public Elokuva(string nimi, int kaudet, int vuosiluku, string uriPath)
        {
            Nimi = nimi;
            Vuosiluku = vuosiluku;
            Kaudet = kaudet;
            URIPath = uriPath;
        }

        public string Lisätiedot()
        {
          
            string s = "-Nimi on: " + Nimi + "\n-Tehty vuonna: " + Vuosiluku + "\n-Kaudet: " + Kaudet;
            return s;
        }
    }
}
