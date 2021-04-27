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

namespace WpfApp
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
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            decimal operand1;
            decimal operand2;
            string operation = OperationSelect.Text;

            if (!Decimal.TryParse(OperandBox1.Text, out operand1)) operand1 = 0.0M;
            if (!Decimal.TryParse(OperandBox2.Text, out operand2)) operand2 = 0.0M;

            if(operation == "/" && operand2 == 0)
            {
                ResultLabel.Content = "NaN";
            }
            else
            {
                ResultLabel.Content = service.Calculate(operand1, operand2, operation);
            }
        }
    }
}
