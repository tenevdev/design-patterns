using CommandPattern.Base;
using CommandPattern.RemoteControl.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class StereoOffCommand : ICommand
    {
        public Stereo Stereo { get; set; }

        public StereoOffCommand(Stereo stereo)
        {
            this.Stereo = stereo;
        }

        public void Execute()
        {
            this.Stereo.Off();
        }

        public void Undo()
        {
            this.Stereo.On();
        }
    }
}
