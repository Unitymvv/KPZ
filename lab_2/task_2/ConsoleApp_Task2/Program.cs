using ClassLibrary_Task2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IProne Devices:");
            var iproneClient = new FactoryClient(new IProneFactory());
            iproneClient.ShowAllDevices();

            Console.WriteLine("Kiaomi Devices:");
            var kiaomiClient = new FactoryClient(new KiaomiFactory());
            kiaomiClient.ShowAllDevices();

            Console.WriteLine("Balaxy Devices:");
            var balaxyClient = new FactoryClient(new BalaxyFactory());
            balaxyClient.ShowAllDevices();
        }
    }
}
