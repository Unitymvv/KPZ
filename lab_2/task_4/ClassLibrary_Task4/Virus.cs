using System;
using System.Collections.Generic;

namespace ClassLibrary_Task4
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);

            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }

            return clone;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}Virus: {Name}, Species: {Species}, Age: {Age}, Weight: {Weight}");
            foreach (var child in Children)
            {
                child.Display(indent + "  ");
            }
        }
    }
}
