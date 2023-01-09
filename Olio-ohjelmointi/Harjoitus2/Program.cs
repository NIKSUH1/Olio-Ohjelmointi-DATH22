using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Jeesus", "666", 240);

            opiskelija1.TulostaData();
        }
    }
}
