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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4c
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podroz twoja_podroz;
        public MainWindow()
        {
            InitializeComponent();
            menuGrid.Visibility = Visibility.Hidden;
        }

        private void zatwierzRodzaj_Click(object sender, RoutedEventArgs e)
        {
            if (rodzajCombo.SelectedIndex == 0)
            {
                twoja_podroz = new Podroz();
                zatwierzRodzaj.IsEnabled = false;
                rodzajCombo.IsEnabled = false;
                menuGrid.Visibility = Visibility.Visible;
            }
            if (rodzajCombo.SelectedIndex == 1)
            {
                twoja_podroz = new LastMinute();
                zatwierzRodzaj.IsEnabled = false;
                rodzajCombo.IsEnabled = false;
                menuGrid.Visibility = Visibility.Visible;
            }
        }

        private void AddStation_Click(object sender, RoutedEventArgs e)
        {
            if (nameStationBox.Text != "")
            {

                twoja_podroz.DodajStacje(nameStationBox.Text, oplataCheckBox.IsChecked.Value);
                StationList.Document.Blocks.Clear();
                StationList.AppendText(twoja_podroz.ToString());
            }
        }

        private void DeleteStation_Click(object sender, RoutedEventArgs e)
        {
            twoja_podroz.UsunStacje();
            StationList.Document.Blocks.Clear();
            StationList.AppendText(twoja_podroz.ToString());
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            twoja_podroz.ZapiszPodroz();
            MessageBox.Show("Zapisano do pliku");
        }

        private void ZarzadzPowrot_Click(object sender, RoutedEventArgs e)
        {
            twoja_podroz.Powrot();
            StationList.Document.Blocks.Clear();
            StationList.AppendText(twoja_podroz.ToString());

        }
    }
}
