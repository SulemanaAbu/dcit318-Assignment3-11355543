using Q5_InventoryRecordSystem.App;
using Q5_InventoryRecordSystem.Models;

namespace Q5_InventoryRecordSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryApp app = new InventoryApp();

            app.AddItem(new InventoryItem(1, "Laptop", 5));
            app.AddItem(new InventoryItem(2, "Mouse", 20));
            app.AddItem(new InventoryItem(3, "Keyboard", 15));

            app.PrintAllItems();
        }
    }
}