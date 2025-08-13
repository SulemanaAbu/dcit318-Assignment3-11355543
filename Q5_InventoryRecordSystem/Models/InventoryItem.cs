namespace Q5_InventoryRecordSystem.Models
{
    public class InventoryItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public InventoryItem(int id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Id + ": " + Name + " (Qty: " + Quantity + ")";
        }
    }
}