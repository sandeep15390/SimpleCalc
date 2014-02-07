using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCalculatorApplication
{
    public interface ICalculatorViewModel
    {
        /// <summary>
        /// Result string property
        /// </summary>
        string Result 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// keeps track of calculations
        /// </summary>
        string CalcRibbon
        {
            get;
            set;
        }

        /// <summary>
        /// Command for any key or button press
        /// </summary>
        DelegateCommand KeyButtonPressedCommand
        {
            get;
        }

        /// <summary>
        /// Command for clear entry button
        /// </summary>
        DelegateCommand ClearEntryButtonCommand
        {
            get;
        }

        /// <summary>
        /// Command for number buttons
        /// </summary>
        DelegateCommand ClearButtonCommand
        {
            get;
        }

        /// <summary>
        /// Command for Back Button
        /// </summary>
        DelegateCommand BackButtonCommand
        {
            get;
        }

        /// <summary>
        /// Property changed event
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Evaluates the math expression
        /// </summary>
        /// <param name="expression">expresstion to be evaluated</param>
        string EvaluateExpression(string expression);
    }
}
 