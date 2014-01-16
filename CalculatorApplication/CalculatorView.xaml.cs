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

namespace CalculatorApplication
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : Window
    {
        public CalculatorView()
        {
            InitializeComponent();
            PlusOrMinusButton.Content = "\u00B1";
            SquareRootButton.Content = "\u221a";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = String.Concat(ResultTextBox.Text, "1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = String.Concat(ResultTextBox.Text, "2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = String.Concat(ResultTextBox.Text, "3");
        }
    }
}
