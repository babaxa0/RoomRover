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
    /// Логика взаимодействия для PayRoom1.xaml
    /// </summary>
    public partial class PayRoom1 : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }

        Room Room { get; set; }
        public PayRoom1(Guest guest)
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
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            HomePageGuest homePageGuest = new HomePageGuest(Guest);
            homePageGuest.Show();
            this.Close();
        
        }

        private void bron_Click(object sender, RoutedEventArgs e)
        {
            if (Guest.Balance >=7900)
            {
                Guest.Balance -= 7900;
                var guest = RoomRover1Entities3.Guest.ToList().Where(x => x.id_guest == Guest.id_guest).FirstOrDefault();
                guest.Balance = Guest.Balance;
                guest.id_room = 1;
                RoomRover1Entities3.SaveChanges();
                MessageBox.Show("Вы оформили номер!");
                HomePageGuest homePageGuest = new HomePageGuest(guest);
                homePageGuest.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
