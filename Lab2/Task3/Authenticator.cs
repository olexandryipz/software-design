using System;

public class Authenticator
{
    protected Authenticator()
    {
        Console.WriteLine("Authenticator instance created.");
    }

    private static readonly Lazy<Authenticator> instance =
        new Lazy<Authenticator>(() => new Authenticator());

    public static Authenticator Instance => instance.Value;

    public void Authenticate()
    {
        Console.WriteLine("Authentication successful.");
    }
}
