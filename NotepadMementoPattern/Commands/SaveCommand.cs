using NotepadMementoPattern.Entities;

namespace NotepadMementoPattern.Commands
{
    public class SaveCommand:CommandBase
    {
        public SaveCommand(History history) : base(history)
        {
        }

        public override void Execute(object parameter)
        {
            _history.Backup();   
        }
    }
}