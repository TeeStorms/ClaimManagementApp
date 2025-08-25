using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;                         // Import WPF namespaces for controls and mouse events

namespace ClaimManagementApp.Views
{
    public partial class ProgrammeCoordinatorDashboard : UserControl
    {                                                                           // Code-behind for ProgrammeCoordinatorDashboard.xaml
                                                                                // Handles navigation and prototype claim actions
        public ProgrammeCoordinatorDashboard()
        {
            // Constructor initializes the dashboard and connects XAML elements
            InitializeComponent();
        }

        // Navigate to Lecturer Dashboard when clicked
        private void GoToLecturer(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LecturerDashboard();
        }

        // Navigate to Academic Manager Dashboard when clicked
        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new AcademicManagerDashboard();
        }

        // Navigate to Login page when Logout is clicked
        private void GoToLogin(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LoginPage();
        }

        // Approve selected claim (Phase 1 prototype only)
        // Shows a confirmation MessageBox
        private void ApproveSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsCoordinator?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"✅ Approved {label}");
        }

        // Decline selected claim (Phase 1 prototype only)
        // Shows a confirmation MessageBox
        private void DeclineSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsCoordinator?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"❌ Declined {label}");
        }
    }
}
