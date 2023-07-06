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
using System.Threading;
using Przychodnia_App_v1.Windows;
using Przychodnia_App_v1.Models;
using System.Windows.Controls.Primitives;

namespace Przychodnia_App_v1
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Win1 : Window
    {

        
        PrzychodniaContext dbp = new PrzychodniaContext();

        public Win1()
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
        private void B_powrot(object sender, RoutedEventArgs e)
        { 
            this.Hide();
        }
        private void B_Register_Button1(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextboxR1.Text) ||
                String.IsNullOrEmpty(TextboxR2.Text) ||
                String.IsNullOrEmpty(TextboxR3.Text) ||
                String.IsNullOrEmpty(TextboxR4.Text) ||
                String.IsNullOrEmpty(TextboxR5.Text))
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Nie wypełniono &#xD;&#xA;wszystkich pól!!!!!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Hide();
            }
            else
            {

                int id_konta = dbp.Konta.Count();
                Kontum nowekonto = new Kontum();

                nowekonto.Imie = TextboxR1.Text;
                nowekonto.Nazwisko = TextboxR2.Text;
                nowekonto.Email = TextboxR3.Text;
                nowekonto.Login = TextboxR4.Text;
                nowekonto.Haslo = TextboxR5.Text;
                nowekonto.IdKonta = id_konta + 1;

                dbp.Konta.Add(nowekonto);
                dbp.SaveChanges();

                Thread.Sleep(500);

                App.Current.MainWindow.Show();
                this.Hide();
            }
        }
    }
}
