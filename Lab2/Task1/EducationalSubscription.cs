using System;
using System.Collections.Generic;

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 5.0m;
    public int MinimumPeriodMonths => 6;
    public List<string> Channels => new List<string> { "Education", "Science", "History" };
    public List<string> Features => new List<string> { "SD quality", "Subtitles" };
    public void ShowInfo()
    {
        Console.WriteLine("Educational Subscription");
        Console.WriteLine($"Fee: {MonthlyFee}$, Min period: {MinimumPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
    }
}
