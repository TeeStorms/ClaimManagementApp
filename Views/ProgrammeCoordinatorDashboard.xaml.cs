using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClaimManagementApp.Views
{
    public partial class ProgrammeCoordinatorDashboard : UserControl
    {
        public ProgrammeCoordinatorDashboard()
        {
            InitializeComponent();
        }

        // Navigate to Lecturer dashboard
        private void GoToLecturer(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LecturerDashboard();
        }

        // Navigate to Academic Manager dashboard
        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new AcademicManagerDashboard();
        }

        // Navigate to Login
        private void GoToLogin(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LoginPage();
        }

        // Prototype: Approve selected claim (no real data updates)
        private void ApproveSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsCoordinator?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"✅ Approved {label}");
        }

        // Prototype: Decline selected claim (no feedback field in Phase 1)
        private void DeclineSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsCoordinator?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"❌ Declined {label}");
        }
    }
}
