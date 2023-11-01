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
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        public Regist()
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
        }
        private void ExitButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButt_MouseDown(object sender, MouseButtonEventArgs e)
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var account = new Account
            {
                login = RegLogBox.Text,
                password = RegLogBox.Text,
                Id_role = 1   
            };

            var guest = new Guest
            {
                Account = account,
                Name_guest = RegNameBox.Text,
                id_acc = account.id_acc,
                Balance = 0,
                id_room = 7
            };


            RoomRover1Entities3.Account.Add(account);
            RoomRover1Entities3.Guest.Add(guest);
            RoomRover1Entities3.SaveChanges();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
