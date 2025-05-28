using System;

class Program
{
    static void Main()
    {
        SubscriptionCreator website = new WebSite();
        ISubscription sub1 = website.CreateSubscription("Domestic");
        sub1.ShowInfo();

        Console.WriteLine();

        SubscriptionCreator mobile = new MobileApp();
        ISubscription sub2 = mobile.CreateSubscription("Premium");
        sub2.ShowInfo();

        Console.WriteLine();

        SubscriptionCreator call = new ManagerCall();
        ISubscription sub3 = call.CreateSubscription("Educational");
        sub3.ShowInfo();
    }
}
