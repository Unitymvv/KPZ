namespace ClassLibrary_Task5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetBody(string body);
        ICharacterBuilder SetHairColor(string color);
        ICharacterBuilder SetEyeColor(string color);
        ICharacterBuilder SetClothes(string clothes);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder AddDeed(string deed);
        Character Build();
    }
}
