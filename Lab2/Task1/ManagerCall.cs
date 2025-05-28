using System;

public class ManagerCall : SubscriptionCreator
{
    public override ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("ManagerCall creating subscription...");
        ISubscription sub;
        switch (type)
        {
            case "Domestic":
                sub = new DomesticSubscription();
                break;
            case "Educational":
                sub = new EducationalSubscription();
                break;
            case "Premium":
                sub = new PremiumSubscription();
                break;
            default:
                throw new ArgumentException("Unknown subscription type");
        }
        return sub;
    }
}
