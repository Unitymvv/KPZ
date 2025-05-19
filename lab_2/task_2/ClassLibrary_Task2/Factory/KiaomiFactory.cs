using ClassLibrary_Task2.Devices;
using ClassLibrary_Task2.Devices.Interface;
using ClassLibrary_Task2.Factory.Interface;

namespace ClassLibrary_Task2.Factory
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new LaptopKiaomi();
        public IDevice CreateNetbook() => new NetbookKiaomi();
        public IDevice CreateEBook() => new EBookKiaomi();
        public IDevice CreateSmartphone() => new SmartphoneKiaomi();
    }
}
