using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ClaimManagementApp.Views
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string role = (cmbRole.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Password) || string.IsNullOrEmpty(role))
            {
                txtError.Text = "Please fill all fields!";
                return;
            }

            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
            {
                switch (role)
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

        private void GoToCoordinator(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new ProgrammeCoordinatorDashboard();
        }

        private void GoToManager(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainContent != null)
                mainWindow.MainContent.Content = new AcademicManagerDashboard();
        }

        private void txtLink_Loaded(object sender, RoutedEventArgs e)
        {
            var storyboard = (Storyboard)FindResource("LinkWiggleStoryboard");
            storyboard.Begin();
        }

        // User clicked on 'Forgot Password' link
        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Password recovery feature will be added later.", "Forgot Password");
        }

    }
}