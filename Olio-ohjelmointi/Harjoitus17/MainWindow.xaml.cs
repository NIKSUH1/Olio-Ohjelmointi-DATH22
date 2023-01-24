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

namespace Harjoitus17
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

        private void btn_KeittiönValo_Click(object sender, RoutedEventArgs e)
        {
            if (txt_KeittiöV.Text == "Keittiön valo ei ole päällä")
            {
                txt_KeittiöV.Text = "Keittiön valo on päällä";
            }
            else
            {
                txt_KeittiöV.Text = "Keittiön valo ei ole päällä";
            }
        }

        private void btn_OlohuoneenValo_Click(object sender, RoutedEventArgs e)
        {
            if (txt_OlohuoneenV.Text == "Olohuoneen valo ei ole päällä")
            {
                txt_OlohuoneenV.Text = "Olohuoneen valo on päällä";
            }
            else
            {
                txt_OlohuoneenV.Text = "Olohuoneen valo ei ole päällä";
            }
        }

        private void btn_Ovi_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Ovi.Text == "Ovi on auki")
            {
                txt_Ovi.Text = "Ovi on kiinni";
            }
            else
            {
                txt_Ovi.Text = "Ovi on auki";
            }
        }

        private void sld_Lämpötila_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt_lämpötilaTeksti.Text = "Lämpötila: " + sld_Lämpötila.Value;
        }
    }
}
