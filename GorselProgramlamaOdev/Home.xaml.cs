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
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            List<Bilgi> liste = new List<Bilgi>()
            {
                new Bilgi() {Ad="Şahin", Soyad="Bölükbaşı", OgrenciNo=181130079, Bolum="Bilgisayar Programcılığı"}
            };

            bilgi.ItemsSource = liste;
        }

       

        public class Bilgi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int OgrenciNo { get; set; }
            public string Bolum { get; set; }

        }

        private void Giris_Click(object sender, RoutedEventArgs e)
        {
            AddPage addpages = new AddPage();
            addpages.Show();
            this.Hide();
        }
    }
}
