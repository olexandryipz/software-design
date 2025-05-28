using System;
using System.Collections.Generic;

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 10.0m;
    public int MinimumPeriodMonths => 3;
    public List<string> Channels => new List<string> { "News", "Sports", "Movies" };
    public List<string> Features => new List<string> { "HD quality", "No ads" };
    public void ShowInfo()
    {
        Console.WriteLine("Domestic Subscription");
        Console.WriteLine($"Fee: {MonthlyFee}$, Min period: {MinimumPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
    }
}
