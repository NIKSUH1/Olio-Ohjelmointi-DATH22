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

namespace WPF_Lopputyö
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {

        List<Elokuva> elokuvat = new List<Elokuva>();
        

        public MainWindow()
        {
            InitializeComponent();
            elokuvat.Add(new Elokuva("Game of Thrones", 8, 2011, "Images/GOT.jpg"));
            elokuvat.Add(new Elokuva("Vikings", 6, 2016, "Images/Vikings.jpg"));
            elokuvat.Add(new Elokuva("Hunger Games 1", 0, 2014, "Images/HungerGames.jpg"));
            elokuvat.Add(new Elokuva("Peaky Blinders", 6, 2013, "Images/PB.jpg"));
            elokuvat.Add(new Elokuva("The Last of Us", 0, 2023, "Images/TLOU.jpg"));
            elokuvat.Add(new Elokuva("John Wick 2", 0, 2017, "Images/Jw2.jpg"));
        }


        // TextBoxit
        private void input_pidän1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_pidän1, img_Pidän1, text_Lisätietoa1);
        }

        private void input_Pidän2_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_Pidän2, img_Pidän2, text_Lisätietoa2);
        }
        private void input_Pidän3_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_Pidän3, img_Pidän3, text_Lisätietoa3);
        }
        private void input_Katsoa1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_Katsoa1, img_Katsoa1, text_Lisätietoa4);
        }
        private void input_Katsoa2_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_Katsoa2, img_Katsoa2, text_Lisätietoa5);
        }
        private void input_Katsoa3_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckTextToImage(input_Katsoa3, img_Katsoa3, text_Lisätietoa6);
        }





        //TextBoxsien tarkistus riipuen tekstitstä
        //Kuva muuttuu
        private void CheckTextToImage(TextBox tb, Image img, TextBlock txt)
        {
            foreach (var item in elokuvat)
            {
                if (tb.Text == item.Nimi)
                {
                    img.Source = new BitmapImage(new Uri(item.URIPath, UriKind.Relative));
                    txt.Text = item.Lisätiedot();
                    return;
                }
            }

            img.Source = new BitmapImage(new Uri("Images/QM.JPG", UriKind.Relative));
        }

    }
}
