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

namespace WpfApp44444444444444444444444444444444
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtF_KeyUp(object sender, KeyEventArgs e)
        {
            double celsius;
            double output;
            if (double.TryParse(txtF.Text, out output))
            {
                celsius = (output - 32) * 5 / 9;
                txtC.Text = celsius.ToString();
            }
        }

        private void txtC_KeyUp(object sender, KeyEventArgs e)
        {
            double Fahrenheit;
            double output;
            if (double.TryParse(txtC.Text, out output))
            {
                Fahrenheit = (output * 1.8) + 32;
                txtF.Text = Fahrenheit.ToString();
            }
        }

        private void bC_Click(object sender, RoutedEventArgs e)
        {
            txtC.Text = "";
            txtF.Text = "";
        }
    }
   

}
