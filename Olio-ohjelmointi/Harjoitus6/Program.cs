using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira("American bulldog", "Clara", 35, 1);

            Kissa kissa = new Kissa("Musta", "Bengali", "Jussi", 10 , 6);


            koira.TulostaTiedotKoira();

            Console.WriteLine();

            kissa.TulostaTiedotKissa();
            
        }
    }
}
