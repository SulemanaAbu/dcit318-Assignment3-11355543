using System;

namespace Q3_WarehouseInventorySystem.Exceptions
{
    public class InventoryException : Exception
    {
        public InventoryException(string message) : base(message)
        {
        }
    }
}