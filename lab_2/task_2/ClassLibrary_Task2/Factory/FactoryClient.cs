using ClassLibrary_Task2.Devices.Interface;
using ClassLibrary_Task2.Factory.Interface;
using System;

namespace ClassLibrary_Task2.Factory
{
    public class FactoryClient
    {
        private IDevice _laptop;
        private IDevice _netbook;
        private IDevice _smartphone;
        private IDevice _ebook;

        public FactoryClient(IDeviceFactory factory)
        {
            _laptop = factory.CreateLaptop();
            _netbook = factory.CreateNetbook();
            _ebook = factory.CreateEBook();
            _smartphone = factory.CreateSmartphone();
        }

        public void ShowAllDevices()
        {
            _laptop.ShowInfo();
            _netbook.ShowInfo();
            _ebook.ShowInfo();
            _smartphone.ShowInfo();
            Console.WriteLine();
        }
    }
}
