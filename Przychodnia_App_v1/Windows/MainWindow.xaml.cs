using Przychodnia_App_v1.Windows;
using Przychodnia_App_v1.Models;
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
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace Przychodnia_App_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public bool logon_box_open=false;
        public MainWindow()
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
            Application.Current.Shutdown();
        }
        private void B_Window_Minimize1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void B_Rejestracja(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Hide();
            Win1 win1 = new Win1();
            win1.Show();
            
        }
        private void B_logowanie1(object sender, RoutedEventArgs e)
        {
            if (logon_box_open == false)
            {
                Login_Window login_win1 = new Login_Window();
                logon_box_open = true;
                login_win1.Show();
            }
            
        }


        PrzychodniaContext dbp = new PrzychodniaContext();

        public void Open_Win2()
        {
           
            Win2 okienko = new Win2();
            okienko.Show();
           

        }

        private void B_TryLog1(object sender, RoutedEventArgs e)
        {
             bool loged = false;
             foreach (var item in dbp.Konta)
             {
                 if (item.Login == B_LoginInput.Text && item.Haslo == B_PasswordInput.Password.ToString())
                 {
                     Hide();
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
