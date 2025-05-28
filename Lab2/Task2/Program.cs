using System;

class Program
{
    static void Main()
    {
        IDeviceFactory iproneFactory = new IProneFactory();
        Console.WriteLine(iproneFactory.CreateLaptop().GetName());
        Console.WriteLine(iproneFactory.CreateNetbook().GetName());
        Console.WriteLine(iproneFactory.CreateEBook().GetName());
        Console.WriteLine(iproneFactory.CreateSmartphone().GetName());

        Console.WriteLine();

        IDeviceFactory kiamioFactory = new KiaomiFactory();
        Console.WriteLine(kiamioFactory.CreateLaptop().GetName());
        Console.WriteLine(kiamioFactory.CreateNetbook().GetName());
        Console.WriteLine(kiamioFactory.CreateEBook().GetName());
        Console.WriteLine(kiamioFactory.CreateSmartphone().GetName());

        Console.WriteLine();

        IDeviceFactory balaxyFactory = new BalaxyFactory();
        Console.WriteLine(balaxyFactory.CreateLaptop().GetName());
        Console.WriteLine(balaxyFactory.CreateNetbook().GetName());
        Console.WriteLine(balaxyFactory.CreateEBook().GetName());
        Console.WriteLine(balaxyFactory.CreateSmartphone().GetName());
    }
}
