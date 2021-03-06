﻿using System;
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
            CalcRibbon = string.Empty;
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

        private void ConcatToResult(string concatString)
        {
            if (Result == "0")
            {
                Result = concatString;
            }
            else
            {
                if(_isAfterCalculation)
                {
                    Result = concatString;
                }
                else
                {
                    Result = Result + concatString;
                }
                _isAfterCalculation = false;
            }
        }

        private bool _isAfterCalculation;

        /// <summary>
        /// Command for number buttons
        /// </summary>
        public DelegateCommand KeyButtonPressedCommand
        {
            get
            {
                return new DelegateCommand(KeyButtonPressed);
            }
        }

        private void KeyButtonPressed(object sender)
        {
            switch (sender.ToString())
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    ConcatToResult(sender.ToString());
                    break;
                case "+":
                case "-":
                case "/":
                case "*":
                    PushAndConcat(sender.ToString());
                    break;
                case "=":
                    CalcRibbon = CalcRibbon + Result;
                    Result = EvaluateExpression(CalcRibbon);
                    CalcRibbon = string.Empty;
                    break;
            }
        }

        private void PushAndConcat(string symbol)
        {
            CalcRibbon = CalcRibbon + Result;
            Result = EvaluateExpression(CalcRibbon);
            CalcRibbon = CalcRibbon + symbol;
            _isAfterCalculation = true;
        }

        public DelegateCommand ClearButtonCommand
        {
            get
            {
                return new DelegateCommand(ClearButtonCommandExecuted);
            }
        }

        private void ClearButtonCommandExecuted()
        {
            Result = "0";
            CalcRibbon = string.Empty;
        }

        /// <summary>
        /// Command for clear entry button
        /// </summary>
        public DelegateCommand ClearEntryButtonCommand
        {
            get
            {
                return new DelegateCommand(ClearEntryButtonCommandExecuted);
            }
        }

        private void ClearEntryButtonCommandExecuted()
        {
            Result = "0";
        }

        /// <summary>
        /// Command for Back Button
        /// </summary>
        public DelegateCommand BackButtonCommand
        {
            get
            {
                return new DelegateCommand(BackButtonCommandExecuted);
            }
        }

        private void BackButtonCommandExecuted()
        {
            if (!_isAfterCalculation)
            {
                Result = RemoveLastCharacterInString(Result);
            }
        }

        private string RemoveLastCharacterInString(string stringToRemove)
        {
            if (stringToRemove.Length > 1)
            {
                var removedString = stringToRemove.Remove(stringToRemove.Length - 1, 1);
                return removedString;
            }
            else
            {
                return "0";
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

        /// <summary>
        /// keeps track of calculations
        /// </summary>
        public string CalcRibbon
        {
            get
            {
                return _calcRibbon;
            }
            set
            {
                _calcRibbon = value;
                OnPropertyChanged("CalcRibbon");
            }
        }

        private string _calcRibbon;

        /// <summary>
        /// Evaluates the math expression
        /// </summary>
        /// <param name="expression"></param>
        public string EvaluateExpression(string expression)
        {
            Expression e = new Expression(expression);
            return e.Evaluate().ToString();
        }
    }
}
