using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    // static sanalla luodaan staattinen globaali luokka jossa ei tarvita tehdä olioita
    internal class Staattinen_Luokka
    {
        public static void StaattinenMetodi()
        {
            Console.WriteLine("Tämä on staattinen metodi");
        }

        public static float KmToMiles(float km)
        {
            float conversionRate = 0.62137f; // 1km --> 0.62137 mailia
            // palautetaan annetut kilometrit muuttettuna maileiksi
            return km * conversionRate;
        }
        
    }
}
