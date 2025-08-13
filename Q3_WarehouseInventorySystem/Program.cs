using System;
using Q3_WarehouseInventorySystem.App;
using Q3_WarehouseInventorySystem.Models;

namespace Q3_WarehouseInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WarehouseManager manager = new WarehouseManager();
            manager.SeedData();
            manager.PrintAllItems();

            Console.WriteLine("\nAdding a new electronic item:");
            manager.AddElectronic(new ElectronicItem(3, "Tablet", 7, 18));

            Console.WriteLine("\nAdding a duplicate grocery item (should show error):");
            manager.AddGrocery(new GroceryItem(2, "Bread", 5, DateTime.Now.AddDays(4)));

            Console.WriteLine();
            manager.PrintAllItems();
        }
    }
}