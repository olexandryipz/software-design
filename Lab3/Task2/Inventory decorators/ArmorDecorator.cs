public class ArmorDecorator : HeroDecorator
{
    public ArmorDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => hero.GetDescription() + " + Armor";
    public override int GetPower() => hero.GetPower() + 20;
}
