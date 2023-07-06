using Microsoft.IdentityModel.Tokens;
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
    /// <summary>
    /// Logika interakcji dla klasy Visit_WIndow.xaml
    /// </summary>
    public partial class Visit_WIndow : Window
    {
        static int id_pacjent;
        static int id_lekarz;
        PrzychodniaContext dbp = new PrzychodniaContext();
        public Visit_WIndow()
        {
            InitializeComponent();
        }
        private void B_Window_Close2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        public void Fill_list()
        {
            foreach( var wizyta in dbp.Wizyties )
            {
                if (wizyta.IdWizyty == Convert.ToInt32(id_wizyty_box.Content))
                {
                    Data_box.Content = wizyta.Data.ToString("yyyy-MM-dd");
                    Godzina_box.Content = wizyta.Godzina;
                    id_lekarz = wizyta.IdLekarza;
                    id_pacjent = wizyta.IdPacjenta;
                    Wizyta.Text = wizyta.WywiadLekarski;
                    Badania.Text = wizyta.BadaniePrzedmiotowe;
                    Zalecenia.Text = wizyta.Zalecenia;
                    break;

                }

            }
            foreach(var pacjent in dbp.Pacjents )
            {
                if(id_pacjent == pacjent.IdPacjenta)
                {
                    Imie_box.Content = pacjent.Imie;
                    Nazwisko_box.Content = pacjent.Nazwisko;
                    break;

                }
            }
            foreach(var lekarz in dbp.Lekarzs )
            {
                if(id_lekarz == lekarz.IdLekarza)
                {
                    Lekarz_box.Content = lekarz.Imie + " " + lekarz.Nazwisko + " ["+lekarz.Specjalizacja+"] ";
                    break;
                }

            }

            if(Wizyta.Text.IsNullOrEmpty() || Zalecenia.Text.IsNullOrEmpty() || Badania.Text.IsNullOrEmpty())
            {
                IsDone.Content = "X"; IsDone.Foreground = Brushes.Red ;
            }
            else { IsDone.Content = "V";IsDone.Foreground = Brushes.Green; }
            
        }

    }
}
