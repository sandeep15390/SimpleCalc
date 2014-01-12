using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCalculatorApplication
{
    /// <summary>
    /// Implement DelegateCommand 
    /// </summary>
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> executeMethod)
        {
            _executeMethod = executeMethod;
        }

        private Action<object> _executeMethod;

        /// <summary>
        /// Returns if the comand can be executed 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Can Execute changed event
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Execute the action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _executeMethod.Invoke(parameter);
        }
    }
}