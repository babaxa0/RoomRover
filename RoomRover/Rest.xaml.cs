using RoomRover.AddBase;
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
    /// Логика взаимодействия для Rest.xaml
    /// </summary>
    public partial class Rest : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Guest Guest { get; set; }
        public Rest(Guest guest)
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
            RestBar restBar = new RestBar(Guest);
            restBar.Show();
            this.Close();
        }

        private void BronRest_Click(object sender, RoutedEventArgs e)
        {
            if (Guest.Balance >= 5000)
            {
                Guest.Balance -= 5000;
                var guest = RoomRover1Entities3.Guest.ToList().Where(x => x.id_guest == Guest.id_guest).FirstOrDefault();
                guest.Balance = Guest.Balance;
                guest.Id_Rest = 1;
                RoomRover1Entities3.SaveChanges();

                try
                {

                    var rgbUslugi = RoomRover1Entities3.RGB_Uslugi.Where(x => x.id_human == guest.id_guest).FirstOrDefault();

                    if (rgbUslugi != null)
                    {
                        rgbUslugi.restor = true;
                        RoomRover1Entities3.SaveChanges();
                        return;
                    }
                    else
                    {
                        rgbUslugi = new RGB_Uslugi();
                        rgbUslugi.id_human = guest.id_guest;
                        rgbUslugi.restor = true;
                        RoomRover1Entities3.RGB_Uslugi.Add(rgbUslugi);
                        RoomRover1Entities3.SaveChanges();
                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("Услугу он уже имеет");
                    return;

                }

                MessageBox.Show("Вы приобрели безлимитное посещение!");
                SpaFitness spaFitness = new SpaFitness(Guest);
                spaFitness.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
