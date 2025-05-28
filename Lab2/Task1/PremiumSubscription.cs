using System;
using System.Collections.Generic;

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 20.0m;
    public int MinimumPeriodMonths => 1;
    public List<string> Channels => new List<string> { "All channels" };
    public List<string> Features => new List<string> { "4K quality", "Offline viewing", "Multiple devices" };
    public void ShowInfo()
    {
        Console.WriteLine("Premium Subscription");
        Console.WriteLine($"Fee: {MonthlyFee}$, Min period: {MinimumPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
    }
}
