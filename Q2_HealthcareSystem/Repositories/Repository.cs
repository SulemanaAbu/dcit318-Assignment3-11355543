using System;
using System.Collections.Generic;

namespace Q2_HealthcareSystem.Repositories
{
    // Simple in-memory repository (no generics features that need C# 9+)
    public class Repository<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }

        public T GetBy(Func<T, bool> predicate)
        {
            foreach (var item in _items)
            {
                if (predicate(item)) return item;
            }
            return default(T);
        }

        public bool Remove(Func<T, bool> predicate)
        {
            int index = -1;
            for (int i = 0; i < _items.Count; i++)
            {
                if (predicate(_items[i]))
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                _items.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}