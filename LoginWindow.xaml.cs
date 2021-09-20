using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookStore
{
    /// <summary>
    /// LoginWindow.xaml etkileşim mantığı
    /// </summary>
 

    public partial class LoginWindow : Window
    {
        private string username = "admin";
        private string password = "admin123";
        public LoginWindow()
        {
            InitializeComponent();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Equals(username) && PasswordTextBox.Password.Equals(password))
            {

                SelectBookWindow selectwindow = new SelectBookWindow();
                this.Visibility = Visibility.Hidden;
                selectwindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password\n\tLogin failed!");
            }
        }
    }
}
