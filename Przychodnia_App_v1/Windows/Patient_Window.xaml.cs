using Przychodnia_App_v1.Models;
using Przychodnia_App_v1;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Permissions;
using Microsoft.EntityFrameworkCore;

namespace Przychodnia_App_v1.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy Patient_Window.xaml
    /// </summary>
    public partial class Patient_Window : Window
    {
        static private int id_adresu;
        static public int id_pacjenta;
        static private List<int> id_wizyt_list = new List<int>();
        PrzychodniaContext dbp = new PrzychodniaContext();
        public Patient_Window()
        {
            InitializeComponent();
            
            List<string> namemarge_pacjenci = new List<string>();

            foreach (var item in dbp.Pacjents)
            {
                string patient = item.Imie + " " + item.Nazwisko;
                namemarge_pacjenci.Add(patient);
            }
          
            Listapacjentow.ItemsSource = namemarge_pacjenci;
         
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void B_Window_Close2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Listapacjentow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int wizyty_count = 0;
            Ostatnia_wizyta_box.Content = null;
            Ilosc_Wizty_box.Content = null;
            Lista_Wizyt_list.ItemsSource = null;
            id_wizyt_list.Clear();
            string name = Listapacjentow.SelectedItem.ToString();
            string[] nameParts = name.Split(' ');

            foreach ( var item in dbp.Pacjents.Include(m=>m.IdAdresuNavigation))
            {
                if( item.Imie == nameParts[0] && item.Nazwisko == nameParts[1])

                {
                    Imie_box.Content = item.Imie;
                    Nazwisko_box.Content = item.Nazwisko;
                    PESEL_box.Content = item.Pesel;
                    Nrtel_box.Content = item.NumerTelefonu;
                    email_box.Content = item.Email;
                    id_adresu = item.IdAdresu;
                    id_pacjenta = item.IdPacjenta;
                    break;

                }
            }
            foreach (var adres in dbp.Adres)
            {
                if (id_adresu == adres.IdAdresu)
                {
                    miasto_box.Content = adres.Miasto;
                    ulica_box.Content = adres.Ulica;
                    kod_box.Content = adres.KodPocztowy;
                    nrmieszkania_box.Content = adres.NrMieszkania;
                    break;
                }
                
            }
           
            foreach (var wizyta in dbp.Wizyties)
            {
                if(id_pacjenta == wizyta.IdPacjenta)
                {
                    id_wizyt_list.Add(wizyta.IdWizyty);
                    wizyty_count = wizyty_count+1;
                    Ilosc_Wizty_box.Content = "Łącznie: " + wizyty_count;
                    Ostatnia_wizyta_box.Content = "nr " + wizyta.IdWizyty +" [ Data: "+wizyta.Data.ToString("yyyy-MM-dd") +" ]";

                    
                }

            }
            Lista_Wizyt_list.ItemsSource = id_wizyt_list;



        }
        private void Lista_Wizyt_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int wybrana_wizyta;

            if (Lista_Wizyt_list.SelectedItem != null)
            {
                Visit_WIndow wizyta_okno = new Visit_WIndow();
                wizyta_okno.Show();
                wizyta_okno.id_wizyty_box.Content=Lista_Wizyt_list.SelectedItem.ToString();
                wizyta_okno.Fill_list();

            }
        }

    }
}
