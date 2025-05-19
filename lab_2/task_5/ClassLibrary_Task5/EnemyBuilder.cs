namespace ClassLibrary_Task5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character enemy = new Character { Role = "Enemy" };

        public ICharacterBuilder SetName(string name) { enemy.Name = name; return this; }
        public ICharacterBuilder SetBody(string body) { enemy.BodyType = body; return this; }
        public ICharacterBuilder SetHairColor(string color) { enemy.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { enemy.EyeColor = color; return this; }
        public ICharacterBuilder SetClothes(string clothes) { enemy.Clothes = clothes; return this; }
        public ICharacterBuilder AddToInventory(string item) { enemy.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { enemy.Deeds.Add("Evil: " + deed); return this; }

        public Character Build() => enemy;
    }
}
