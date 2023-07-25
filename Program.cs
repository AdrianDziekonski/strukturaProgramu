using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pojazd pojazd= new Pojazd();    - błąd nie można utworzyć obiektu KA

            AutoOsobowe autoOsoboweAudi = new AutoOsobowe(12345,"Audi",7,430000,200000,1800);  //konstruktor nr 2

            AutoOsobowe autoOsoboweBmw = new AutoOsobowe(54321, "Bmw");  //konstruktur z klasy abstrakyjnej

            Dostawczaki dostawczakiSprinter = new Dostawczaki(32414, "Sprinter");   //konstruktor z KA

            Dostawczaki dostawczakiDucato = new Dostawczaki(543342, "Ducato", 2600, 11, 7, 765000); //drugi konstruktor utworzony w klasie Dostawczaki

            autoOsoboweAudi.zrobPrawoJAzdy();






            //Zwierzęta po interfejsie

            Ssaki ssakPies = new Ssaki("reksio", 5, "kundel");

            ssakPies.poruszanie();

            //ssakPies.name = "dsafas";           //użytye private przy set i nie można zmieniać propoerty

            ssakPies.Rodzaj = "terier";

            ssakPies.Wiek = 6;

            Console.WriteLine("wiek reksia to "+ ssakPies.Wiek);

            Ptaki ptakBocian = new Ptaki();     //implementuje tylko interfejs a nie KA i nie ma konstruktora

           

            Console.WriteLine("przebieg" +" "+ autoOsoboweAudi.przebieg +"km");
        }
    }
}



    
