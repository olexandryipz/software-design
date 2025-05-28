using System;

class Program
{
    static void Main()
    {
        var price1 = new Money(100, 50);
        var product1 = new Product("Milk", "L", price1);

        var price2 = new Money(200, 0);
        var product2 = new Product("Bread", "pcs", price2);

        var report = new Reporting();
        report.ReceiveProduct(product1, 50, DateTime.Now);
        report.ReceiveProduct(product2, 30, DateTime.Now);

        product1.DecreasePrice(10, 25);

        report.ShipProduct("Milk", 10);
        report.InventoryReport();
    }
}
