public class Director
{
    public void ConstructHero(ICharacterBuilder builder)
    {
        builder.SetName("Artemis")
               .SetHeight(180)
               .SetBuild("Athletic")
               .SetHairColor("Blonde")
               .SetEyeColor("Green")
               .SetClothing("Leather Armor")
               .AddInventoryItem("Bow")
               .AddInventoryItem("Healing Potion")
               .AddGoodDeed("Saved the village")
               .AddGoodDeed("Protected the forest");
    }

    public void ConstructEnemy(ICharacterBuilder builder)
    {
        builder.SetName("Darklord")
               .SetHeight(190)
               .SetBuild("Muscular")
               .SetHairColor("Black")
               .SetEyeColor("Red")
               .SetClothing("Dark Robes")
               .AddInventoryItem("Magic Staff")
               .AddInventoryItem("Cursed Dagger")
               .AddEvilDeed("Burned the village")
               .AddEvilDeed("Kidnapped the princess");
    }
}
