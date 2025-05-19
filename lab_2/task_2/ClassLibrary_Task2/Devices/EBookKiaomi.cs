using ClassLibrary_Task2.Devices.Interface;
using System;

namespace ClassLibrary_Task2.Devices
{
    public class EBookKiaomi : IDevice
    {
        public void ShowInfo() => Console.WriteLine("EBook from Kiaomi");
    }
}
