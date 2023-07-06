using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Przychodnia_App_v1.Models;
using Przychodnia_App_v1.Windows;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Przychodnia_App_v1
{
    public partial class Win2 : Window
    {
        PrzychodniaContext dbp = new PrzychodniaContext();
        static private int temp_wizyta;

        public Win2()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void B_Window_Close2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void B_Window_Minimize2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void B_powrot2(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Hide();
        }
        private void B_Adresy(object sender, RoutedEventArgs e)
        {
            /* List<Adre> data = new List<Adre>();
             foreach (var item in dbp.Adres)
             {

                 data.Add(new Adre() { IdAdresu = item.IdAdresu,
                                       Miasto = item.Miasto,
                                       Ulica = item.Ulica,
                                       KodPocztowy = item.KodPocztowy,
                                       NrMieszkania = item.NrMieszkania,
                 });
             }
             Baza.ItemsSource = data;*/
            Baza.ItemsSource = dbp.Adres;
            
        }
        private void B_Pacjenci(object sender, RoutedEventArgs e)
        {
            List<Pacjent> data = new List<Pacjent>();
            foreach (var item in dbp.Pacjents)
            {

                data.Add(new Pacjent()
                {
                    IdPacjenta = item.IdPacjenta,
                    Pesel = item.Pesel,
                    IdAdresu = item.IdAdresu,
                    Imie = item.Imie,
                    Nazwisko = item.Nazwisko,
                    NumerTelefonu = item.NumerTelefonu,
                    Email = item.Email,
                });
            }
            Baza.ItemsSource = data;

        }
        private void B_Pacjent_Nowy(object sender, RoutedEventArgs e)
        {
            New_Patient_Form forma1 = new New_Patient_Form();
            forma1.Show();
        }
        private void B_Wizyta_Nowa(object sender, RoutedEventArgs e)
        { 
           New_Visit form1 = new New_Visit();
            form1.Show();
            form1.Filllekarz();
            form1.Fillpacjent();
        }
        private void B_Pacjent_Info(object sender, RoutedEventArgs e)
        {
            Patient_Window info_patient = new Patient_Window();
            info_patient.Show();
 
        }
        private void B_Lekarz_Info(object sender, RoutedEventArgs e)
        {
            Doctor_Info doctor_Info = new Doctor_Info();
            doctor_Info.Show();
            doctor_Info.Filllekarz();

        }
        private void B_Pacjent_Usun(object sender, RoutedEventArgs e)
        {


        }
        private void B_Utworz_konto(object sender, RoutedEventArgs e)
        {
            
            Win1 win1 = new Win1();
            win1.Show();

        }
        public struct Wizyta_Struckt
        {
            public string opis;
            public int id_pacjenta;
            public int id_lekarza;
            public string data;
        }
        public void fill_lists_dzisiejsze()
        {
            List<string> wizyty = new List<string>();
            
            List<Wizyta_Struckt> visit = new List<Wizyta_Struckt>();



            foreach(var item in dbp.Wizyties)
            {
                if (item.Data.ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    visit.Add(new Wizyta_Struckt()
                    {
                        opis = " ;ID Wizyty: " + item.IdWizyty + " ;Godzina: " + item.Godzina,
                        id_pacjenta = item.IdPacjenta,
                        id_lekarza = item.IdLekarza

                    });
                }
                
            }
            foreach(var pacjent in dbp.Pacjents)
            {
                foreach (var item in visit)
                {
                    if(item.id_pacjenta == pacjent.IdPacjenta)
                    {
                        wizyty.Add(pacjent.Imie + " " + pacjent.Nazwisko +"  " +item.opis);
                    }
                }
            }
            int i = 0;
            foreach (var lekarz in dbp.Lekarzs)
            {
                foreach (var item in visit)
                {
                    if (item.id_lekarza == lekarz.IdLekarza)
                    {
                        wizyty[i] += (" Lekarz: " + lekarz.Imie + " " + lekarz.Nazwisko);
                        i++;
                    }

                }
            }

            wizyty.Sort();
            Dzisiejsze_wizyty.ItemsSource = wizyty;
        }

        public void Wyswietl_dzisiejsze_wizyty(object sender, RoutedEventArgs e)
        {
            this.fill_lists_dzisiejsze();
            Dzisiejsze_wizyty.UnselectAll();
            Wizyty_Label.Content = "Dzisiejsze Wizyty";
        }
        private void Wybrano_wizyte(object sender, SelectionChangedEventArgs e)
        {
            if (Dzisiejsze_wizyty.SelectedItem != null)
            {
                string wizyta_wybrana = Dzisiejsze_wizyty.SelectedItem.ToString();
                string[] wizytaParts = wizyta_wybrana.Split(' ');
               
                temp_wizyta = int.Parse(wizytaParts[6]);
                
            }
           
        }
        private void Edycja_wybranej_wizyty(object sender, RoutedEventArgs e)
        {
            if (Dzisiejsze_wizyty.SelectedItem != null)
            { 
            Visit_Window_DoctorView wizyta_okno = new Visit_Window_DoctorView();
            
            wizyta_okno.id_wizyty_box.Content = temp_wizyta.ToString();
            wizyta_okno.Fill_list();
                wizyta_okno.Show();
            }

        }
        private void fill_list_all()
        {
            List<string> wizyty = new List<string>();

            List<Wizyta_Struckt> visit = new List<Wizyta_Struckt>();



            foreach (var item in dbp.Wizyties)
            {
                
                    visit.Add(new Wizyta_Struckt()
                    {
                        opis = "; ID Wizyty: " + item.IdWizyty + " ;Godzina: " + item.Godzina,
                        id_pacjenta = item.IdPacjenta,
                        id_lekarza = item.IdLekarza

                    });

            }
            foreach (var pacjent in dbp.Pacjents)
            {
                foreach (var item in visit)
                {
                    if (item.id_pacjenta == pacjent.IdPacjenta)
                    {
                        wizyty.Add(pacjent.Imie + " " + pacjent.Nazwisko + "  " + item.opis);
                    }
                }
            }
            int i = 0;
            foreach (var lekarz in dbp.Lekarzs)
            {
                foreach (var item in visit)
                {
                    if (item.id_lekarza == lekarz.IdLekarza)
                    {
                        wizyty[i] += (" Lekarz: " + lekarz.Imie + " " + lekarz.Nazwisko);
                        i++;
                    }

                }
            }

            wizyty.Sort();
            Dzisiejsze_wizyty.ItemsSource = wizyty;
        }
        private void Wyswietl_wszystkie_wizyty(object sender, RoutedEventArgs e)
        {
            this.fill_list_all();
            Dzisiejsze_wizyty.UnselectAll();
            Wizyty_Label.Content = "Wszystkie Wizyty";
        }
        private void fill_list_special()
        {
            List<string> wizyty = new List<string>();

            List<Wizyta_Struckt> visit = new List<Wizyta_Struckt>();

            DateTime data_wybrana = default(DateTime);

            DateTime? data_wybrana_temp = Calendar.SelectedDate;

            if (data_wybrana_temp != null)
            {
                data_wybrana = (DateTime)data_wybrana_temp;
            }

            foreach (var item in dbp.Wizyties)
            {
                if (item.Data.ToString("yyyy-MM-dd") == data_wybrana.ToString("yyyy-MM-dd"))
                {
                    visit.Add(new Wizyta_Struckt()
                    {
                        opis = " ;ID Wizyty: " + item.IdWizyty + " ;Godzina: " + item.Godzina,
                        id_pacjenta = item.IdPacjenta,
                        id_lekarza = item.IdLekarza

                    });
                }

            }
            foreach (var pacjent in dbp.Pacjents)
            {
                foreach (var item in visit)
                {
                    if (item.id_pacjenta == pacjent.IdPacjenta)
                    {
                        wizyty.Add(pacjent.Imie + " " + pacjent.Nazwisko + "  " + item.opis);
                    }
                }
            }
            int i = 0;
            foreach (var lekarz in dbp.Lekarzs)
            {
                foreach (var item in visit)
                {
                    if (item.id_lekarza == lekarz.IdLekarza)
                    {
                        wizyty[i] += (" Lekarz: " + lekarz.Imie + " " + lekarz.Nazwisko);
                        i++;
                    }

                }
            }

            wizyty.Sort();
            Dzisiejsze_wizyty.ItemsSource = wizyty;
        }
        private void Wybranie_dnia(object sender, SelectionChangedEventArgs e)
        {
            this.fill_list_special();
            Dzisiejsze_wizyty.UnselectAll();
            Wizyty_Label.Content = "Wybrane Wizyty";

        }

        private void Usun_wybrana_wizyte(object sender, RoutedEventArgs e)
        {
            if (Dzisiejsze_wizyty.SelectedItem != null)
            {
               foreach(var wizyta in dbp.Wizyties)
                {
                    if(wizyta.IdWizyty == temp_wizyta)
                    {
                        dbp.Remove(wizyta);
                        
                    }
                }
                dbp.SaveChanges();
                MessageBox.Show("Pomyśłnie usunięto wizytę");
            }


        }
    }
    }
   

