using ClassLibrary_Task5;
using System;

namespace ConsoleApp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Template Method ===");

            Console.WriteLine("\nCreating elements...");
            var div = new LightElementNode("div");
            Console.WriteLine(div.OuterHTML);

            var text = new LightTextNode("Hello World");
            Console.WriteLine(text.OuterHTML);

            Console.WriteLine("\nAdding child...");
            div.AddChild(text);
            Console.WriteLine(div.OuterHTML);

            Console.WriteLine("\nTemplate Method testing complete!");
        }
    }
}