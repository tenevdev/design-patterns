using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Appliances
{
    public class Stereo
    {
        public Stereo() { }

        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void setCD() 
        {
            Console.WriteLine("Stereo CD is set.");
        }

        public void setDVD()
        {
            Console.WriteLine("Stereo DVD is set.");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine("Stereo volume is set to " + volume.ToString());
        }
    }
}
