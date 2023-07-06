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
using System.Windows.Shapes;
using Przychodnia_App_v1.Windows;
using Przychodnia_App_v1.Models;
using System.Threading;
using System.Windows.Controls.Primitives;

namespace Przychodnia_App_v1
{
    public partial class New_Patient_Form : Window
    {
        PrzychodniaContext dbp = new PrzychodniaContext();
        public New_Patient_Form()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void B_Window_Close1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void B_Window_Minimize1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void B_New_Patient_Creation(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Textbox_imie.Text) ||
                String.IsNullOrEmpty(Textbox_nazwisko.Text) ||
                String.IsNullOrEmpty(Textbox_pesel.Text) ||
                String.IsNullOrEmpty(Textbox_nrtel.Text) ||
                String.IsNullOrEmpty(Textbox_mail.Text) ||
                String.IsNullOrEmpty(Textbox_miasto.Text) ||
                String.IsNullOrEmpty(Textbox_ulica.Text) ||
                String.IsNullOrEmpty(Textbox_nrmieszkania.Text) ||
                String.IsNullOrEmpty(Textbox_kodpoczt.Text)
                )
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Nie wypełniono wszystkich pól!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Close();
            }
            else if(Textbox_pesel.Text.Length != 11)
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Zły pesel!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Hide();
            }
                
            else
            {
                Adre adres = new Adre();
                adres.Miasto = Textbox_miasto.Text;
                adres.Ulica = Textbox_ulica.Text;
                adres.NrMieszkania = Textbox_nrmieszkania.Text;
                adres.KodPocztowy = Textbox_kodpoczt.Text;
                /*adres.IdAdresu = dbp.Adres.Count()+1;*/





                Pacjent pacjent = new Pacjent();

                pacjent.Pesel = Textbox_pesel.Text;
                pacjent.Imie = Textbox_imie.Text;
                pacjent.Nazwisko = Textbox_nazwisko.Text;
                pacjent.NumerTelefonu = Textbox_nrtel.Text;
                pacjent.Email = Textbox_mail.Text;
                pacjent.IdAdresu = adres.IdAdresu;
               


                dbp.Adres.Add(adres);
                dbp.Pacjents.Add(pacjent);
                dbp.SaveChanges();
                
                Thread.Sleep(500);

                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Dodano nowego pacjenta";
                okienko.Show();
                Thread.Sleep(500);
                okienko.Close();

                this.Close();
            }
        }


    }
}
