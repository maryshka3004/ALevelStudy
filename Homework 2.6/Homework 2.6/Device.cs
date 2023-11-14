using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._6
{

    class DeviceComparer : IComparer<Device>
    {
        public int Compare(Device? d1, Device? d2)
        {
            if (d1 is null || d2 is null)
                throw new ArgumentException("Incorrect");
            return d1.Consumption - d2.Consumption;
        }
    }
    public abstract class Device
    {
        public string DeviceName { get; set; }
        public int Consumption { get; set; }
        public Device (string deviceName, int consumption)
        {

            DeviceName = deviceName;
            Consumption = consumption;
        }
        public abstract void PlugIn();
    }
}
