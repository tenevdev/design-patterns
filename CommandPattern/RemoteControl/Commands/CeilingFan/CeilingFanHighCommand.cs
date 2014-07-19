using CommandPattern.Base;
using CommandPattern.RemoteControl.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        public CeilingFan CeilingFan { get; set; }
        public Appliances.CeilingFan.Speed PreviousSpeed { get; set; }

        public CeilingFanHighCommand(CeilingFan fan)
        {
            this.CeilingFan = fan;
        }

        public void Execute()
        {
            this.PreviousSpeed = this.CeilingFan.FanSpeed;
            this.CeilingFan.FanSpeed = Appliances.CeilingFan.Speed.High;
        }

        public void Undo()
        {
            this.CeilingFan.FanSpeed = this.PreviousSpeed;
        }
    }
}
