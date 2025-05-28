﻿public interface IDeviceFactory
{
    ILaptop CreateLaptop();
    INetbook CreateNetbook();
    IEBook CreateEBook();
    ISmartphone CreateSmartphone();
}
