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

namespace DomZdravlja1
{
    /// <summary>
    /// Interaction logic for WindowUnos.xaml
    /// </summary>
    public partial class WindowUnos : Window
    {
        private static DomZdravljaDataContext DomZdravljaDC = new DomZdravljaDataContext();
        public WindowUnos()
        {
            InitializeComponent();
            PuniCombo();
        }
        private void PuniCombo()
        {
            var rez = (from f in DomZdravljaDC.Firmes
                      select f).ToList();
            cbFirma.ItemsSource = rez;
        }
        private void PuniPakete()
        {
            var rez = (from p in DomZdravljaDC.Paketis
                      where p.FirmaID == ((Firme)cbFirma.SelectedValue).FirmaID
                      select p).ToList();
            cbPaket.ItemsSource = rez;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (!(tbSifra.Text==string.Empty) && !(tbIme.Text == string.Empty) && !(tbPrezime.Text == string.Empty) && 
                !(cbFirma.SelectedIndex<0) && !(cbPaket.SelectedIndex<0) && !(tbSliderValue.Text==string.Empty))
            {
                Pacijenti nov = new Pacijenti
                {
                    PacijentID = int.Parse(tbSifra.Text),
                    Ime = tbIme.Text.ToString(),
                    Prezime = tbPrezime.Text.ToString(),
                    DatumIzmene = System.DateTime.Now.Date,
                    Popust = int.Parse(tbSliderValue.Text),
                    PaketID = ((Paketi)cbPaket.SelectedValue).PaketID
                };
                DomZdravljaDC.Pacijentis.InsertOnSubmit(nov);
                try
                {
                    DomZdravljaDC.SubmitChanges();
                    MessageBox.Show("Uspesno dodat u bazu!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska" + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja!");
            }
        }

        private void cbFirma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PuniPakete();
        }

        private void cbPaket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
