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
using WpfCalculatorApplication;

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
            _viewModel = new CalculatorViewModel();
            DataContext = _viewModel;
            PlusOrMinusButton.Content = "\u00B1";
            SquareRootButton.Content = "\u221a";
            BackButton.Content = "<-";
        }

        private CalculatorViewModel _viewModel;


        private void PreviewTextInputHandler(object sender, TextCompositionEventArgs e)
        {
            _viewModel.KeyButtonPressedCommand.Execute(e.Text);
        }
    }
}
