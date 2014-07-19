using CommandPattern.Base;
using CommandPattern.RemoteControl.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class StereoWithCDCommand : ICommand
    {
        public Stereo Stereo { get; set; }

        public StereoWithCDCommand(Stereo stereo)
        {
            this.Stereo = stereo;
        }
        public void Execute()
        {
            this.Stereo.On();
            this.Stereo.setCD();
            this.Stereo.setVolume(10);
        }

        public void Undo()
        {
            this.Stereo.Off();
        }
    }
}
