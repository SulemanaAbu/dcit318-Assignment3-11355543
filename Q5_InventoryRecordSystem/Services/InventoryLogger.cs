using System;
using Q5_InventoryRecordSystem.Interfaces;

namespace Q5_InventoryRecordSystem.Services
{
    public class InventoryLogger<T> : ILogger<T>
    {
        public void Log(T item)
        {
            Console.WriteLine("[LOG] " + item.ToString());
        }
    }
}