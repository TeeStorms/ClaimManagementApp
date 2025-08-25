using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;                      // Import WPF namespaces and OpenFileDialog functionality

namespace ClaimManagementApp.Views
{
    public partial class LecturerDashboard : UserControl        // Code-behind for LecturerDashboard.xaml
    {
        public LecturerDashboard()
        {                                                       
                                                                // Handles lecturer interactions, navigation, and prototype actions
            InitializeComponent();

            // Constructor initializes the dashboard and connects XAML elements
            // Phase 1 prototype uses predined content only
        }

        // Navigate to Programme Coordinator Dashboard when clicked
        private void GoToCoordinator(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
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

        // Submit a new claim (Phase 1 prototype only)
        // Displays a dummy form using a MessageBox
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Show a simple form as a MessageBox (Phase 1 only)
            MessageBox.Show("📄 Form:\n\nTitle: ___________\nDetails: ___________\n\n In Phase 2 this will be a real form.");
        }

        // Upload a supporting document (Phase 1 prototype)
        // Opens a file dialog and shows selected file path in a MessageBox
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a document to upload";
            openFileDialog.Filter = "All files (*.*)|*.*"; // accept all for prototype

            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show($"📎Selected file:\n{openFileDialog.FileName}");
            }
        }
    }
}
