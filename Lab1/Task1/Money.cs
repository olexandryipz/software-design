public class Money
{
    public int WholePart { get; private set; }
    public int Cents { get; private set; }

    public Money(int whole, int cents)
    {
        SetMoney(whole, cents);
    }

    public void SetMoney(int whole, int cents)
    {
        WholePart = whole + cents / 100;
        Cents = cents % 100;
    }

    public override string ToString()
    {
        return $"{WholePart}.{Cents:D2}";
    }
}
