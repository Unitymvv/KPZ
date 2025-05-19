using ClassLibrary_Task2.Devices.Interface;
using System;

namespace ClassLibrary_Task2.Devices
{
    public class NetbookBalaxy : IDevice
    {
        public void ShowInfo() => Console.WriteLine("Netbook from Balaxy");
    }
}
