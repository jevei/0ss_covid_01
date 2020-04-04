using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BillingManagement.UI.ViewModels.Command
{
    public class CustomerNew_ClickCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;
        public CustomerNew_ClickCommand(Action execute)
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
