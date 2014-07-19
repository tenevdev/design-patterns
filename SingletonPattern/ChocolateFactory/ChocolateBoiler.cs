using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ChocolateFactory
{
    public sealed class ChocolateBoiler
    {
        private static readonly ChocolateBoiler _instance = new ChocolateBoiler();
        public static ChocolateBoiler Instance 
        {
            get 
            {
                return ChocolateBoiler._instance;
            }
        }

        private ChocolateBoiler()
        {
        }
    }
}
