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

namespace Lab4SpeedLimit
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
            double currentSpeed, speedLimit, speedDifference;
            
            currentSpeed = Double.Parse(speedTxtBox.Text);
            speedLimit = Double.Parse(speedLimitTxtBox.Text);

            speedDifference = currentSpeed - speedLimit;

            if(speedDifference >= 10)
            {
                speedCanvas.Background = Brushes.Red;
                checkTxtBlock.Text = speedDifference.ToString() + " over the speed limit. Too Fast! You get a ticket";
            } else if (speedDifference < 10 && speedDifference > 0)
            {
                speedCanvas.Background = Brushes.Yellow;
                checkTxtBlock.Text = speedDifference.ToString() + " over the speed limit. You might want to slow down a bit.";
            } else
            {
                speedCanvas.Background = Brushes.Green;
                checkTxtBlock.Text = "You're within the legal speed limit. Keep it up.";
            }


        }
    }
}
