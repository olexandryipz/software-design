public class WeaponDecorator : HeroDecorator
{
    public WeaponDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => hero.GetDescription() + " + Weapon";
    public override int GetPower() => hero.GetPower() + 30;
}
