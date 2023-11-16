using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Merchant.Models
{
    public class Cart
    {
        public int Id { get; set; }
        // The list of OrderItems in the cart
        public List<OrderItem> OrderItems { get; set; }

        // The total amount of the cart
        public float Total { get; set; }

        // The number of OrderItems in the cart
        public int Count { get; set; }

        // The constructor that initializes the properties
        public Cart()
        {
            OrderItems = new List<OrderItem>();
            Total = 0;
            Count = 0;
        }

        // The method that adds an item to the cart
        public void AddItem(Product product, int quantity)
        {
            // Check if the product already exists in the cart
            var existingItem = OrderItems.Find(i => i.Product.Id == product.Id);

            // If yes, update the quantity
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            // If no, add a new item
            else
            {
                var newItem = new OrderItem()
                {
                    Product = product,
                    Quantity = quantity
                };
                OrderItems.Add(newItem);
            }

            // Update the total and the count
            Total += product.Price * quantity;
            Count += quantity;
        }

        // The method that removes an item from the cart
        public void RemoveItem(Product product)
        {
            // Find the item that matches the product
            var existingItem = OrderItems.Find(i => i.Product.Id == product.Id);

            // If found, remove it from the list
            if (existingItem != null)
            {
                OrderItems.Remove(existingItem);

                // Update the total and the count
                Total -= existingItem.Product.Price * existingItem.Quantity;
                Count -= existingItem.Quantity;
            }
        }

        // The method that clears the cart
        public void Clear()
        {
            // Clear the list of OrderItems
            OrderItems.Clear();

            // Reset the total and the count
            Total = 0;
            Count = 0;
        }
    }

    // The class that represents an item in the cart
    public class Item
    {
        // The product object
        public Product Product { get; set; }

        // The quantity of the product
        public int Quantity { get; set; }
    }
}
