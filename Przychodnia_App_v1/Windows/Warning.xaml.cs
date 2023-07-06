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

namespace Przychodnia_App_v1.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public Warning()
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
    }
}
