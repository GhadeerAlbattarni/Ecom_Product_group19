using System;
namespace Ecom_Product
{
	public class Product
	{
        // Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Method to increase stock
        public void StockIncrement(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
            }
            else
            {
                Stock += 0;
              
            }
        }

        // Method to decrease stock
        public void StockDecrement(int amount)
        {
            if (amount > 0)
            {
                Stock -= amount;
            }
            else
            {
                Stock -= 0;
                
            }
        }
    }
}

