namespace ClassLibrary_Task5
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetName("Araviel")
                          .SetBody("Short, elven build")
                          .SetHairColor("Purple")
                          .SetEyeColor("Blue")
                          .SetClothes("Light battle robe with emblem of light")
                          .AddToInventory("Bow of True Sight")
                          .AddToInventory("Amulet of Protection")
                          .AddDeed("Banished darkness from the sacred temple")
                          .AddDeed("Healed the sick in the city")
                          .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetName("Morgrath")
                          .SetBody("Huge, demonic figure")
                          .SetHairColor("None")
                          .SetEyeColor("Green")
                          .SetClothes("Tattered necromancer's cloak")
                          .AddToInventory("Orb of Destruction")
                          .AddToInventory("Staff of Shadows")
                          .AddDeed("Enslaved the souls of wizards")
                          .AddDeed("Poisoned the sacred wells")
                          .Build();
        }
    }
}
