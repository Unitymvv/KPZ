using ClassLibrary_Task2.Devices.Interface;
using System;

namespace ClassLibrary_Task2.Devices
{
    public class LaptopKiaomi : IDevice
    {
        public void ShowInfo() => Console.WriteLine("Laptop from Kiaomi");
    }
}
