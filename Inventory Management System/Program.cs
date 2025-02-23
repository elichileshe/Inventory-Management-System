using System;
using System.Collections.Generic;

namespace Inventory_Management_System
{
    public class InventoryManager
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public void UpdateProduct(Product product)
        {
            // Update product
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
