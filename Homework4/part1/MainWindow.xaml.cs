/**
 * Homework 4
 * File Name: Part1
 * @author: Westley Cho
 * Date: September 28, 2020
 * 
 * Problem Statement: Create a GUI where users can input a height in inches and a weight in pounds.
 * The program will then calculate their BMI and display a color based on whether they are in the 
 * healthy range or not. 
 * 
 * Overall Plan:
 * 1) establish layout with:
 *   - Canvas
 *   - Button
 *   - forms for weight and height
 * 2) variables for height, weight, BMI
 * 3) calculate BMI on button press
 * 4) Change color of canvas based on BMI
 * 
 */
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

namespace part1
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
            double weight, height, BMI;
            String BMI_String;
            weight = Double.Parse(weightTxtBox.Text);
            height = Double.Parse(heightTxtBox.Text);
            BMI = (weight * 720) / (height * height);

            BMI_String = Math.Round(BMI, 2).ToString();

            if (BMI > 26)
            {
                ctx.Background = Brushes.Yellow;
                BMITxtBlock.Text = $"BMI is {BMI_String}, above the healthy range";
            } else if (BMI <= 26 && BMI >= 15)
            {
                ctx.Background = Brushes.Green;
                BMITxtBlock.Text = $"BMI is {BMI_String}, within the healthy range";
            } else
            {
                ctx.Background = Brushes.Blue;
                BMITxtBlock.Text = $"BMI is {BMI_String}, below the healthy range";
            }
                 
        }
    }
}
