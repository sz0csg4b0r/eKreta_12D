using System.Windows;
using System.Windows.Input;

namespace eKreta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void diakMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tanarMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void osztalyMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void termekMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void felhasznalokMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void bezarasMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}