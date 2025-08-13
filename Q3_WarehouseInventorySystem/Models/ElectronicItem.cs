using Q3_WarehouseInventorySystem.Interfaces;

namespace Q3_WarehouseInventorySystem.Models
{
    public class ElectronicItem : IInventoryItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public int WarrantyMonths { get; private set; }

        public ElectronicItem(int id, string name, int quantity, int warrantyMonths)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            WarrantyMonths = warrantyMonths;
        }

        public override string ToString()
        {
            return Id + ": " + Name + " (Qty: " + Quantity + ", Warranty: " + WarrantyMonths + " months)";
        }
    }
}