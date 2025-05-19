using System.Collections.Generic;
using System;

namespace ClassLibrary_Task5
{
    public class Character
    {
        public string Name;
        public string Role;
        public string BodyType;
        public string HairColor;
        public string EyeColor;
        public string Clothes;
        public List<string> Inventory = new List<string>();
        public List<string> Deeds = new List<string>();

        public void Show()
        {
            Console.WriteLine($"  {Role}: {Name}");
            Console.WriteLine($"  Body: {BodyType}, Hair: {HairColor}, Eyes: {EyeColor}");
            Console.WriteLine($"  Clothes: {Clothes}");
            Console.WriteLine($"  Inventory: {string.Join(", ", Inventory)}");
            Console.WriteLine($"  Deeds: {string.Join(", ", Deeds)}\n");
        }
    }
}
