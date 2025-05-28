using System;
using System.Collections.Generic;

public class Character
{
    public string Name { get; set; }
    public int Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothing { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> GoodDeeds { get; set; } = new List<string>();
    public List<string> EvilDeeds { get; set; } = new List<string>();

    public override string ToString()
    {
        string inventory = Inventory.Count > 0 ? string.Join(", ", Inventory) : "None";
        string goodDeeds = GoodDeeds.Count > 0 ? string.Join(", ", GoodDeeds) : "None";
        string evilDeeds = EvilDeeds.Count > 0 ? string.Join(", ", EvilDeeds) : "None";

        return $"Name: {Name}\nHeight: {Height} cm\nBuild: {Build}\nHair: {HairColor}\nEyes: {EyeColor}\n" +
               $"Clothing: {Clothing}\nInventory: {inventory}\nGood Deeds: {goodDeeds}\nEvil Deeds: {evilDeeds}";
    }
}
