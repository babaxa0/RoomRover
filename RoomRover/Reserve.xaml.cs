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
    /// Логика взаимодействия для Reserve.xaml
    /// </summary>
    public partial class Reserve : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }
        public Reserve(Guest guest)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PayRoom1 payRoom1 = new PayRoom1(Guest);
            payRoom1.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PayRoom2 payRoom2 = new PayRoom2(Guest);
            payRoom2.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PayRoom3 payRoom3 = new PayRoom3(Guest);
            payRoom3.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PayRoom4 payRoom4 = new PayRoom4(Guest);
            payRoom4.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PayRoom5 payRoom5 = new PayRoom5(Guest);
            payRoom5.Show();
            this.Close();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomePageGuest homePageGuest = new HomePageGuest(Guest);
            homePageGuest.Show();
            this.Close();
        }
    }
}
