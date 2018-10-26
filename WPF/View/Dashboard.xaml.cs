using System.Windows;

namespace WPF.View
{
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
