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

namespace wpfapp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string käyttäjänNimi;

        // vähän niin kuin unityn start metodi
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_button_Click(object sender, RoutedEventArgs e)
        {
            käyttäjänNimi = input_Nimi.Text;
            txt_EkaTeksti.Text = "Nimesi on = " + käyttäjänNimi;
        }
    }
}
