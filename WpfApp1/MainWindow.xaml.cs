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

namespace WpfApp1
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

        private void btnVich_Click(object sender, RoutedEventArgs e)
        {
            int p = Otv.SelectedIndex;
            double polzp1, polzp2, ndfl, otvet;
            polzp1 = Convert.ToDouble(txtOk.Text) * Convert.ToDouble(txtOd.Text)/Convert.ToDouble(txtRd.Text) + Convert.ToDouble(txtPrem.Text);
            Otvet.Text = Convert.ToString(polzp1);
            if (p == 0)
            {
                polzp2 = polzp1 * 1.2;
                ndfl = polzp2 * 0.13;
                otvet = polzp2 - ndfl;
                Otvet.Text = Convert.ToString(otvet);
            }
            if (p == 1)
            {
                polzp2 = polzp1 * 1.3;
                ndfl = polzp2 * 0.13;
                otvet = polzp2 - ndfl;
                Otvet.Text = Convert.ToString(otvet);
            }
            if (p == 2)
            {
                polzp2 = polzp1 * 1.4;
                ndfl = polzp2 * 0.13;
                otvet = polzp2 - ndfl;
                Otvet.Text = Convert.ToString(otvet);
            }
            if (p == 3)
            {
                polzp2 = polzp1 * 1.5;
                ndfl = polzp2 * 0.13;
                otvet = polzp2 - ndfl;
                Otvet.Text = Convert.ToString(otvet);
            }
        }

        private void Otv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
