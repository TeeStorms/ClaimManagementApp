using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;           // Import WPF namespaces for controls, input events, and animations

namespace ClaimManagementApp.Views
{
    public partial class LoginPage : UserControl                    // Code-behind for LoginPage.xaml
                                                                    // Handles login validation, navigation, and animations

    {
        public LoginPage()
        {
            // Constructor initializes the login page and connects XAML elements
            InitializeComponent();
        }

        // Handle login button click
        // Validate username, password, and role
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string role = (cmbRole.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Password) || string.IsNullOrEmpty(role))
            {
                txtError.Text = "Please fill all fields!";                            // Display error message if fields are empty
                return;
            }

            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
            {
                switch (role)                       // Navigate to the appropriate dashboard based on selected role
                {
                    case "Lecturer":
                        mainWindow.MainContent.Content = new LecturerDashboard();
                        break;
                    case "Programme Coordinator":
                        mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
                        break;
                    case "Academic Manager":
                        mainWindow.MainContent.Content = new AcademicManagerDashboard();
                        break;
                }
            }
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

        // Start wiggle animation for the link when it loads
        private void txtLink_Loaded(object sender, RoutedEventArgs e)
        {
            var storyboard = (Storyboard)FindResource("LinkWiggleStoryboard");
            storyboard.Begin();
        }

        // Handle 'Forgot Password?' click
        // Display placeholder message for password recovery
        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Password recovery feature will be added later.", "Forgot Password");
        }

    }
}