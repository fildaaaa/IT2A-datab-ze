using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace IT2A_databaze
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Auto> Auta { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Auta = new ObservableCollection<Auto>();
            dgAuta.ItemsSource = Auta;
        }

        private void Pridat_Click(object sender, RoutedEventArgs e)
        {
            Auta.Add(new Auto
            {
                ID = Auta.Count + 1,
                Znacka = "Škoda",
                Model = "Superb",
                RokVyroby = 2015,
                Barva = "Červená"
            });
        }

        private void Smazat_Click(object sender, RoutedEventArgs e)
        {
            if (dgAuta.SelectedItem is Auto vybraneAuto)
            {
                Auta.Remove(vybraneAuto);
            }
        }
    }
}