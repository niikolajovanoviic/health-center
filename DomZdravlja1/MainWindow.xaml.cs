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

namespace DomZdravlja1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DomZdravljaDataContext DomZdravljaDC = new DomZdravljaDataContext();
        public MainWindow()
        {
            InitializeComponent();
            PuniCombo();
        }
        private void PuniCombo()
        {
            var rez = from f in DomZdravljaDC.Firmes
                      select f;
            comboBox.ItemsSource = rez;
        }
        private void puniDataGrid()
        {
            var rez = from p in DomZdravljaDC.Pacijentis
                      join pa in DomZdravljaDC.Paketis
                      on p.PaketID equals pa.PaketID
                      join f in DomZdravljaDC.Firmes
                      on pa.FirmaID equals f.FirmaID
                      where pa.FirmaID == ((Firme)comboBox.SelectedValue).FirmaID
                      select new
                      {
                          p.PacijentID,
                          p.Ime,
                          p.Prezime,
                          p.DatumIzmene,
                          pa.Naziv,
                          pa.Cena,
                          p.Popust
                      };
            dataGrid.ItemsSource = rez;
            textBlockUkupno.Text = rez.Count().ToString();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            puniDataGrid();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            groupBox.IsEnabled = true;
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Pacijenti rez = (from p in DomZdravljaDC.Pacijentis
                             where p.PacijentID == int.Parse(tbSifraPacijenta.Text)
                             select p).Single();
            rez.Popust = int.Parse(tbNoviPopust.Text);
            rez.DatumIzmene = System.DateTime.Now.Date;

            try
            {
                DomZdravljaDC.SubmitChanges();
                MessageBox.Show("Uspesno ste promenili popust!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}");
                throw;
            }
            puniDataGrid();
            tbNoviPopust.Text = string.Empty;
                            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Pacijenti rez = (from p in DomZdravljaDC.Pacijentis
                             where p.PacijentID == int.Parse(tbSifraPacijenta.Text)
                             select p).Single();
            DomZdravljaDC.Pacijentis.DeleteOnSubmit(rez);

            try
            {
                DomZdravljaDC.SubmitChanges();
                MessageBox.Show($"Uspesno ste obirsali pacijenta sa ID: {tbSifraPacijenta.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}");
                throw;
            }
            puniDataGrid();
        }

        private void radioMax_Checked(object sender, RoutedEventArgs e)
        {
            var max = (from p in DomZdravljaDC.Pacijentis
                       join pak in DomZdravljaDC.Paketis
                       on p.PaketID equals pak.PaketID
                       where pak.FirmaID == ((Firme)comboBox.SelectedValue).FirmaID
                       select p.Popust).Max();

            var korisnici = from p in DomZdravljaDC.Pacijentis
                      join pa in DomZdravljaDC.Paketis
                      on p.PaketID equals pa.PaketID
                      where pa.FirmaID == ((Firme)comboBox.SelectedItem).FirmaID && p.Popust == max
                      select new
                      {
                          p.PacijentID,
                          pa.Naziv,
                          p.Popust
                      };
            listBoxPopust.ItemsSource = korisnici;
                      
        }

        private void radioMin_Checked(object sender, RoutedEventArgs e)
        {
            var min = (from p in DomZdravljaDC.Pacijentis
                       join pak in DomZdravljaDC.Paketis
                       on p.PaketID equals pak.PaketID
                       where pak.FirmaID == ((Firme)comboBox.SelectedValue).FirmaID
                       select p.Popust).Min();

            var korisnici = from p in DomZdravljaDC.Pacijentis
                            join pa in DomZdravljaDC.Paketis
                            on p.PaketID equals pa.PaketID
                            where pa.FirmaID == ((Firme)comboBox.SelectedItem).FirmaID && p.Popust == min
                            select new
                            {
                                p.PacijentID,
                                pa.Naziv,
                                p.Popust
                            };
            listBoxPopust.ItemsSource = korisnici;
        }

        private void meniUnos_Click(object sender, RoutedEventArgs e)
        {
            WindowUnos windowUnos = new WindowUnos();
            windowUnos.Show();
        }
    }
}
