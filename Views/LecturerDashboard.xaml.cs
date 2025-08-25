using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;   // Needed for OpenFileDialog

namespace ClaimManagementApp.Views
{
    public partial class LecturerDashboard : UserControl
    {
        public LecturerDashboard()
        {
            InitializeComponent();

            // Phase 1 prototype: static demo only
        }

        // Navigate to Programme Coordinator dashboard
        private void GoToCoordinator(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
        }

        // Navigate to Academic Manager dashboard
        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new AcademicManagerDashboard();
        }

        // Navigate to Login page
        private void GoToLogin(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new LoginPage();
        }

        // Lecturer submits a new claim (Phase 1: dummy form)
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Show a simple form as a MessageBox (Phase 1 only)
            MessageBox.Show("📄 Prototype form:\n\nTitle: ___________\nDetails: ___________\n\n✅ In Phase 2 this will be a real form.");
        }

        // Lecturer uploads a supporting document
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a document to upload";
            openFileDialog.Filter = "All files (*.*)|*.*"; // accept all for prototype

            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show($"📎 Prototype: Selected file:\n{openFileDialog.FileName}");
            }
        }
    }
}
