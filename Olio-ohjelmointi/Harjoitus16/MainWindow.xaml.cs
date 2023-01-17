using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus16
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

        private void btn_Kilometreiksi_Click(object sender, RoutedEventArgs e)
        {
            input_pituus.Text = Convert.ToString(float.Parse(input_pituus.Text) / 1.609344);
        }

        private void btn_Maileiksi_Click(object sender, RoutedEventArgs e)
        {
            input_pituus.Text = Convert.ToString(float.Parse(input_pituus.Text) * 1.609344);
        }

        private void input_Muutettava_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
