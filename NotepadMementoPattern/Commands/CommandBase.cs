using System;
using System.Windows.Input;
using NotepadMementoPattern.Entities;


namespace NotepadMementoPattern.Commands
{
    public abstract class CommandBase:ICommand
    {
        protected History _history;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value; }
        }

        protected CommandBase(History history)
        {
            _history = history;
        }

        public virtual bool CanExecute(object parameter) => true;
        public abstract void Execute(object parameter);
    }
}