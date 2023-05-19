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

namespace pract4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void otvet_Click(object sender, RoutedEventArgs e)
        {
            double b = double.Parse(textb.Text);
            double p = double.Parse(textp.Text);
            double a = Math.Cos(b) + 5.1 * Math.Pow(10, -3);
            texta.Text = ($"{a}");
            double w = (Math.Pow(a, 5) + Math.Sin(a) * b) / (Math.Sqrt(a * b) + Math.Tan(b));
            textw.Text = ($"{w}");
            double v = Math.Pow(Math.E, a * w) + p;
            textv.Text = ($"{v}");
        }
    }
}
