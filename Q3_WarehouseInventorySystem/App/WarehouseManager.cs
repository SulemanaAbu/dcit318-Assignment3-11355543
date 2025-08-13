using System;
using Q3_WarehouseInventorySystem.Models;
using Q3_WarehouseInventorySystem.Repositories;
using Q3_WarehouseInventorySystem.Exceptions;

namespace Q3_WarehouseInventorySystem.App
{
    public class WarehouseManager
    {
        private readonly InventoryRepository<ElectronicItem> _electronics = new InventoryRepository<ElectronicItem>();
        private readonly InventoryRepository<GroceryItem> _groceries = new InventoryRepository<GroceryItem>();

        public void SeedData()
        {
            _electronics.AddItem(new ElectronicItem(1, "Laptop", 5, 24));
            _electronics.AddItem(new ElectronicItem(2, "Smartphone", 10, 12));

            _groceries.AddItem(new GroceryItem(1, "Milk", 20, DateTime.Now.AddDays(5)));
            _groceries.AddItem(new GroceryItem(2, "Bread", 15, DateTime.Now.AddDays(2)));
        }

        public void PrintAllItems()
        {
            Console.WriteLine("\nElectronics:");
            foreach (var e in _electronics.GetAll())
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nGroceries:");
            foreach (var g in _groceries.GetAll())
            {
                Console.WriteLine(g.ToString());
            }
        }

        public void AddElectronic(ElectronicItem item)
        {
            try
            {
                _electronics.AddItem(item);
                Console.WriteLine("Electronic item added successfully.");
            }
            catch (InventoryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void AddGrocery(GroceryItem item)
        {
            try
            {
                _groceries.AddItem(item);
                Console.WriteLine("Grocery item added successfully.");
            }
            catch (InventoryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}