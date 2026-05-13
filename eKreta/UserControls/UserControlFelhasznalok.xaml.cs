using eKreta.Models;
using System.Windows;
using System.Windows.Controls;

namespace eKreta.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlFelhasznalok.xaml
    /// </summary>
    public partial class UserControlFelhasznalok : UserControl
    {
        List<Felhasznalo> felhasznalok;
        Felhasznalo valasztottFelhasznalo;
        
        public UserControlFelhasznalok()
        {
            InitializeComponent();
            felhasznalok = new List<Felhasznalo>();
            ReadDatabase();
            mentesBtn.Visibility = Visibility.Visible;
            modBth.Visibility = Visibility.Hidden;
            torlesBtn.Visibility = Visibility.Hidden;
            szerepkor.ItemsSource = Enum.GetNames(typeof(Szerepkorok));
        }

        private void ReadDatabase()
        {
            throw new NotImplementedException();
        }

        private void datagridFelhasznalok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void torlesBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void modBth_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
