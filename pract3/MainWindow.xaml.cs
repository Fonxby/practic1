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

namespace pract3
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
            double A = double.Parse(texta.Text);
            double B = double.Parse(textb.Text);
            if (A!=0)
            {
                double x = -B / A;
                textx.Text = ($"{x}");
            }
            else { textx.Text = ($"A равен 0"); }
        }
    }
}
