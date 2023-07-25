using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public interface IZwierze        //Tworzymy by stworzyć schemat zachowan dla wiekszej grupy, nazwa z I na początku
    {
        void oddychanie();          //wszystkie metody w Interfejsie są publiczne i abstrakcyjne, więc nie trzeba tego pisac

        void poruszanie();

        void rozmnazanie();

         string name(string name);    

        //po Interfejsie muszą być zaimplementowane wszystkie elementy w klasie która implementuje

    }
}
