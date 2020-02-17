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

namespace Wpf5Frasi
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
        string[] a = new string[5];
        int c = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a(c) = TxtFrasi.Text;
            c++;
            BtnInserisci.IsEnabled = true;
            TxtFrasi.Clear();
            TxtFrasi.Focus();
            if (c >= 5)
            {
                BtnInserisci.IsEnabled = false;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (c = 0; c < a.Length; c++)
            {
                LblStringa.Content += $"Posizione {c} : {a[c]} \n";
            }
        }
    }
}
