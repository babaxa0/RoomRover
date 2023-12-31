﻿using RoomRover.AddBase;
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
    /// Логика взаимодействия для HomePageAdmin.xaml
    /// </summary>
    public partial class HomePageAdmin : Window
    {
        RoomRover1Entities3 RoomRover1Entities3 { get; set; }

        Admin Admin { get; set; }
        public HomePageAdmin(Admin admin)
        {
            InitializeComponent();
            RoomRover1Entities3 = new RoomRover1Entities3();
            Admin = admin;
            NameAdminText.Content = admin.Name_admin;
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
            Add_report add_Report = new Add_report(Admin);
            add_Report.Show();
            this.Close(); 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Close();
        }
    }
}
