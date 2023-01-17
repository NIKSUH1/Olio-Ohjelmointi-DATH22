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

namespace harjoitus15___wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int kuormaAutot = 0;
        private int henkilöAutot = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_KuormaAutot_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot = kuormaAutot + 1;
            txt_KuormaAutotMäärä.Text = Convert.ToString(kuormaAutot);
        }

        private void btn_HenkilöAutot_Click(object sender, RoutedEventArgs e)
        {
            henkilöAutot = henkilöAutot +1;
            txt_HenkilöAutotMäärä.Text = Convert.ToString(henkilöAutot);
            
        }
    }
}
