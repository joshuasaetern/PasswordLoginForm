using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture3Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Joshua Saetern
    /// 04.13.2024
    /// Lecture 3 - S24 - Notes - Rich Text Box
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Create string variables to store first and last name
                String firstName = txtBoxFirstName.Text;
                String lastName = txtBoxLastName.Text;
                String address = runAddress.Text;

                //Concatenate into full name
                String fullName = $"{firstName} {lastName}";

                //Display to our richTextBox
                runNameDisplay.Text = fullName;
                runAddressDisplay.Text = address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBoxInfo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBoxLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void richTxtBoxAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}