using System;
using System.Collections.Generic;

public class Reporting
{
    private List<WarehouseItem> inventory = new List<WarehouseItem>();

    public void ReceiveProduct(Product product, int quantity, DateTime date)
    {
        var existing = inventory.Find(i => i.Product.Name == product.Name);
        if (existing != null)
        {
            existing.Quantity += quantity;
            existing.LastDeliveryDate = date;
        }
        else
        {
            inventory.Add(new WarehouseItem(product, quantity, date));
        }
    }

    public void ShipProduct(string productName, int quantity)
    {
        var item = inventory.Find(i => i.Product.Name == productName);
        if (item != null && item.Quantity >= quantity)
        {
            item.Quantity -= quantity;
            Console.WriteLine($"Shipped {quantity} units of {productName}");
        }
        else
        {
            Console.WriteLine($"Cannot ship {productName}. Not enough stock.");
        }
    }

    public void InventoryReport()
    {
        Console.WriteLine("=== Warehouse Inventory Report ===");
        foreach (var item in inventory)
        {
            Console.WriteLine(item);
        }
    }
}
