using ClassLibrary_Task3.LightHTML;
using System;

namespace ConsoleApp_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div");
            var p = new LightElementNode("p");
            var text = new LightTextNode("Click me!");

            p.AddChild(text);
            div.AddChild(p);

            p.AddEventListener("click", () => Console.WriteLine("Paragraph clicked!"));
            p.AddEventListener("mouseover", () => Console.WriteLine("Mouse over paragraph!"));

            Console.WriteLine("HTML:");
            Console.WriteLine(div.OuterHTML);

            Console.WriteLine("\n--- Dispatching events ---");
            p.DispatchEvent("click");
            p.DispatchEvent("mouseover");
            p.DispatchEvent("dblclick\n");

            var img1 = new LightImageElement("images/photo.jpg");
            var img2 = new LightImageElement("https://example.com/image.png");

            Console.WriteLine("\nHTML output:");
            Console.WriteLine(img1.OuterHTML);
            Console.WriteLine(img2.OuterHTML);
        }
    }
}
