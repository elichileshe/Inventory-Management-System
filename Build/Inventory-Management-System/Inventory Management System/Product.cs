class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int LowStockThreshold { get; set; } = 5;

    // Constructor
    public Product(string name, string category, double price, int quantity)
    {
        Name = name;
        Category = category;
        Price = price;
        Quantity = quantity;
    }

    // Method to check if the product is low in stock
    public bool IsLowInStock()
    {
        return Quantity <= LowStockThreshold;
    }

    // Method to restock the product
    public void Restock(int amount)
    {
        if (amount > 0)
        {
            Quantity += amount;
        }
    }

    // Method to sell the product
    public bool Sell(int amount)
    {
        if (amount > 0 && amount <= Quantity)
        {
            Quantity -= amount;
            return true;
        }
        return false;
    }

    // Method to get the total value of the stock
    public double GetTotalValue()
    {
        return Price * Quantity;
    }
}