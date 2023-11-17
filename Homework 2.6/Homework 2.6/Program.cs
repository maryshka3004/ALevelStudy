using Homework_2._6;
using System;

class Program
{
    static void Main()
    {
        Computer co = new Computer("Apple iMac", 100);
        Microwave micro = new Microwave("LG Microwave", 200);
        Mixer mix = new Mixer("Turbo Mixer 3000", 50);

        Device[] dev = { co, micro, mix };

        foreach (var devace in dev)
        {
            devace.PlugIn();
        }

        Console.WriteLine("Sorting devices by increasing voltage consumption using the Icomparer interface");

        Array.Sort(dev, new DeviceComparer());

        foreach (Device de in dev)
        {
            Console.WriteLine($"{de.DeviceName} - {de.Consumption}");
        }
        Console.WriteLine("Calculating of power consamption");

        double foolConsumption = dev.Sum(a => a.Consumption);
        Console.WriteLine($"Fool consumption is: {foolConsumption} WT");

        Console.WriteLine("Find a device in range from 60 to 120");
        int minWT = 60;
        int maxWT = 120;
        var deviceInRange = dev.Where(a => a.Consumption >= minWT && a.Consumption <= maxWT);

        Console.WriteLine($"Devices in the range from {minWT} to {maxWT} WT:");
        foreach (var d in deviceInRange)
        {
            Console.WriteLine($"{d.DeviceName} - {d.Consumption} WT");
        }
    }
}