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

namespace RoomRover
{
    /// <summary>
    /// Логика взаимодействия для RestBar.xaml
    /// </summary>
    public partial class RestBar : Window
    {
        public RestBar()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rest rest = new Rest();
            rest.Show();
            this.Close();
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Bar bar = new Bar();
            bar.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomePageGuest homePageGuest = new HomePageGuest();
            homePageGuest.Show();
            this.Close();

        }
    }
}
