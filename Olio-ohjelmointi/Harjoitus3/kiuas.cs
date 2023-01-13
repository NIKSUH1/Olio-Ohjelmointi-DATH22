using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    internal class kiuas
    {
        public bool onkoPäällä;
        public int lämpö;
        public float kosteus;

        public void PistäPäälle(bool on)
        {
            if (on)
            {
                onkoPäällä = true;
                Console.WriteLine("Laitoit kiukaan päälle");
                lämpö = 1;
            }
            else if (!on)
            {
                onkoPäällä = false;
                Console.WriteLine("Laitoit kiukaan pois päältä");
            }
        }

        public void LisääLämpöä()
        {
            lämpö = lämpö + 10;
            Console.WriteLine("lämpötila on " + lämpö);
        }
        public void IlmanKosteus()
        {
            kosteus = kosteus + 0.1f;
            Console.WriteLine("Saunan kosteus on " + kosteus);
        }
    }
}
