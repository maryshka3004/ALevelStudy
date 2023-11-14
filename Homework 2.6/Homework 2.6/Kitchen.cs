using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_2._6
{
    internal class Kitchen : Device
    {
        public bool PluggedIn { get; private set; }

        protected Kitchen(string deviceName, int consumption) : base(deviceName, consumption)
        {
            PluggedIn = false;
        }

        public override void PlugIn()
        {
            PluggedIn = true;
            Console.WriteLine($"{DeviceName} is plugged in.");
        }
    }
}
