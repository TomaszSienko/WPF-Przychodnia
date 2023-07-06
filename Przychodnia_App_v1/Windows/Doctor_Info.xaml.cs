using Przychodnia_App_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Przychodnia_App_v1.Windows
{
    public partial class Doctor_Info : Window
    {
        PrzychodniaContext dbp = new PrzychodniaContext();
        public Doctor_Info()
        {
            InitializeComponent();
        }
        private void B_Window_Close2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void Filllekarz()
        {
            List<string> namemarge_lekarze = new List<string>();
            foreach (var item in dbp.Lekarzs)
            {
                string doctor = item.Imie + " " + item.Nazwisko + " " + "[" + item.Specjalizacja + "]";
                namemarge_lekarze.Add(doctor);
            }
            Listalekarzy.ItemsSource = namemarge_lekarze;
        }
        private void Listalekarzy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = Listalekarzy.SelectedItem.ToString();
            string[] nameParts = name.Split(' ');

            foreach (var item in dbp.Lekarzs)
            {
                if (item.Imie == nameParts[0] && item.Nazwisko == nameParts[1])

                {
                    Imie_box.Content = item.Imie;
                    Nazwisko_box.Content = item.Nazwisko;
                    id_lekarza_box.Content = item.IdLekarza;
                    specjalizacja_box.Content = item.Specjalizacja;
                    if (item.IdLekarza == 1)
                        Portret.Source = new BitmapImage(new Uri("/Images/Lekarz2.png", UriKind.Relative));

                    if (item.IdLekarza == 2)
                        Portret.Source = new BitmapImage(new Uri("/Images/Lekarz1.png", UriKind.Relative));

                    if (item.IdLekarza == 3)
                        Portret.Source = new BitmapImage(new Uri("/Images/Lekarz3.png", UriKind.Relative));

                    if (item.IdLekarza == 4)
                        Portret.Source = new BitmapImage(new Uri("/Images/Lekarz4.png", UriKind.Relative));
                    break;

                }



            }
        }
    }
}
