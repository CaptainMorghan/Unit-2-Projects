using System;
//Morghan Kiverago 25/03/2019
// I speak TXTMSG
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

namespace Unit_2_project
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

        private void btnExplain_Click(object sender, RoutedEventArgs e)
        {



            if (txtInput.Text == "CU") //If statement to determine if true. if it is it opens a message box to display the translation
            {
                //CHANGE THIS
                MessageBox.Show("See you");
            }//Copy paste for each code/translation
            else if (txtInput.Text == ":-)")
            {
                MessageBox.Show("I'm Happy");
            }
            else if (txtInput.Text == ":-(")
            {
                MessageBox.Show("I'm sad");
            }
            else if (txtInput.Text == ";-)")
            {
                MessageBox.Show("wink");
            }
            else if (txtInput.Text == ":-P")
            {
                MessageBox.Show("stick out my toung");
            }
            else if (txtInput.Text == "(~.~)")
            {
                MessageBox.Show("sleepy");
            }
            else if (txtInput.Text == "TA")
            {
                MessageBox.Show("Totally Awsome");
            }
            else if (txtInput.Text == "CCC")
            {
                MessageBox.Show("Canadian Computing Competition");
            }
            else if (txtInput.Text == "CUZ")
            {
                MessageBox.Show("Because");
            }
            else if (txtInput.Text == "TY")
            {
                MessageBox.Show("Thank you");
            }
            else if (txtInput.Text == "YW")
            {
                MessageBox.Show("You're Welcome");
            }
            else if (txtInput.Text == "TTYL")
            {
                MessageBox.Show("Talk to you later");
            }
            if (txtInput.Text == "See you")  // now to make it work in reverse
            {
                
                MessageBox.Show("CU");
            }
            else if (txtInput.Text == "I'm happy")
            {
                MessageBox.Show(":-)");
            }
            else if (txtInput.Text == "I'm sad")
            {
                MessageBox.Show(":-(");
            }
            else if (txtInput.Text == "wink")
            {
                MessageBox.Show(";-)");
            }
            else if (txtInput.Text == "stick out my toung")
            {
                MessageBox.Show(":-P");
            }
            else if (txtInput.Text == "sleepy")
            {
                MessageBox.Show("(~.~)");
            }
            else if (txtInput.Text == "totally awsome")
            {
                MessageBox.Show("TA");
            }
            else if (txtInput.Text == "Canadian Computing Competition")
            {
                MessageBox.Show("CCC");
            }
            else if (txtInput.Text == "because")
            {
                MessageBox.Show("CUZ");
            }
            else if (txtInput.Text == "Thank you")
            {
                MessageBox.Show("TY");
            }
            else if (txtInput.Text == "You're Welcome")
            {
                MessageBox.Show("YW");
            }
            else if (txtInput.Text == "Talk to you later")
            {
                MessageBox.Show("TTYL");
            }








        }
    }
}

