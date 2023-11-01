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
using RoomRover.AddBase;

namespace RoomRover
{
    /// <summary>
    /// Логика взаимодействия для RestBar.xaml
    /// </summary>
    public partial class RestBar : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }
        public RestBar(Guest guest)
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
            Guest = guest;
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
            Rest rest = new Rest(Guest);
            rest.Show();
            this.Close();
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Bar bar = new Bar(Guest);
            bar.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomePageGuest homePageGuest = new HomePageGuest(Guest);
            homePageGuest.Show();
            this.Close();

        }
    }
}
