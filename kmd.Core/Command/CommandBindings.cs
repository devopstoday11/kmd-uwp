﻿using kmd.Core.Hotkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace kmd.Core.Command
{
    public class CommandBindings
    {
        public CommandBindings(IEnumerable<CommandBinding> commands)
        {
            _underlyingCommands = commands ?? throw new ArgumentNullException(nameof(commands));
        }

        public ICommand this[Type type]
        {
            get
            {
                return OfType(type);
            }
        }

        public ICommand OfHotkey(Hotkey hotkey)
        {
            return _underlyingCommands.FirstOrDefault(x => x.Hotkey == hotkey)?.Command;
        }

        public ICommand OfName(string name)
        {
            return _underlyingCommands.FirstOrDefault(x => x.Name == name)?.Command;
        }

        public ICommand OfType(Type type)
        {
            return _underlyingCommands.FirstOrDefault(x => x.Command.GetType() == type)?.Command;
        }

        private IEnumerable<CommandBinding> _underlyingCommands;
    }
}