using System;
//Morghan Kiverago 3/27/2019
// Tshit Design
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

namespace Unit_2_project_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Ellipse e = new Ellipse();
                    e.Height = 100;
                    e.Width = 100;

                    if (x % 2 == 1 && y % 2 == 0 || x % 2 == 0 && y % 2 == 1)
                    {
                        e.Fill = Brushes.Red;
                    }
                    else
                    {
                        e.Fill = Brushes.Blue;
                    }
                    canvas.Children.Add(e);
                    Canvas.SetTop(e, x * 100);
                    Canvas.SetLeft(e, y * 100);
                }
            }
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Rectangle r = new Rectangle();
                    r.Height = 50;
                    r.Width = 50;

                    if (x % 2 == 1 && y % 2 == 0 || x % 2 == 0 && y % 2 == 1)
                    {
                        r.Fill = Brushes.Pink;
                    }
                    else
                    {
                        r.Fill = Brushes.Purple;
                    }
                    canvas.Children.Add(r);
                    Canvas.SetTop(r, x * 100);
                    Canvas.SetLeft(r, y * 100);

                }
            }


        }
        }
    }

