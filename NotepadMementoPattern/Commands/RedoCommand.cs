﻿using NotepadMementoPattern.Entities;

namespace NotepadMementoPattern.Commands
{
    public class RedoCommand : CommandBase
    {
        public RedoCommand(History history) : base(history)
        {
        }

        public override bool CanExecute(object parameter) => _history.CanForward;

        public override void Execute(object parameter)
        {
            _history.Forward();
        }
    }
}