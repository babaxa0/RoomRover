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

namespace RoomRover
{
    /// <summary>
    /// Логика взаимодействия для Add_report.xaml
    /// </summary>
    public partial class Add_report : Window
    {
        public Add_report()
        {
            InitializeComponent();
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
            HomePageAdmin homePageAdmin = new HomePageAdmin();
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
                    string s2 = tb3.Text;s
                    y = Convert.ToInt32(s2);
                    z = x - y;
                    tb4.Text = z.ToString();
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomePageAdmin homePageAdmin = new HomePageAdmin();
            homePageAdmin.Show();
            this.Close();
        }
    }
}
