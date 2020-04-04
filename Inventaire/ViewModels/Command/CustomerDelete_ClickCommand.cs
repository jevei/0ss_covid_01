using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BillingManagement.UI.ViewModels.Command
{
    public class CustomerDelete_ClickCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;
        public CustomerDelete_ClickCommand(Action execute)
        {
            _execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
