using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;             // Imported WPF namespaces for controls, events, and application features

namespace ClaimManagementApp.Views
{
    public partial class AcademicManagerDashboard : UserControl
    {                                                               // Code-behind for AcademicManagerDashboard.xaml
                                                                    // Handles user interactions and navigation events
        public AcademicManagerDashboard()               // Constructor initializes the dashboard and connects XAML elements
        {
            InitializeComponent();
        }

        // Navigate to Lecturer dashboard
        private void GoToLecturer(object sender, MouseButtonEventArgs e)
        {                                                                       // Navigate to Lecturer Dashboard when clicked
                                                                                // Updates MainWindow.MainContent to show LecturerDashboard
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LecturerDashboard();
        }

        // Navigate to Programme Coordinator dashboard when clicked
        private void GoToCoordinator(object sender, MouseButtonEventArgs e)
        {                                                                           
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
        }

        // Informs the user they are already on Manager dashboard
        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Already on Academic Manager Dashboard");
        }

        // Navigate to Login page when "Logout" is clicked 
        private void GoToLogin(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LoginPage();
        }

        // Approve the selected claim (Predifined before runtime)
        // Shows a MessageBox with confirmation
        private void ApproveSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsManager?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"✅ Approved {label}");
        }

        // Decline the selected claim (no real data update)
        // Shows a MessageBox with confirmation
        private void DeclineSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsManager?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"❌ Declined {label}");
        }
    }
}
