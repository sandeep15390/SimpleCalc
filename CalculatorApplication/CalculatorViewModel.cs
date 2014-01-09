using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCalculatorApplication
{
    /// <summary>
    /// ViewModel for the calculator
    /// </summary>
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public CalculatorViewModel()
        {
            Result = "some random text";
        }

        /// <summary>
        /// property changed handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        /// <summary>
        /// Command for number buttons
        /// </summary>
        public ICommand NumberButtonCommand
        {
            get
            {
                return new DelegateCommand(NumberButtonCommandExecuted);
            }
        }

        private void NumberButtonCommandExecuted(object sender)
        {
            switch (int.Parse(sender.ToString()))
            {
                case 1:
                    Result = "1";
                    break;
                case 2:
                    Result = "2";
                    break;
                case 3:
                    Result = "3";
                    break;
                case 4:
                    Result = "4";
                    break;
                case 5:
                    Result = "5";
                    break;
                case 6:
                    Result = "6";
                    break;
                case 7:
                    Result = "7";
                    break;
                case 8:
                    Result = "8";
                    break;
                case 9:
                    Result = "9";
                    break;
                case 0:
                    Result = "0";
                    break;
            }
        }

        /// <summary>
        /// Result string property
        /// </summary>
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        private string _result;
    }
}
