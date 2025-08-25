using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClaimManagementApp.Views
{
    public partial class AcademicManagerDashboard : UserControl
    {
        public AcademicManagerDashboard()
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

        // Navigate to Programme Coordinator dashboard
        private void GoToCoordinator(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
        }

        // Already on Manager dashboard
        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Already on Academic Manager Dashboard");
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
            var selected = lstPendingClaimsManager?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"✅ Prototype: Approved {label}");
        }

        // Prototype: Decline selected claim (no feedback in Phase 1)
        private void DeclineSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstPendingClaimsManager?.SelectedItem as ListBoxItem;
            var label = selected?.Content?.ToString() ?? "(no claim selected)";
            MessageBox.Show($"❌ Prototype: Declined {label}");
        }
    }
}
