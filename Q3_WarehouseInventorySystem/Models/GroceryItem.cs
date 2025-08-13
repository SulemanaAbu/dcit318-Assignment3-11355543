using System;
using Q3_WarehouseInventorySystem.Interfaces;

namespace Q3_WarehouseInventorySystem.Models
{
    public class GroceryItem : IInventoryItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public GroceryItem(int id, string name, int quantity, DateTime expiryDate)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return Id + ": " + Name + " (Qty: " + Quantity + ", Expires: " + ExpiryDate.ToShortDateString() + ")";
        }
    }
}