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
        /// Command for number buttons
        /// </summary>
        DelegateCommand NumberButtonCommand
        {
            get;
        }

        /// <summary>
        /// Property changed event
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}
 