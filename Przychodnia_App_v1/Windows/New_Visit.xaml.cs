using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Przychodnia_App_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Przychodnia_App_v1.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy List.xaml
    /// </summary>
    public partial class New_Visit : Window
    {
        PrzychodniaContext dbp = new PrzychodniaContext();
        static private int id_pacjenta;
        static private int id_lekarza;
        public New_Visit()
        {
            InitializeComponent();
        }

        public void Fillpacjent()
        {
            List<string> namemarge_pacjenci = new List<string>();


            foreach (var item in dbp.Pacjents)
            {
                string patient = item.Imie + " " + item.Nazwisko;
                namemarge_pacjenci.Add(patient);
            }

            Listapacjentow.ItemsSource = namemarge_pacjenci;

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

        private void Make_A_Visit(object sender, RoutedEventArgs e)
        {
            if (Listalekarzy.SelectedItem == null || Listapacjentow.SelectedItem == null)
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Nie wybrano lekarza lub pacjenta!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Close();
            }
            if (Date_box.SelectedDate == null || Hour_box.Text == null || minutes_box.Text == null)
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Nie wybrano Daty lub godziny!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Close();
            }
            else
            {
                string name_of_patient = Listapacjentow.SelectedItem.ToString();
                string name_of_doctor = Listalekarzy.SelectedItem.ToString();
                int godzina = int.Parse(Hour_box.Text);
                int minuta = int.Parse(minutes_box.Text);


                TimeSpan czas = new TimeSpan(godzina, minuta, 0);

                string[] nameParts = name_of_patient.Split(' ');
                string[] doctorParts = name_of_doctor.Split(' ');
                foreach (var item in dbp.Pacjents)
                {
                    if (item.Imie == nameParts[0] && item.Nazwisko == nameParts[1])
                    {
                        id_pacjenta = item.IdPacjenta; break;
                    }
                }
                foreach (var doctor in dbp.Lekarzs)
                {
                    if (doctor.Imie == doctorParts[0] && doctor.Nazwisko == doctorParts[1])
                    {
                        id_lekarza = doctor.IdLekarza; break;
                    }
                }
                Wizyty wizyta = new Wizyty();

                wizyta.IdLekarza = id_lekarza;
                wizyta.IdPacjenta = id_pacjenta;
                wizyta.Data = Date_box.SelectedDate ?? DateTime.MinValue;
                wizyta.Godzina = czas;

                dbp.Wizyties.Add(wizyta);
                dbp.SaveChanges();
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Pomyślnie Dodano Wizyte!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Close();
                this.Close();
            }
        }
    }
}
