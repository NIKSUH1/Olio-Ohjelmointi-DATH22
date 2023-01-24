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

namespace Harjoitus18
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

        private void btn_Summa_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(input_Syöte1.Text);
            double b = Convert.ToInt32(input_Syöte2.Text);
            txt_Vastaus.Text = Convert.ToString(a + b);
        }

        private void btn_Erotus_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(input_Syöte1.Text);
            double b = Convert.ToInt32(input_Syöte2.Text);
            txt_Vastaus.Text = Convert.ToString(a - b);
        }

        private void btn_Jakolasku_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(input_Syöte1.Text);
            double b = Convert.ToInt32(input_Syöte2.Text);
            txt_Vastaus.Text = Convert.ToString(a / b);
        }

        private void btn_Kertolasku_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(input_Syöte1.Text);
            double b = Convert.ToInt32(input_Syöte2.Text);
            txt_Vastaus.Text = Convert.ToString(a * b);
        }
    }
}
