using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrderBoard.Commands
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public DelegateCommand(Action<object?> executeHandler)
        {
            this.ExecuteHandler = executeHandler;
        }
        public DelegateCommand(Action<object?> executeHandler, Func<object?,bool> canExecuteHandler)
        {
            this.ExecuteHandler = executeHandler;
            this.CanExecuteHandler = canExecuteHandler;
        }

        public Func<object?, bool>? CanExecuteHandler { get; set; }
        public Action<object?> ExecuteHandler { get; set; }


        public bool CanExecute(object? parameter)
        {
            return CanExecuteHandler == null || CanExecuteHandler(parameter);
        }

        public void Execute(object? parameter)
        {
            ExecuteHandler?.Invoke(parameter);
        }
    }
}
