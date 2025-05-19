using ClassLibrary_Task2.Devices.Interface;
using System;

namespace ClassLibrary_Task2.Devices
{
    public class SmartphoneIProne : IDevice
    {
        public void ShowInfo() => Console.WriteLine("Smartphone from IProne");
    }
}
