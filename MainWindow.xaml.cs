using System.Windows;
using System.Windows.Input;
using ClaimManagementApp.Views;

namespace ClaimManagementApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new LoginPage();
        }

        private void NavLogin(object sender, MouseButtonEventArgs e) => MainContent.Content = new LoginPage();
        private void NavLecturer(object sender, MouseButtonEventArgs e) => MainContent.Content = new LecturerDashboard();
        private void NavCoordinator(object sender, MouseButtonEventArgs e) => MainContent.Content = new ProgrammeCoordinatorDashboard();
        private void NavManager(object sender, MouseButtonEventArgs e) => MainContent.Content = new AcademicManagerDashboard();
    }
}
