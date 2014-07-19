using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Appliances
{
    public class Light
    {
        public Light(){ }

        public void On() 
        {
            Console.WriteLine("Light\'s on.");
        }
        public void Off() 
        {
            Console.WriteLine("Light\'s off.");
        }
    }
}
