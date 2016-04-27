using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace olioharjoitustyo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
         }
        public List<Merkinta> merkinnat = new List<Merkinta>();
            
        public async void saveButton_Click(object sender, RoutedEventArgs e)
        {
              merkinnat.Add(new Merkinta
              {
                  Tyyppi = Convert.ToString(tyyppiBox.SelectedValue),
                  Matka = Convert.ToDouble(matkaBox.Text),
                  Paiva = Convert.ToString(paivamaara.Date),
                  Kesto = Convert.ToDouble(kestoBox.Text),
                  Kuvaus = kuvausBox.Text
              });
            string p = "C:\\Users\\Issev\\Test\\filesers.txt";
            string paivakirja = string.Join(",", merkinnat);
            using (FileStream fs = new FileStream(p, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
                await Task.Run(() =>
                sw.WriteLineAsync(paivakirja));


        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(selaa));
        }
    }
}

        /*static public void Virhe()
        {
            MainPage.virheTeksti.Text = "Virheellinen harjoituksen kesto. Syota pienempi luku.";
        }*/
    

