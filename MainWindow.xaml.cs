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

namespace unite_2_problem_3
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

        private void btnClickForTime_Click(object sender, RoutedEventArgs e)
        {
            int CapitalTime;
            int.TryParse(txtInput.Text, out CapitalTime);
            int PST;
            int MST;
            int CST;
            int EST;
            int AST;
            int ST;
            PST = CapitalTime - 300;
           MST = CapitalTime - 200;
            CST = CapitalTime - 100;
            EST = CapitalTime;
            AST = CapitalTime + 100;
            ST = CapitalTime + 150;
            PacificTime.Content = PST + "PST";
            MountainTime.Content = MST + " MST";
            CentralTime.Content = CST + " CST";
            EasternTime.Content = EST + " EST";
            AtlanticTime.Content = AST + " AST";
            NewfyTime.Content = ST + " ST";
            
        }
    }
}
