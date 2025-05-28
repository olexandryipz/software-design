using System;

public class WarehouseItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }

    public WarehouseItem(Product product, int quantity, DateTime deliveryDate)
    {
        Product = product;
        Quantity = quantity;
        LastDeliveryDate = deliveryDate;
    }

    public override string ToString()
    {
        return $"{Product} | Quantity: {Quantity}, Delivery Date: {LastDeliveryDate.ToShortDateString()}";
    }
}
