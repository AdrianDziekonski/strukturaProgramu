using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public class Ssaki : Zwierzaki, IZwierze         //ssaki implementują KA ale musza to robić przed interfejsem
    {                                                //ssaki implementują meteody z interfejsu IZwierze, można implementować wlele interfejsów
        public Ssaki(string nazwa, int wiek, string rodzaj) : base(nazwa, wiek, rodzaj)
        {
        }//nwm czy to trzeba uzupełniać czy jeśli jest w bazowej klasie to nie trzeba tutaj

        public string name(string name)
        {
            //name = "ssak";
            return name;
        }

        public void oddychanie()
        {
            Console.WriteLine("płuca"); 
        }

        public void poruszanie()
        {
            Console.WriteLine("kończyny dolne lub 4 konczyny");
        }

        public void rozmnazanie()
        {
            Console.WriteLine("płód");
        }
    }
}
