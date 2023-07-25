using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public class Dostawczaki : Pojazd                       //Warto klasami stopniowac szczegółowość. Tak jak tu ogólna klasa Pojazd
                                             //i w niej szczegółowe klasy.
    {
        public Dostawczaki(int nrVin, string nazwa) : base(nrVin, nazwa)  //dostawczaki dziedzicza po Pojazd i dlatego implemantuja konstruktor
        {                                              //base to odpowiednik super z JAVY?
                                                       //wskazuje że chcemy odnieść się składnika (o tej samej nazwie)
                                                       //klasy bazowej (this zamiast base-do aktualnej klasy)
            this.nrVin=nrVin;
            this.nazwa=nazwa;
        }

        public Dostawczaki(int nrVin, string nazwa, int ladownosc, int spalanie, int gwarancja, int przebieg) : this(nrVin, nazwa)
        {
            this.nrVin = nrVin;
            this.nazwa=nazwa;
            this.ladownosc = ladownosc;
            this.spalanie = spalanie;
            this.gwarancja = gwarancja;
            this.przebieg = przebieg;
        }

        public int nrVin { get; set; }

        public string nazwa { get; set; }   
        
        public int ladownosc { get; set; }         //Właściwość sprecyzowana dla dostawczaka

        public int spalanie { get; set; }

        public int gwarancja { get; set; }

        public int przebieg { get; set; }

        public static void otworzPake()        //Metody sprecyzowana dla dostawczaka
        {
            Console.WriteLine("Sezamie otwórz się");
        }

        public override void zrobPrawoJAzdy()       //Przez słowo kluczowe override służy do przesłoniecia
                                                    //metody w klaie podrzednej
        {
            Console.WriteLine("Zrób prawko na C");
        }
    }
}
