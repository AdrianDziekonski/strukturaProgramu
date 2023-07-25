using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public class AutoOsobowe : Pojazd
    {
        //public AutoOsobowe() 
        //{
        //    // Konstruktor pusty w przypadku jak bym chciał użyć Jsona bo jest wymagany
        //}
        public AutoOsobowe(int nrVin, string nazwa) : base(nrVin, nazwa)
        {
            this.nrVin = nrVin;
            this.nazwa = nazwa;
        }

        public AutoOsobowe(int nrVin, string nazwa,int przyspieszenie, 
            int przebiegNieoficjalny, int przebieg, int silnik): base(nrVin, nazwa)

            //nwm o co chodzi tu chciało base przy drugim konstruktorze a w dostawckach nie chciało
        {
            this.nrVin = nrVin;
            this.nazwa = nazwa;
            this.przyspieszenie= przyspieszenie;
            this.przebiegNieoficjalny = przebiegNieoficjalny;
            this.przebieg = przebieg;
            this.silnik = silnik;
        }


        public int nrVin { get; set; }

        public string nazwa { get; set; }

        public int przyspieszenie { get; set; }    //Włascicowsc wazna  w przyapdku auta osobowego

        private int przebiegNieoficjalny { get; set; }  //enkapsulacja stosujemy private żeby nie dało się tego zobaczyć

        public int przebieg { get; set; }

        public int silnik { get; set; }

        public static void polecBokiem()          //Metoda wazna tylko w aucie osobowym
        {

        }

        

        public override void zrobPrawoJAzdy()
        {
            Console.WriteLine("zrób prawko na B");
        }
    }
}
