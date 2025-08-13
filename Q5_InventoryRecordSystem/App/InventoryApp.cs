using System;
using System.Collections.Generic;
using Q5_InventoryRecordSystem.Models;
using Q5_InventoryRecordSystem.Services;

namespace Q5_InventoryRecordSystem.App
{
    public class InventoryApp
    {
        private readonly InventoryLogger<InventoryItem> _logger = new InventoryLogger<InventoryItem>();
        private readonly List<InventoryItem> _items = new List<InventoryItem>();

        public void AddItem(InventoryItem item)
        {
            _items.Add(item);
            _logger.Log(item);
        }

        public void PrintAllItems()
        {
            Console.WriteLine("\nInventory List:");
            foreach (var item in _items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}