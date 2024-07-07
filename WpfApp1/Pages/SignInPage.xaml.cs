using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Pages
{
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("s");

        }
    }
}
