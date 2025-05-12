using ClassLibrary_Task2;
using System;

namespace ConsoleApp_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHero warrior = new HeroWarrior();
            warrior = new Sword(warrior);
            warrior = new Armor(warrior);
            warrior = new MagicRing(warrior);

            IHero mage = new HeroMage();
            mage = new MagicRing(new MagicRing(mage));
            
            IHero palladin = new HeroPalladin();
            palladin = new Sword(palladin);

            Console.WriteLine(warrior.GetDescription() + " => Power: " + warrior.GetPower());
            Console.WriteLine(mage.GetDescription() + " => Power: " + mage.GetPower());
            Console.WriteLine(palladin.GetDescription() + " => Power: " + palladin.GetPower());
        }
    }
}
