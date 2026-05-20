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
            // Módosító mezők default állapota:
            szerepkor.SelectedItem = Enum.GetName(typeof(Szerepkorok), Szerepkorok.Vendég);
            teljesNevTxtBx.Text = "";
            felhasznaloNevTxtBx.Text = "";
            jelszoBx.Password = "";

            // Adat lekérés adatbázisból, adatok átadása datagridnek:
            var FelhasznaloRepository = new GenericRepository<Felhasznalo>(App.databasePath);
            var FelhasznaloLekerdezes = FelhasznaloRepository.GetAll();
            datagridFelhasznalok.ItemsSource = FelhasznaloLekerdezes;


        }

        private void datagridFelhasznalok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            modBth.Visibility = Visibility.Visible;
            torlesBtn.Visibility = Visibility.Visible;
            mentesBtn.Visibility = Visibility.Hidden;

            if (datagridFelhasznalok.SelectedItem != null)
            {
                valasztottFelhasznalo = (Felhasznalo)datagridFelhasznalok.SelectedItem;
                felhasznaloNevTxtBx.Text = valasztottFelhasznalo.FelhasznaloNev;
                teljesNevTxtBx.Text = valasztottFelhasznalo.TeljesNev;
                szerepkor.Text = valasztottFelhasznalo.SzerepkorNev;
            }
        }

        private void torlesBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void modBth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mentesBtn_Click(object sender, RoutedEventArgs e)
        {
            //Szerepkör névből szerepkörID
            string kivalasztottSzerepkorNev = (string)szerepkor.SelectedItem;
            Szerepkorok kivalasztottSzerepkor = (Szerepkorok)Enum.Parse(typeof(Szerepkorok), kivalasztottSzerepkorNev);
            int kivalasztottSzerepkorId = (int)kivalasztottSzerepkor;

            // Uj felhasználó objektum létrehozás
            Felhasznalo ujFelhasznalo = new Felhasznalo(felhasznaloNevTxtBx.Text,
                teljesNevTxtBx.Text, jelszoBx.Password, kivalasztottSzerepkorId);

            // Uj user repo, insert to db
            var FelhasznaloRepository = new GenericRepository<Felhasznalo>(App.databasePath);
            FelhasznaloRepository.insert(ujFelhasznalo);

            //Datagrid update:
            ReadDatabase();

        }
    }
}
