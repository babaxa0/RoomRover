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
    /// Логика взаимодействия для Otzivi.xaml
    /// </summary>
    public partial class Otzivi : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }
        public Otzivi(Guest guest)
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
    }
}
