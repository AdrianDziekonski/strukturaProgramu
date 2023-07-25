using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaProgramuWgMnie
{
    public abstract class Zwierzaki
    {
        public Zwierzaki(string nazwa, int wiek, string rodzaj)
        {
            Nazwa = nazwa;
            Wiek = wiek;
            Rodzaj = rodzaj;


        }
        public string Nazwa { get; private set; }   ///hermetyzacja zastosowanie private 
        //                      sprawia ze w program nie można ziemić tej propoerty

        public int Wiek { get; set; }   

        public string Rodzaj { get; set; }
    }
}
