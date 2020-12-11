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

namespace lab1
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
            try
            {
                int operatrion = listBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;

                switch(operatrion)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("no operation selected");
                        break;
                }    
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("ERROR: dividing by zero not allowed");
            }
            catch(FormatException)
            {
                MessageBox.Show("ERROR: please input numerical values into left and right boxes");
            }
            

        }

    }
}
