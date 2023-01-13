using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas = new kiuas();

            while (true)
            {
                string syöte = Console.ReadLine();
                if (syöte == "päälle")
                {
                    kiuas.PistäPäälle(true);
                }
                if (syöte == "pois päältä")
                {
                    kiuas.PistäPäälle(false);
                }

                if (syöte == "lisää lämpöä")
                {
                    kiuas.LisääLämpöä();
                }

                if (syöte == "heitä löylyä")
                {
                    kiuas.IlmanKosteus();
                }
            }
        }
    }
}
