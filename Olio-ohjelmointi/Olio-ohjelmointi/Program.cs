using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira("Clara", "American bulldog", 1); // luodaan uusi koira olio/instanssi

            koira1.HaeTiedot();

            Console.WriteLine();

            Koira Koira2 = new Koira("Jerry", "Mittelspitz", 13);

            Koira2.HaeTiedot();

            Console.WriteLine();

            koira1.Hauku();
            Koira2.Hauku();
        }
    }
}
