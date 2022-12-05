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

namespace page1_WpfApp1
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
        //Обработка первой вкладки
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDollar = rateDollar * sumDollar;
            resSum1.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate2.Text);
            double sumEvro = Convert.ToDouble(sum2.Text);
            double resEvro = rateEvro * sumEvro;
            resSum2.Text = resEvro.ToString();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate3.Text);
            double sumGrivn = Convert.ToDouble(sum3.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSum3.Text = resGrivn.ToString();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate4.Text);
            double sumDram = Convert.ToDouble(sum4.Text);
            double resDram = rateDram * sumDram;
            resSum4.Text = resDram.ToString();
        }
        //Обработка второй вкладки
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            const double inch = 0.0254;            
            double sumInch = Convert.ToDouble(sum5.Text);
            double resInch = inch * sumInch;
            resSum5.Text = resInch.ToString();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const double ft = 0.3048;
            double sumFt = Convert.ToDouble(sum6.Text);
            double resFt = ft * sumFt;
            resSum6.Text = resFt.ToString();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            const double mi = 1609.34;
            double sumMi = Convert.ToDouble(sum7.Text);
            double resMi = mi * sumMi;
            resSum7.Text = resMi.ToString();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            const double vrst = 1066.8;
            double sumVrst = Convert.ToDouble(sum8.Text);
            double resVrst = vrst * sumVrst;
            resSum8.Text = resVrst.ToString();
        }
    }
}
