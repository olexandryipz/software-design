using System;

class Program
{
    static void Main()
    {
        Director director = new Director();

        ICharacterBuilder heroBuilder = new HeroBuilder();
        director.ConstructHero(heroBuilder);
        Character hero = heroBuilder.Build();

        ICharacterBuilder enemyBuilder = new EnemyBuilder();
        director.ConstructEnemy(enemyBuilder);
        Character enemy = enemyBuilder.Build();

        Console.WriteLine("=== Hero ===");
        Console.WriteLine(hero);

        Console.WriteLine("\n=== Enemy ===");
        Console.WriteLine(enemy);
    }
}
