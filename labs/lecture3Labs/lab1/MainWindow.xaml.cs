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
