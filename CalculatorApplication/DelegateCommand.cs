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
        public DelegateCommand(Action<object> actionToExecute)
        {
            _actionToExecuteWithOneParameter = actionToExecute;
        }
        
        /// <summary>
        /// DelegateCommand constructor 
        /// </summary>
        /// <param name="executeMethod"></param>
        public DelegateCommand(Action actionToExecute)
        {
            _actionToExecuteNoParameters = actionToExecute;
        }

        private Action<object> _actionToExecuteWithOneParameter;
        private Action _actionToExecuteNoParameters;

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
            if (parameter == null)
            {
                _actionToExecuteNoParameters.Invoke();
            }
            else
            {
                _actionToExecuteWithOneParameter.Invoke(parameter);
            }
        }
    }
}