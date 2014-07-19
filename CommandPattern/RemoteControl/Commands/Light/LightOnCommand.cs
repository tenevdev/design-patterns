using CommandPattern.Base;
using CommandPattern.RemoteControl.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class LightOnCommand : ICommand
    {
        public Light Light { get; set; }

        public LightOnCommand(Light light)
        {
            this.Light = light;
        }

        public void Execute()
        {
            this.Light.On();
        }

        public void Undo()
        {
            this.Light.Off();
        }
    }
}
