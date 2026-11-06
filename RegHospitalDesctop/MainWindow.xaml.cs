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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegHospitalDesctop.Pages;


namespace RegHospitalDesctop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  MainPage mainPage = new MainPage();

       
        public MainWindow()
        {
            InitializeComponent();
            // MainFrame.Navigate(mainPage);
            MainFrame.Navigate(new MainPage());

        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DoctorPage());
        }

        private void Patient_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PatientPage());
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RoomPage());
        }
    }
}