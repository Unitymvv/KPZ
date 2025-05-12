using ClassLibrary_Task5;
using System;

namespace ConsoleApp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ul = new LightElementNode("ul", DisplayType.Block);
            ul.AddClass("menu");

            var li1 = new LightElementNode("li");
            li1.AddClass("menu-item");
            li1.AddChild(new LightTextNode("Home"));

            var li2 = new LightElementNode("li");
            li2.AddClass("menu-item");
            li2.AddChild(new LightTextNode("About"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            Console.WriteLine("OuterHTML:");
            Console.WriteLine(ul.OuterHTML);
            Console.WriteLine();
            Console.WriteLine("InnerHTML:");
            Console.WriteLine(ul.InnerHTML);
            Console.WriteLine();
        }
    }
}