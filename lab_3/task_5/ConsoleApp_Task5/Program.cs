using ClassLibrary_Task5;
using ClassLibrary_Task5.Command;
using ClassLibrary_Task5.State;
using System;

namespace ConsoleApp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing Template Method 
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
            #endregion
            #region Testing Iterator
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

            Console.WriteLine("\nIterator testing complete!\n");
            #endregion
            #region Testing Command
            Console.WriteLine("=== Testing Command ===");

            var element = new LightElementNode("div");
            Console.WriteLine("Before command: " + element.OuterHTML);

            var command = new AddClassCommand(element, "active");
            command.Execute();
            Console.WriteLine("After execute: " + element.OuterHTML);

            command.Undo();
            Console.WriteLine("After undo: " + element.OuterHTML);

            Console.WriteLine("\nCommand testing complete!\n");
            #endregion
            #region Testing State
            Console.WriteLine("=== Testing State ===");

            element = new LightElementNode("div");
            Console.WriteLine("Initial State:\n" + element.OuterHTML);

            element.SetDisplayState(new InlineState());
            Console.WriteLine("\nAfter switching to Inline:\n" + element.OuterHTML);

            element.SetDisplayState(new NoneState());
            Console.WriteLine("\nAfter switching to None:\n" + element.OuterHTML);

            element.SetDisplayState(new BlockState());
            Console.WriteLine("\nAfter switching to Block:\n" + element.OuterHTML);
            Console.WriteLine("\nState testing complete!\n");
            #endregion
        }
    }
}