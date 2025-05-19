namespace ClassLibrary_Task5
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character hero = new Character { Role = "Hero" };

        public ICharacterBuilder SetName(string name) { hero.Name = name; return this; }
        public ICharacterBuilder SetBody(string body) { hero.BodyType = body; return this; }
        public ICharacterBuilder SetHairColor(string color) { hero.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { hero.EyeColor = color; return this; }
        public ICharacterBuilder SetClothes(string clothes) { hero.Clothes = clothes; return this; }
        public ICharacterBuilder AddToInventory(string item) { hero.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { hero.Deeds.Add("Good: " + deed); return this; }

        public Character Build() => hero;
    }
}
