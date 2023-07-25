using System;
using System.Collections.Generic;           //Wg mnie przykładowa struktura więc może być zła
using System.Data;
using System.Linq;                          //Poza tym raczej w innym programie może wygladać zupełnie inaczej
using System.Text;
using System.Threading.Tasks;               // niż tu np Interecey i KlasyAbstrakycyjne na "górze"



namespace StrukturaProgramuWgMnie     //Pojemnik na klasy. W danym namespace mogę korzystać
                                      //z klas w nim umieszczonych. Jak zrobię klasę poza namespace
                                      //to nie będzie dostepna w klasach w tym namespace. Oprócz tego
                                      //który tworzony jest przy zrobieniu projektu, są wbudowane: System,
                                      //System. Linq itd
{

    public abstract class Pojazd                     //Klasa abstrakcyjna. Nie moża utworzyć obiektu tej klasy.
                                     //

    {
        public Pojazd(int nrVin, string nazwa)     //Konstruktor jest to specjalna metoda klasy, która jest
                                                   //wywoływana jako pierwsza podczas tworzenia obiektu. Konstruktor
                                                   //ma taką samą nazwę jak nazwa klasy i nie zwraca żadnych wartości.
                                                   //Klasa może posiadać wiele konstruktorów jednak muszą się one
                                                   //różnić typem lub ilością argumentów. Konstruktor jest wywoływany
                                                   //za pomocą wyrażenia new podczas tworzenia obiektu. Konstruktor
                                                   //bardzo często wykorzystywany jest do inicjowania elementów obiektu.
        {
            NrVin = nrVin;
            Nazwa = nazwa;
        }

        public int NrVin { get; set; }          //Właściwości ogólne dla wielu mozliwych pojazdów
        public string Nazwa { get; set; }       //Właściwości ogólne dla wielu mozliwych pojazdów


        public  void wlaczsilnik()        //Metody ogolne dla wielu mozliwych pojazdów
        {
            Console.WriteLine("wrrrr wrrrrr");
        }

        public abstract void zrobPrawoJAzdy();   //W metodzie abstrakycyjnej nie ma ciała, podajemy je w dziedzicządcej dopiero

    }

      
       


    
}
