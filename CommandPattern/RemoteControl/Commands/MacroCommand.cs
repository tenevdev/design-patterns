using CommandPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class MacroCommand : ICommand
    {
        public List<ICommand> Commands { get; set; }

        public MacroCommand(List<ICommand> commands)
        {
            this.Commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in this.Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand command in this.Commands)
            {
                command.Undo();
            }
        }
    }
}
