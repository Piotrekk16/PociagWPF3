using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagWPF
{
    /// <summary>
    /// Klasa dla wagonow osobowych.
    /// </summary>
    
    class Osobowy : Wagon //dziedziczenie
    {
        //deklaracja pola
        private string rodzaj;

        public Osobowy(string model, int masa, string rodzaj) //konstruktor parametryczny
            :base(model, masa)
        {
            this.rodzaj = rodzaj;
        }

        public override string Informacje() //metoda zwracająca informacje o wagonie osobowym
        {
            return "Wagon osobowy: model " + model + ", masa " + masa + ", rodzaj " + rodzaj;
        }
    }
}
