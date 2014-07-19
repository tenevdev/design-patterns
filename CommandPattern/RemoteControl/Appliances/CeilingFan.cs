using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Appliances
{
    public class CeilingFan
    {
        public enum Speed 
        {
            Off = 0,
            Low = 1,
            Medium = 2,
            High = 3
        }

        public Speed FanSpeed { get; set; }

        public CeilingFan()
        {
            this.FanSpeed = Speed.Off;
        }
    }
}
