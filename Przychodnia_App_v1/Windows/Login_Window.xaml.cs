using Microsoft.VisualBasic;
using Przychodnia_App_v1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
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
    public partial class Login_Window : Window
    {
        string Login;
        string Password;

        PrzychodniaContext dbp = new PrzychodniaContext();
        public Login_Window()
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
            MainWindow.logon_box_open = false;
        }
        private void B_Window_Minimize1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public void  Open_Win2()
        {
            App.Current.MainWindow.Hide();
            Win2 okienko = new Win2();
            okienko.Show();
            

        }

        private void B_TryLog1(object sender, RoutedEventArgs e)
        {
            bool loged=false;
            foreach (var item in dbp.Konta)
            {
                if (item.Login == B_LoginInput.Text && item.Haslo == B_PasswordInput.Password.ToString())
                {
                    this.Close();
                    Open_Win2();
                    loged = true;
                    MainWindow.logon_box_open = false;
                    break;
                }
            }
            if (loged != true)
            {
                Warning okienko = new Warning();
                okienko.Ostrzezenie.Content = "Błędne dane logowanie!";
                okienko.Show();
                Thread.Sleep(1500);
                okienko.Hide();
            }

        }
    }
}
