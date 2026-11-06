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
using System.Windows.Shapes;
using RegHospital.Objects;
using RegHospital;


namespace RegHospitalDesctop.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddDoctorWindow.xaml
    /// </summary>
    public partial class AddDoctorWindow : Window
    {
      
        RegHospitalContext db = new RegHospitalContext();

        public AddDoctorWindow()
        {
            InitializeComponent();

            listSpecs.ItemsSource = db.Specialties.ToList();
            listRoom.ItemsSource = db.Rooms.ToList();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
