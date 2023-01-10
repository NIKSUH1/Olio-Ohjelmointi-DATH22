using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Laskin.summa(14, 15));
            Console.WriteLine(Laskin.erotus(16, 15));
            Console.WriteLine(Laskin.kertolasku(14, 2));
            Console.WriteLine(Laskin.jakolasku(14, 7));

        }
    }
}
