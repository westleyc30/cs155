
/// lab week 3
/// File Name: Part1 
/// @author: Westley Cho
/// Date:  September 20, 2020
///
/// Problem Statement: Write a program that start with the string variable
/// first set to your first name and the string variable last set to your
/// last name. Both names should be all lowercase. Your program should then
/// create a new string that contains your full name in pig latin with the
/// first letter capitalized for the first and last name.  Use only the pig
/// latin rule of moving the first letter to the end of the word and adding
/// “ay”. Output the pig latin name to the screen. Use Substring and
/// ToUpper methods to construct the new name.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user for first name
/// 2) Prompt user for last name
/// 3) Convert name to pig latin
/// 4) Print name in pig latin to screen
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
            String pigLatinFirstName; // to output
            String pigLatinLastName; // to output
            String firstName = firstNameBox.Text;
            String lastName = lastNameBox.Text;
            String fullName;

            pigLatinFirstName = capitalizeWord(toPigLatin(firstName));
            pigLatinLastName = capitalizeWord(toPigLatin(lastName));

            fullName = pigLatinFirstName + " " + pigLatinLastName;



            MessageBox.Show(fullName);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        static String capitalizeWord(String word)
        {
            String capitalizedWord;
            capitalizedWord = word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
            return capitalizedWord;
        }
        static String toPigLatin(String word)
        {
            String pigLatinizedWord;
            pigLatinizedWord = word.Substring(1, word.Length - 1) + word.Substring(0, 1).ToLower() + "ay";
            return pigLatinizedWord;
        }
    }
}
