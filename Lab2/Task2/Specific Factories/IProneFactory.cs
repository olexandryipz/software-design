﻿public class IProneFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new IProneLaptop();
    public INetbook CreateNetbook() => new IProneNetbook();
    public IEBook CreateEBook() => new IProneEBook();
    public ISmartphone CreateSmartphone() => new IProneSmartphone();
}
