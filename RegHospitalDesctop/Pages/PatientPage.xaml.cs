using Microsoft.EntityFrameworkCore;
using RegHospital;
using RegHospital.Objects;
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
    }
}
