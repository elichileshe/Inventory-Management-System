using System;
using System.Collections.Generic;

class Notifier
{
    // Method to check stock levels and notify if any product is running low
    public static void CheckStockLevels(List<Product> products)
    {
        foreach (var product in products)
        {
            if (product.Quantity < product.LowStockThreshold)
            {
                Console.WriteLine($"⚠️ Low Stock Alert: {product.Name} is running low!");
            }
        }
    }

    // Method to notify when a product is restocked
    public static void NotifyRestock(Product product, int amount)
    {
        Console.WriteLine($"✅ Restock Notification: {amount} units of {product.Name} have been added to the inventory.");
    }

    // Method to notify when a product is sold
    public static void NotifySale(Product product, int amount)
    {
        Console.WriteLine($"🛒 Sale Notification: {amount} units of {product.Name} have been sold.");
    }

    // Method to notify the total value of the inventory
    public static void NotifyTotalValue(List<Product> products)
    {
        double totalValue = 0;
        foreach (var product in products)
        {
            totalValue += product.GetTotalValue();
        }
        Console.WriteLine($"💰 Total Inventory Value: ${totalValue:F2}");
    }
}