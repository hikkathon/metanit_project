using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace metanit_wpf_mvvm.Commands
{
    class RelayCommand : ICommand
    {
        private Action<object> execute; // собственно выполняет логику команды
        private Func<object, bool> canExecute; // определяет, может ли команда выполняться

        public event EventHandler CanExecuteChanged // вызывается при изменении условий
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
