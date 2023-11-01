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
    /// Логика взаимодействия для MyUslugi.xaml
    /// </summary>
    public partial class MyUslugi : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }
        public MyUslugi(Guest guest)
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
            Guest = guest;
            UslugiUI(Guest);

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

        public void UslugiUI(Guest guest)
        {
            var rgbUslugi = RoomRover1Entities3.RGB_Uslugi.Where(x => x.id_human == guest.id_guest).FirstOrDefault();

            if (rgbUslugi !=null)
            {
                switch (rgbUslugi.spa)
                {
                    case true:
                        TSpa.Foreground = Brushes.Green;
                        break;

                    case false:
                        TSpa.Foreground = Brushes.Red;
                        break;

                }


                switch (rgbUslugi.fitnes)
                {
                    case true:
                        TFintnes.Foreground = Brushes.Green;
                        break;

                    case false:
                        TFintnes.Foreground = Brushes.Red;
                        break;

                }

                switch (rgbUslugi.bar)
                {
                    case true:
                        TBar.Foreground = Brushes.Green;
                        break;

                    case false:
                        TBar.Foreground = Brushes.Red;
                        break;

                }

                switch (rgbUslugi.restor)
                {
                    case true:
                        TRest.Foreground = Brushes.Green;
                        break;

                    case false:
                        TRest.Foreground = Brushes.Red;
                        break;

                }
            }
        }
    }
}
