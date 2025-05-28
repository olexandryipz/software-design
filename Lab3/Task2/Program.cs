using System;

class Program
{
    static void Main()
    {
        IHero warrior = new Warrior();
        warrior = new ArmorDecorator(warrior);
        warrior = new WeaponDecorator(warrior);
        warrior = new ArtifactDecorator(warrior);

        Console.WriteLine(warrior.GetDescription());
        Console.WriteLine("Total Power: " + warrior.GetPower());

        Console.WriteLine();

        IHero mage = new Mage();
        mage = new ArtifactDecorator(mage);
        mage = new WeaponDecorator(mage);

        Console.WriteLine(mage.GetDescription());
        Console.WriteLine("Total Power: " + mage.GetPower());
    }
}
