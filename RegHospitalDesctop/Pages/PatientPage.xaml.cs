using Microsoft.EntityFrameworkCore;
using RegHospital;
using RegHospital.Objects;
using RegHospitalDesctop.Windows;
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


namespace RegHospitalDesctop.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        RegHospitalContext db = new RegHospitalContext();

        ObservableCollection<Patient> patients = new ObservableCollection<Patient>(); 

        public PatientPage()
        {
            InitializeComponent();

            db.Patients.Load(); // подгрузи в локальное хранилище 

            patients = db.Patients.Local.ToObservableCollection();

            tablePatient.ItemsSource = patients;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (tablePatient.SelectedItem is Patient p)
            {
                patients.Remove(p);
                db.SaveChanges();

            }
        }

        private void Dob_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient();
            AddPatientWindow pp = new AddPatientWindow();
            pp.DataContext = p;


            if (pp.ShowDialog() == true) // стоит код пока не закроем окно
            {
                patients.Add(p);

                db.SaveChanges();
            }

        }
        private void Patientlist(object sender, SelectionChangedEventArgs e)
        {
            if (tablePatient.SelectedItem is Patient p)
            {
                DataContext = p;

            }
        }
    }
}
