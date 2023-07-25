using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public class Ptaki : IZwierze           //ptaki implementują meteody z interfejsu IZwierze
    {
        public string name(string name)
        {
            name = "ptak";
            return name;
            
        }

        public void oddychanie()
        {
            Console.WriteLine("płuca i worki powietrzne"); ;
        }

        public void poruszanie()
        {
            Console.WriteLine("latanie skrzydłami");
        }

        public void rozmnazanie()
        {
            Console.WriteLine("składnaie jaj");
        }
    }
}
