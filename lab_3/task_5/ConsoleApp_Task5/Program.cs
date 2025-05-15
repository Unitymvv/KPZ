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


            Console.WriteLine("\n=== Testing Iterator ===");

            var root = new LightElementNode("div");
            var header = new LightElementNode("h1");
            header.AddChild(text);
            root.AddChild(header);

            var list = new LightElementNode("ul");
            list.AddChild(new LightElementNode("li"));
            list.AddChild(new LightElementNode("li"));
            root.AddChild(list);

            Console.WriteLine("\n=== Depth-First Traversal ===");
            var dfs = root.GetDepthFirstIterator();
            while (dfs.HasNext())
            {
                var node = dfs.Next();
                if (node is LightTextNode txt)
                    Console.WriteLine($"Text node: {txt.OuterHTML}");
                else
                    Console.WriteLine($"Element: {((LightElementNode)node).TagName}");
            }

            Console.WriteLine("\n=== Breadth-First Traversal ===");
            var bfs = root.GetBreadthFirstIterator();
            while (bfs.HasNext())
            {
                var node = bfs.Next();
                if (node is LightTextNode txt)
                    Console.WriteLine($"Text node: {txt.OuterHTML}");
                else
                    Console.WriteLine($"Element: {((LightElementNode)node).TagName}");
            }

            Console.WriteLine("\nIterator testing complete!");
        }
    }
}