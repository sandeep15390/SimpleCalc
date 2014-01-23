using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NCalc;

namespace WpfCalculatorApplication
{
    /// <summary>
    /// ViewModel for the calculator
    /// </summary>
    public class CalculatorViewModel : ICalculatorViewModel, INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CalculatorViewModel()
        {
            Result = "0";
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
        public DelegateCommand NumberButtonCommand
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
                    ConcatToResult("1");
                    break;
                case 2:
                    ConcatToResult("2");
                    break;
                case 3:
                    ConcatToResult("3");
                    break;
                case 4:
                    ConcatToResult("4");
                    break;
                case 5:
                    ConcatToResult("5");
                    break;
                case 6:
                    ConcatToResult("6");
                    break;
                case 7:
                    ConcatToResult("7");
                    break;
                case 8:
                    ConcatToResult("8");
                    break;
                case 9:
                    ConcatToResult("9");
                    break;
                case 0:
                    ConcatToResult("0");
                    break;
            }
        }

        private void ConcatToResult(string concatString)
        {
            if (Result == "0")
                Result = concatString;
            else
                Result = Result + concatString;
        }

        /// <summary>
        /// Command for number buttons
        /// </summary>
        public DelegateCommand ArithematicButtonCommand
        {
            get
            {
                return new DelegateCommand(ArithematicButtonCommandExecuted);
            }
        }

        private void ArithematicButtonCommandExecuted(object sender)
        {
            switch (sender.ToString())
            {
                case "+":
                    Result = Result + "+";
                    break;
                case "-":
                    Result = Result + "-";
                    break;
                case "/":
                    Result = Result + "/";
                    break;
                case "*":
                    Result = Result + "*";
                    break;
                case "=":
                    Result = EvaluateExpression(Result);
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

        public string EvaluateExpression(string expression)
        {
            Expression e = new Expression(expression);
            return e.Evaluate().ToString();
        }
    }


}
