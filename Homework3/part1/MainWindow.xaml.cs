/// Homework3
/// File Name: Part1 
/// @author: Westley Cho
/// Date:  September 21, 2020
///
/// Problem Statement: Write a GUI program that reads in the amount of a monthly mortgage payment and the outstanding balance (i.e., the amount still owed) 
/// and then outputs the amount of the payment that goes to interest and the amount that goes to principal (i.e., the amount that goes to reducing the debt). 
/// Assume that the annual interest payment is 6.39 percent. Use a defined constant for the interest rate. 
/// Note that payments are made monthly, so the interest is only one-twelfth of the annual interest rate of 6.39 percent.
/// 
/// 
/// Overall Plan:
/// 1) Take in amount owed
/// 2) take in payment
/// 3) Split payment into principal and payment towards loan
/// 

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
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Double mortgage, interestRate, payment, toPrincipal, toMortgage;
            mortgage = double.Parse(mortgageTxtBox.Text);
            interestRate = ((double.Parse(interestRateTxtBox.Text)) / 100) / 12;
            payment = double.Parse(paymentTxtBox.Text);
            toPrincipal = payment - (mortgage * interestRate);
            toMortgage = payment - toPrincipal;

            toPrincipleTxtBox.Text = toPrincipal.ToString();
            toMortgageTxtBox.Text = toMortgage.ToString();
        }

    }
}
