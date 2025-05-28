using System;

class Program
{
    static void Main()
    {
        var auth1 = Authenticator.Instance;
        var auth2 = Authenticator.Instance;

        if (object.ReferenceEquals(auth1, auth2))
        {
            Console.WriteLine("Single instance confirmed.");
        }
        else
        {
            Console.WriteLine("Different instances!");
        }

        auth1.Authenticate();
        auth2.Authenticate();
    }
}
