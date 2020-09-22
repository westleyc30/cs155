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

namespace lecture4Lab
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double degreesC, degreesF;
            degreesC = double.Parse(celsiusTxtBox.Text);
            degreesF = (9 * degreesC / 5) + 32;
            fahrenheitTxtBox.Text = degreesF.ToString();

            if (degreesF >= 90)
            {
                tempCanvas.Background = Brushes.Red;
            }
            else if (degreesF >= 80 && degreesF < 90) {
                tempCanvas.Background = Brushes.Yellow;
            }
            else if (degreesF >= 65 && degreesF < 80)
            {
                tempCanvas.Background = Brushes.Green;
            }
            else
            {
                tempCanvas.Background = Brushes.Blue;
            }
        }
    }

}
