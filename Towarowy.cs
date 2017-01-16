using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagWPF
{
    /// <summary>
    /// Klasa dla wagonow towarowych.
    /// </summary>
    
    class Towarowy : Wagon //dziedziczenie
    {
        //deklaracja pola
        private string ladunek;

        public Towarowy(string model, int masa, string ladunek) //konstruktor parametryczny
            :base(model, masa)
        {
            this.ladunek = ladunek;
        }

        public override string Informacje() //metoda zwracająca informacje o wagonie towarowym
        {
            return "Wagon towarowy: model " + model + ", masa " + masa + ", ładunek " + ladunek;
        }
    }
}
