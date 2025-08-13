using System;
using System.Collections.Generic;
using Q3_WarehouseInventorySystem.Interfaces;
using Q3_WarehouseInventorySystem.Exceptions;

namespace Q3_WarehouseInventorySystem.Repositories
{
    public class InventoryRepository<T> where T : IInventoryItem
    {
        private readonly List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            foreach (var existing in _items)
            {
                if (existing.Id == item.Id)
                {
                    throw new InventoryException("Item with ID " + item.Id + " already exists.");
                }
            }
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }

        public T GetById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default(T);
        }

        public bool RemoveItem(int id)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    _items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}