using eKreta.Models;
using eKreta.Services;
using System.Windows;

namespace eKreta.Views
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string userName = loginUserText.Text;
            string passwordHash = PasswordHelper.HashPassword(loginPasswordText.Password);

            if (!string.IsNullOrEmpty(loginUserText.Text) || !string.IsNullOrEmpty(loginPasswordText.Password))
            {
                using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasePath))
                {
                    var user = connection.Table<Felhasznalo>().FirstOrDefault(u => u.FelhasznaloNev == userName);

                    //Ha van ilyen felhasználó
                    if (user != null)
                    {
                        // jelszóellenőrzés
                        if (user.Jelszo == passwordHash)
                        {
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Belépés megtagadva! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belépés megtagadva! ");
                    }
                }
            }
        }
    }
}
