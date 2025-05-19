using ClassLibrary_Task4;
using System;

namespace ConsoleApp_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virus child1 = new Virus("Alpha-1", "Type A", 0.5, 1);
            Virus child2 = new Virus("Alpha-2", "Type A", 0.6, 1);
            Virus grandchild = new Virus("Beta-1", "Type B", 0.3, 0);

            child1.Children.Add(grandchild); 

            Virus parent = new Virus("Parent-V", "Master", 1.5, 5);
            parent.Children.Add(child1);
            parent.Children.Add(child2); 

            Console.WriteLine("Original virus family:");
            parent.Display();

            Virus clone = (Virus)parent.Clone();

            Console.WriteLine("\nCloned virus family:");
            clone.Display();
        }
    }
}
