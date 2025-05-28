using System;

public class WebSite : SubscriptionCreator
{
    public override ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("WebSite creating subscription...");
        switch (type)
        {
            case "Domestic": return new DomesticSubscription();
            case "Educational": return new EducationalSubscription();
            case "Premium": return new PremiumSubscription();
            default: throw new ArgumentException("Unknown subscription type");
        }
    }
}
