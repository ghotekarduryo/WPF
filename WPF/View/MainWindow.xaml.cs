using System.Windows;
using WPF.View;

namespace WPF
{   public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "Lucky")
            {
                if(txtPassword.Text == "amikom")
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kata Sandi Tidak Cocok", "Peringatan!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Akun Tidak Ditemukan", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
