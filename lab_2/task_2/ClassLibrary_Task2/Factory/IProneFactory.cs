using ClassLibrary_Task2.Devices;
using ClassLibrary_Task2.Devices.Interface;
using ClassLibrary_Task2.Factory.Interface;

namespace ClassLibrary_Task2.Factory
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new LaptopIProne();
        public IDevice CreateNetbook() => new NetbookIProne();
        public IDevice CreateEBook() => new EBookIProne();
        public IDevice CreateSmartphone() => new SmartphoneIProne();
    }
}
