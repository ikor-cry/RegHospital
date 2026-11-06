using RegHospital;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RegHospital.Objects;
using Microsoft.EntityFrameworkCore;
using RegHospital.Objects;

namespace RegHospitalDesctop
{
    /// <summary>
    /// Логика взаимодействия для RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        RegHospitalContext db =new RegHospitalContext();
        ObservableCollection<Room> rooms = new ObservableCollection<Room>();

        Room r_selected = new Room();

        public RoomPage()
        {
            InitializeComponent();

            db.Rooms.Load();
            rooms = db.Rooms.Local.ToObservableCollection();

            RoomsList.ItemsSource = rooms;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            rooms.Remove(r_selected);
            db.SaveChanges();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if((sender as StackPanel).DataContext is Room r)
            {
                DataContext = r;
                r_selected = r;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}
