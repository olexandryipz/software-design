public class Product
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public Money Price { get; private set; }

    public Product(string name, string unit, Money price)
    {
        Name = name;
        Unit = unit;
        Price = price;
    }

    public void DecreasePrice(int whole, int cents)
    {
        int totalCents = Price.WholePart * 100 + Price.Cents - (whole * 100 + cents);
        if (totalCents < 0) totalCents = 0;
        Price = new Money(totalCents / 100, totalCents % 100);
    }

    public override string ToString()
    {
        return $"{Name} ({Unit}) - {Price}";
    }
}
