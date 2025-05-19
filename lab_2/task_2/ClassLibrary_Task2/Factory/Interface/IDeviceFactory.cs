using ClassLibrary_Task2.Devices.Interface;

namespace ClassLibrary_Task2.Factory.Interface
{
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }
}
