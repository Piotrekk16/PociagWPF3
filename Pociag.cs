using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagWPF
{
    /// <summary>
    /// Klasa dla pociągów.
    /// </summary>
    
    class Pociag : IUzupelnijSklad, IPoprawnyPociag //podpięcie interfejsów
    {
        //deklaracja pól w klasie
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();
        private List<Wagon> wagony = new List<Wagon>();

        public bool MozeJechac() //metoda sprawdzająca czy pociag moze jechac
        {
            int masaL = 0; //zmienna pomocnicza na masę wszystkich lokomotyw
            for (int i=0; i< lokomotywy.Count;i++)
            {
                masaL += lokomotywy[i].PobierzMase();
            }

            int masaW = 0; //zmienna pomocniczna na masę wszystkich wagonów
            foreach (var element in wagony)
            {
                masaW += element.PobierzMase();
            }

            //instrukcja na sprawdzenie warunków
            if (masaL >= masaW && lokomotywy.Count > 0) return true;
            else return false;
        }

        public void DodajLokomotywe(string model, int masa) //metoda dodająca lokomotywę do składu pociągu
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public void DodajOsobowy(string model, int masa, string rodzaj) //metoda dodająca wagon osobowy do składu pociągu
        {
            wagony.Add(new Osobowy(model, masa,rodzaj));
        }

        public void DodajTowarowy(string model, int masa, string ladunek) //metoda dodająca wagon towarowy do składu pociągu
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }

        public string Informacje() //metoda zwracająca informacje o składzie pociągu
        {
            string info = "Skład pociągu:"; //zmienna pomocnicza
            for (int i =0; i<lokomotywy.Count;i++)
            {
                info += Environment.NewLine + lokomotywy[i].Informacje();
            }
            foreach(var element in wagony)
            {
                info += Environment.NewLine + element.Informacje();
            }
            return info;
            
        }
    }
}
