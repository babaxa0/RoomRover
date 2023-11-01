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
    /// Логика взаимодействия для Add_report.xaml
    /// </summary>
    public partial class Add_report : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Admin Admin { get; set; }
        public Add_report(Admin admin)
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
            Admin = admin;
            
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HomePageAdmin homePageAdmin = new HomePageAdmin(Admin);
            homePageAdmin.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb2.Text == "")
            {
                MessageBox.Show("Заполните поле дохода.");
                
            }
            else
            {
                if (tb3.Text == "")
                {
                    MessageBox.Show("Заполните поле расхода.");
                }
                else
                {
                    int x, y, z;
                    string s1 = tb2.Text;
                    x = Convert.ToInt32(s1);
                    string s2 = tb3.Text;
                    y = Convert.ToInt32(s2);
                    z = x - y;
                    tb4.Text = z.ToString();
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomePageAdmin homePageAdmin = new HomePageAdmin(Admin);
            homePageAdmin.Show();
            this.Close();
        }

        private void Finance_Click(object sender, RoutedEventArgs e)
        {
            //var finance = new Finance
            //{
            //    //Date_Finance = Convert.ToDateTime(DateFin.Text),
            //    //id_admin = 1,
            //    income = Convert.ToInt32(DohFin.Text),
            //    consumption = Convert.ToInt32(RasFin.Text),
            //    profit = Convert.ToInt32(PribFin.Text)
            //};

            var finance = new Finance();
            finance.Date_Finance = Convert.ToDateTime(tb1.Text);
            finance.income = Convert.ToInt32(tb2.Text);
            finance.consumption = Convert.ToInt32(tb3.Text);
            finance.profit = Convert.ToInt32(tb4.Text);
            finance.id_admin = 1;

            RoomRover1Entities3.Finance.Add(finance);
            RoomRover1Entities3.SaveChanges();
        }
    }
}
