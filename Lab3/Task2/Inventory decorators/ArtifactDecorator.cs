public class ArtifactDecorator : HeroDecorator
{
    public ArtifactDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => hero.GetDescription() + " + Artifact";
    public override int GetPower() => hero.GetPower() + 25;
}
