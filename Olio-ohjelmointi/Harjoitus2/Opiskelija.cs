using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        public string Nimi;
        public string OpiskelijaID;
        public int OpintoPisteet;

        public Opiskelija(string nimi, string opiskelijaId, int opintoPisteet)
        {
            Nimi = nimi;
            OpiskelijaID = opiskelijaId;
            OpintoPisteet = opintoPisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine("Opiskelijan nimi on " + Nimi);
            Console.WriteLine("Opiskelijan ID on " + OpiskelijaID);
            Console.WriteLine("Opiskelijan tarviima OP määrä " + OpintoPisteet);
        }
    }
}
