using NotepadMementoPattern.Commands;
using NotepadMementoPattern.Entities;


namespace NotepadMementoPattern.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public Editor Editor { get; set; }
        private History _history;

        public SaveCommand SaveCommand { get; set; }
        public UndoCommand UndoCommand { get; set; }
        public CommandBase RedoCommand { get; set; }

        public MainViewModel()
        {
            Editor = new Editor();
            _history = new History(Editor);

            SaveCommand = new SaveCommand(_history);
            UndoCommand = new UndoCommand(_history);
            RedoCommand = new RedoCommand(_history);
        }
    }
}