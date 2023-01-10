using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staattinen_Luokka.StaattinenMetodi();

            float kilometriArvo = 143.50f;
            // käytetään hyödyksi luotua globaalista  staattista
            // luokkaa joka muuttaa kilometrit maileiksi
            float mailiArvo = Staattinen_Luokka.KmToMiles(kilometriArvo);
            Console.WriteLine(kilometriArvo + "km on maileissa " + mailiArvo);




            /*
            // luodaan uusi albumi olio
            Albumi albumi = new Albumi("Evolve", "Imagine Dragons", "Poprock");

            albumi.LisääKappale(new Kappale("Next to me", "3:50"));
            albumi.LisääKappale(new Kappale("I don't know why", "3:10"));
            albumi.LisääKappale(new Kappale("What ever it takes", "3:30"));
            albumi.LisääKappale(new Kappale("Believer", "3:10"));
            albumi.LisääKappale(new Kappale("Thunder", "3:50"));

            albumi.TulostaTiedot(); */
        }
    }
}
