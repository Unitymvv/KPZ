using System;

namespace DesignPatterns.Mediator
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy { get; private set; }

        public void MarkAsBusy()
        {
            IsBusy = true;
            Console.WriteLine($"Runway {Id} is now busy!");
        }

        public void MarkAsFree()
        {
            IsBusy = false;
            Console.WriteLine($"Runway {Id} is now free!");
        }
    }
}