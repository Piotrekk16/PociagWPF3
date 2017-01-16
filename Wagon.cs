using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagWPF
{
    /// <summary>
    /// Abstrakcyjna klasa dla wagonów.
    /// </summary>
    
    abstract class Wagon
    {
        //deklaracja pól w klasie
        protected string model;
        protected int masa;

        abstract public string Informacje(); //deklaracja abstrakcyjnej metody dla zwracania informacji o wagonie

        public int PobierzMase() //metoda zwracająca masę wagonu
        {
            return masa;
        }

        public Wagon(string model, int masa) //konstruktor parametryczny
        {
            this.model = model;
            this.masa = masa;
        }
    }
}
