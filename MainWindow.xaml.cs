using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PociagWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pociag pociag = new Pociag(); //prywatne pole na obiekt "pociąg"
        
        public MainWindow()
        {
            InitializeComponent();
            Ukryj();
        }

        public void Ukryj() //metoda ukrywająca gridy
        {
            PanelLokomotywa.Visibility = Visibility.Hidden;
            PanelWagon.Visibility = Visibility.Hidden;
        }

        private void DodajLokomotywe_Click(object sender, RoutedEventArgs e) //odkrycie grida z dodawaniem lokomotyw
        {
            PanelLokomotywa.Visibility = Visibility.Visible;
            PanelWagon.Visibility = Visibility.Hidden;
        }

        private void DodajL_Click(object sender, RoutedEventArgs e) //dodanie lokomotywy do pociągu
        {
            try
            {
                int masaLok; //zmienna pomocnicza
                masaLok = Convert.ToInt32(MasaL.Text); //konwersja tekstu na liczbę typu int
                if (masaLok <=0) 
                    throw new ArgumentOutOfRangeException(); //sprawdzenie czy masa będzie dodatnia
                pociag.DodajLokomotywe(ModelL.Text, masaLok);
                SkladPociagu.Text = pociag.Informacje();
            }
            catch
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }

        }

        private void Ukryj_Click(object sender, RoutedEventArgs e) //ukrycie gridów
        {
            Ukryj();
        }

        private void DodajWagon_Click(object sender, RoutedEventArgs e) //odkrycie grida z dodawaniem wagonów
        {
            PanelLokomotywa.Visibility = Visibility.Hidden;
            PanelWagon.Visibility = Visibility.Visible;
        }

        private void DodajW_Click(object sender, RoutedEventArgs e) //dodanie wagonu do pociągu
        {
            try
            {
                int masaWag; //zmienna pomocnicza
                masaWag = Convert.ToInt32(MasaW.Text); //konwersja string ns int
                if (masaWag <= 0)
                    throw new ArgumentOutOfRangeException(); //sprawdzenie warunku aby masa była dodatnia
                if (Typ.SelectedIndex == 0)
                {
                    pociag.DodajOsobowy(ModelW.Text, masaWag,RodzajLadunek.Text);
                }
                else if (Typ.SelectedIndex == 1)
                {
                    pociag.DodajTowarowy(ModelW.Text, masaWag, RodzajLadunek.Text);
                }
                else //wyrzucenie wyjątku w sytuacji kiedy w liście rozwijanej nie jest nic wybrane
                {
                    throw new ArgumentNullException(); 
                }
                SkladPociagu.Text = pociag.Informacje();
            }
            catch
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }
        }

        private void SprawdzPociag_Click(object sender, RoutedEventArgs e) //wyświetlenie okienka z informacją czy pociąg może jechać
        {
            if (pociag.MozeJechac())
            {
                MessageBox.Show("Pociąg może jechać!");
            }
            else 
            {
                MessageBox.Show("Ups, coś jest nie tak! Pociąg nie może jechać!");
            }
        }
    }
}
