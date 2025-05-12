using ClassLibrary_Task5;
using ClassLibrary_Task6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new LightElementFlyweightFactory();
            string[] lines = File.ReadAllLines("book.txt");

            long memBefore = GC.GetTotalMemory(true);

            List<LightNode> htmlTree = LightHTMLParser.ParseLines(lines, factory);

            long memAfter = GC.GetTotalMemory(true);

            Console.WriteLine($"Rendered {htmlTree.Count} HTML nodes.");
            Console.WriteLine($"Unique flyweight elements used: {factory.GetFlyweightCount()}");

            Console.WriteLine($"Memory before: {memBefore / 1024} KB");
            Console.WriteLine($"Memory after: {memAfter / 1024} KB");
            Console.WriteLine($"Memory used: {(memAfter - memBefore) / 1024} KB");

            Console.WriteLine();
            Console.WriteLine("Preview:");
            foreach (var node in htmlTree)
            {
                Console.WriteLine(node.OuterHTML);
            }
        }
    }
}
