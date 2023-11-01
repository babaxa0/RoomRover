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
    /// Логика взаимодействия для HomePageGuest.xaml
    /// </summary>
    public partial class HomePageGuest : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }
        
        Account Account { get; set; }
        Guest Guest { get; set; }

        Room Room { get; set; }
        public HomePageGuest(Guest guest)
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
            Guest = guest;
            NameText.Content = guest.Name_guest;
            BalText.Content = guest.Balance;
            NameRoom.Text = guest.Room.name;
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Otzivi otzivi = new Otzivi(Guest);
            otzivi.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Reserve reserve = new Reserve(Guest);
            reserve.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SpaFitness fitness = new SpaFitness(Guest);
            fitness.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            RestBar restBar = new RestBar(Guest);
            restBar.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            UpBalance upBalance = new UpBalance(Guest);
            upBalance.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MyUslugi myUslugi = new MyUslugi(Guest);
            myUslugi.Show();
            this.Close();
        }
    }
}
