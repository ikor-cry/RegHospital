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
using RegHospitalDesctop.Windows;

namespace RegHospitalDesctop.Pages
{
    /// <summary>
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        RegHospitalContext db = new RegHospitalContext();
        ObservableCollection<Doctor> docs = new ObservableCollection<Doctor>();
        
        public DoctorPage()
        {
            InitializeComponent();

            db.Doctors.Include(s => s.Specialtie).Include(e => e.Room).Load();
            docs = db.Doctors.Local.ToObservableCollection();
            tableDoctor.ItemsSource = docs;

            SpecList.ItemsSource = db.Specialties.ToList();
            RoomsList.ItemsSource = db.Rooms.ToList();

        }

        private void btnclick(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void tableDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tableDoctor.SelectedItem is Doctor d)
            {
                this.DataContext = d;
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Doctor d = new Doctor();
            AddDoctorWindow w = new AddDoctorWindow();
            w.DataContext = d;


            if (w.ShowDialog() == true) // стоит код пока не закроем окно
            {
                docs.Add(d);

                db.SaveChanges();
            }
            
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (tableDoctor.SelectedItem is Doctor d)
            {
                var r = MessageBox.Show($"Точно удалить {d.FullName}?",
                    "Удаление",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    docs.Remove(d);

                     db.SaveChanges();
                }

                
            }
        }
    }
}
