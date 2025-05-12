namespace ClassLibrary_Task2
{
    public class MagicRing : HeroDecorator
    {
        public MagicRing(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + "Magic Ring ";
        }

        public override int GetPower()
        {
            return base.GetPower() + 7;
        }
    }
}
