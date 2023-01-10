using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Albumi
    {
        public string albuminNimi;
        public string artisti;
        public string genre;

        // yksityinen lista kappale olioita jota voidaan käsitellä vain tämän 
        // luokan sisällä
        private List<Kappale> kappaleet = new List<Kappale>();

        public Albumi(string albuminNimi, string artisti, string genre)
        {
            this.albuminNimi = albuminNimi;
            this.artisti = artisti;
            this.genre = genre;
        }

        // metodi jolla lisätään kappaleet listaan uusia kappaleita
        // Parametrinä kappale olio
        public void LisääKappale(Kappale uusiKappale)
        {
            // lisätään listaan uusi kappale parametrin arvo
            kappaleet.Add(uusiKappale);
        }

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi:");
            Console.WriteLine(" -Artisti: " + artisti);
            Console.WriteLine(" -Albumin nimi: " + albuminNimi);
            Console.WriteLine(" -Genre: " + genre);
            Console.WriteLine("Songs");

            //Tulostetaan jokaisen kappaleen tiedot consoleen
            foreach (Kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }
    }
}
