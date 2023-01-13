using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    internal class Hissi
    {
        public int minimiKerros;
        public int maximiKerros;
        public int nykyinenKerros;

        public Hissi(int minimiKerros, int maximiKerros, int nykyinenKerros)
        {
            this.minimiKerros = minimiKerros;
            this.maximiKerros = maximiKerros;
            this.nykyinenKerros = nykyinenKerros;
        }

        public void VaihdaKerrosta(int uusiKerros)
        {
            nykyinenKerros = uusiKerros;

            if (nykyinenKerros > maximiKerros)
            {
                nykyinenKerros = maximiKerros;
            }
            if (nykyinenKerros < minimiKerros)
            {
                nykyinenKerros = minimiKerros;
            }

            Console.WriteLine("Olet kerroksessa " + nykyinenKerros);
        }
    }
}
