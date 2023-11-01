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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoomRover.AddBase;

namespace RoomRover
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Account Account { get; set; }
        Admin Admin { get; set; }
        Guest Guest { get; set; }
        public MainWindow()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account = RoomRover1Entities3.Account.ToList().Where(x => x.login == LoginBox.Text && x.password == PassBox.Text).FirstOrDefault();

           var Guest = RoomRover1Entities3.Guest.ToList().Where(x => x.id_acc == Account.id_acc).FirstOrDefault();

           var Admin = RoomRover1Entities3.Admin.ToList().Where(x => x.id_acc ==  Account.id_acc).FirstOrDefault();

            if (Guest != null)
            {
                if (LoginBox.Text == "")
                {
                    System.Windows.MessageBox.Show("Заполните логин.");
                }
                else
                {
                    if (PassBox.Text == "")
                    {
                        System.Windows.MessageBox.Show("Заполните пароль.");
                    }
                    else
                    {
                        HomePageGuest homePage = new HomePageGuest(Guest);
                        homePage.Show();
                        this.Close();
                    }
                }
            }

            if (Admin != null)
            {
                if (LoginBox.Text == "")
                {
                    System.Windows.MessageBox.Show("Заполните логин.");
                }
                else
                {
                    if (PassBox.Text == "")
                    {
                        System.Windows.MessageBox.Show("Заполните пароль.");
                    }
                    else
                    {
                        HomePageAdmin homePage = new HomePageAdmin(Admin);
                        homePage.Show();
                        this.Close();
                    }
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();
            this.Close();
        }
    }
}
