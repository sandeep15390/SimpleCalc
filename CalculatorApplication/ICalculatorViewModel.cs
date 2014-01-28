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
        /// Command for number buttons
        /// </summary>
        DelegateCommand NumberButtonCommand
        {
            get;
        }

        /// <summary>
        /// Command for math operation buttons
        /// </summary>
        DelegateCommand ArithematicButtonCommand
        {
            get;
        }

        /// <summary>
        /// Command for number buttons
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
        /// Property changed event
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}
 