using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagWPF
{
    /// <summary>
    /// Klasa na przechowywanie informacji o lokomotywie.
    /// </summary>
    /// 

    class Lokomotywa
    {
        //deklaracja pól w klasie
        private string model;
        private int masa;

        public Lokomotywa(string model, int masa) //konstruktor parametryczny
        {
            this.model = model;
            this.masa = masa;
        }

        public int PobierzMase() //metoda zwracająca masę
        {
            return masa;
        }

        public string Informacje() //metoda zwracająca informacje o lokomotywie
        {
            return "Lokomotywa: model " + model + ", masa " + masa;
        }
    }
}
