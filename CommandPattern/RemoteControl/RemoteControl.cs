using CommandPattern.Base;
using CommandPattern.RemoteControl.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl
{
    public class RemoteControl
    {
        public List<ICommand> OnCommands { get; set; }
        public List<ICommand> OffCommands { get; set; }
        public ICommand UndoCommand { get; set; }

        public RemoteControl()
        {
            this.OnCommands = new List<ICommand>();
            this.OffCommands = new List<ICommand>();
            this.UndoCommand = new NoCommand();
        }

        public void OnButtonPressed(int slot)
        {
            this.OnCommands.ElementAt(slot).Execute();
            this.UndoCommand = this.OnCommands.ElementAt(slot);
        }

        public void OffButtonPressed(int slot)
        {
            this.OffCommands.ElementAt(slot).Execute();
            this.UndoCommand = this.OffCommands.ElementAt(slot);
        }

        public void UndoButtonPressed()
        {
            this.UndoCommand.Undo();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.OnCommands.Insert(slot, onCommand);
            this.OffCommands.Insert(slot, offCommand);
        }
    }
}
