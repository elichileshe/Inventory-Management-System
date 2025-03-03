using System;
using System.Collections.Generic;

class InventoryManager
{
    // List to store the products in the inventory
    private List<Product> products = new List<Product>();

    // Method to add a product to the inventory
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Product added: {product.Name}");
    }

    // Method to remove a product from the inventory by name
    public void RemoveProduct(string name)
    {
        products.RemoveAll(p => p.Name.ToLower() == name.ToLower());
        Console.WriteLine($"Product removed: {name}");
    }

    // Method to display the current inventory
    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - ${product.Price} | Stock: {product.Quantity}");
        }
    }

    // Method to get the list of products in the inventory
    public List<Product> GetProducts()
    {
        return products;
    }

    // Method to check stock levels and notify if any product is running low
    public void CheckStockLevels()
    {
        Notifier.CheckStockLevels(products);
    }

    // Method to restock a product by name
    public void RestockProduct(string name, int amount)
    {
        var product = products.Find(p => p.Name.ToLower() == name.ToLower());
        if (product != null)
        {
            product.Restock(amount);
            Notifier.NotifyRestock(product, amount);
        }
        else
        {
            Console.WriteLine($"Product not found: {name}");
        }
    }

    // Method to sell a product by name
    public void SellProduct(string name, int amount)
    {
        var product = products.Find(p => p.Name.ToLower() == name.ToLower());
        if (product != null)
        {
            if (product.Sell(amount))
            {
                Notifier.NotifySale(product, amount);
            }
            else
            {
                Console.WriteLine($"Insufficient stock to sell {amount} units of {name}");
            }
        }
        else
        {
            Console.WriteLine($"Product not found: {name}");
        }
    }

    // Method to notify the total value of the inventory
    public void NotifyTotalValue()
    {
        Notifier.NotifyTotalValue(products);
    }
}