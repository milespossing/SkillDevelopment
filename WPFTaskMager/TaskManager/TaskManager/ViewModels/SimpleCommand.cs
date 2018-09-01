using System;
using System.Windows.Input;

namespace TaskManager.ViewModels
{
    public delegate void BasicSubRoutine();
    
    public class SimpleCommand : ICommand
    {
        private BasicSubRoutine _basic;
        
        public SimpleCommand(BasicSubRoutine routine)
        {
            _basic = routine;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _basic.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}