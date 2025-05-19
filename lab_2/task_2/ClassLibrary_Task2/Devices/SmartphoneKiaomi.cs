using ClassLibrary_Task2.Devices.Interface;
using System;

namespace ClassLibrary_Task2.Devices
{
    public class SmartphoneKiaomi : IDevice
    {
        public void ShowInfo() => Console.WriteLine("Smartphone from Kiaomi");
    }
}
