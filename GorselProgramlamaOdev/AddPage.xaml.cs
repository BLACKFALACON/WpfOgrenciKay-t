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

namespace GorselProgramlamaOdev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddPage : Window
    {
        List<ogrnciBilgi> oBilgi = new List<ogrnciBilgi>();
        public AddPage()
        {
            InitializeComponent();
            cmb.Items.Add("Kayıt Bulunamamıştır");

        }

        private int durum = 1;
        private string cinsiyet = "";
        public class ogrnciBilgi {
            public int OgrenciNo { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Cinsiyet { get; set; }
            public string Bolum { get; set; }

        }
        
        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {
            if (btnErkek.IsChecked == true)
            {
                cinsiyet = "Erkek";
            }
            else if (btnKadin.IsChecked == true)
            {
                cinsiyet = "Kadın";
            }


            if (txtOn.Text == "")
            {labelONUyari.Visibility = Visibility.Visible; }
            else if (txtAd.Text == "")
            { labelAdUyari.Visibility = Visibility.Visible; }
            else if (txtSoyad.Text == "")
            { labelSoyadUyari.Visibility = Visibility.Visible; }
            else if (cinsiyet == "")
            { labelCinsiyetUyari.Visibility = Visibility.Visible; }
            else if(cmbBolum.Text == "")
            { labelBolumUyari.Visibility = Visibility.Visible; }

            else
            {
                durum--;
                ogrnciBilgi ogrenci1 = new ogrnciBilgi();
                ogrenci1.OgrenciNo = Convert.ToInt32(txtOn.Text);
                ogrenci1.Ad = txtAd.Text;
                ogrenci1.Soyad = txtSoyad.Text;
                ogrenci1.Cinsiyet = cinsiyet;
                ogrenci1.Bolum = cmbBolum.Text;
                oBilgi.Add(ogrenci1);
                tablo.Items.Add(ogrenci1);
                cmb.Items.Add(txtOn.Text);
                labelBolumUyari.Visibility = Visibility.Hidden;
                labelAdUyari.Visibility = Visibility.Hidden;
                labelSoyadUyari.Visibility = Visibility.Hidden;
                labelONUyari.Visibility = Visibility.Hidden;
                labelCinsiyetUyari.Visibility = Visibility.Hidden;
                txtAd.Clear();
                txtOn.Clear();
                txtSoyad.Clear();
                cinsiyet = "";
                btnErkek.IsChecked = false;
                btnKadin.IsChecked = false;
               
                cmb.Items.RemoveAt(0);

            }
            
        }
       

  
        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb.Items.Count > durum)
            {
                int satir = cmb.SelectedIndex;
                MessageBox.Show("Öğrenci No: " + oBilgi[satir].OgrenciNo + "\n" +
                                "Ad: " + oBilgi[satir].Ad + "\n" +
                                "Soyad: " + oBilgi[satir].Soyad + "\n" +
                                "Cinsiyet: " + oBilgi[satir].Cinsiyet + "\n" +
                                "Bölüm Adı: " + oBilgi[satir].Bolum + "\n",
                                "Seçilen Satır: " + (satir + 1), MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

    
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            Home homes = new Home();
            homes.Show();
            this.Hide();
        }

     

 
    }
}
