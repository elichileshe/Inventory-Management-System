using System;
using System.Text;
using System.Collections.Generic;  
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an instance of InventoryManager to manage the inventory
        InventoryManager inventory = new InventoryManager();

        // Infinite loop to keep the program running until the user chooses to exit
        while (true)
        {
            // Display the menu options to the user
            Console.WriteLine("\n1. Add Product\n2. Display Inventory\n3. Remove Product\n4. Check Stock Levels\n5. Exit");
            Console.Write("Choose an option: ");
            
            // Try to parse the user's choice and handle invalid input
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("❌ Invalid input, please enter a number.");
                continue;
            }

            // Switch statement to handle the user's choice
            switch (choice)
            {
                case 1:
                    // Add a new product to the inventory
                    try
                    {
                        Console.Write("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Category: ");
                        string category = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        inventory.AddProduct(new Product(name, category, price, quantity));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("❌ Invalid input, please enter the correct data types.");
                    }
                    break;
                
                case 2:
                    // Display the current inventory
                    inventory.DisplayInventory();
                    break;

                case 3:
                    // Remove a product from the inventory by name
                    Console.Write("Enter Product Name to Remove: ");
                    string removeName = Console.ReadLine();
                    inventory.RemoveProduct(removeName);
                    break;

                case 4:
                    // Check stock levels and notify if any product is running low
                    inventory.CheckStockLevels();
                    break;

                case 5:
                    // Exit the program
                    return;

                default:
                    // Handle invalid menu choices
                    Console.WriteLine("❌ Invalid choice, try again.");
                    break;
            }
        }
    }
}