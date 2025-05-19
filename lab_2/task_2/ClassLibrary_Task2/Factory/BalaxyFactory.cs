using ClassLibrary_Task2.Devices;
using ClassLibrary_Task2.Devices.Interface;
using ClassLibrary_Task2.Factory.Interface;

namespace ClassLibrary_Task2.Factory
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new LaptopBalaxy();
        public IDevice CreateNetbook() => new NetbookBalaxy();
        public IDevice CreateEBook() => new EBookBalaxy();
        public IDevice CreateSmartphone() => new SmartphoneBalaxy();
    }
}
