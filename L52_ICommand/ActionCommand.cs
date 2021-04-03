using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace L52_ICommand
{
    class ActionCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<T> executeMethod;
        Func<T, bool> canExecute;

        public ActionCommand(Func<T, bool> canExecute, Action<T> executeMethod)
        {
            this.executeMethod = executeMethod;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            this.executeMethod((T)parameter);
        }
    }
}
