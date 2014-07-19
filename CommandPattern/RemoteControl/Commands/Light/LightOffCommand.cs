using CommandPattern.Base;
using CommandPattern.RemoteControl.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class LightOffCommand : ICommand
    {
        public Light Light { get; set; }

        public LightOffCommand(Light light)
        {
            this.Light = light;
        }

        public void Execute()
        {
            this.Light.Off();
        }

        public void Undo()
        {
            this.Light.On();
        }
    }
}
