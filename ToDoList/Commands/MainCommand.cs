using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoList.Commands
{
    public class MainCommand : ICommand//.net 7
    {
        public event EventHandler CanExecuteChanged;
        Action<object> action;
        public MainCommand(Action<object> action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => action?.Invoke(parameter);
    }
}
