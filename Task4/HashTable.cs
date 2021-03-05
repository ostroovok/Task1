using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class HashTable
    {
        private readonly int _startCapacity = 16;
        private Chain[] _table;
        private int _capacity;

        public HashTable()
        {
            _capacity = _startCapacity;
            _table = new Chain[_capacity];
            for (int i = 0; i < _capacity; ++i)
            {
                _table[i] = null;
            }
        }

        public HashTable(int capacity)
        {
            _table = new Chain[capacity];
            _capacity = capacity;
            for (int i = 0; i < _capacity; i++)
            {
                _table[i] = null;
            }
        }


        public virtual void Add(int key, int value)
        {
            int hash = (key % _capacity);
            if (_table[hash] == null)
            {
                _table[hash] = new Chain(key, value);
            }
            else
            {
                Chain entry = _table[hash];
                while (entry.Next != null && entry.Key != key)
                {
                    entry = entry.Next;
                }
                if (entry.Key == key)
                {
                    entry.Value = value;
                }
                else
                {
                    entry.Next = new Chain(key, value);
                }
            }
        }


        public virtual void Delete(int key)
        {
            int hash = (key % _capacity);
            if (_table[hash] != null)
            {
                Chain prevEntry = null;
                Chain entry = _table[hash];
                while (entry.Next != null && entry.Key != key)
                {
                    prevEntry = entry;
                    entry = entry.Next;
                }
                if (entry.Key == key)
                {
                    if (prevEntry == null)
                    {
                        _table[hash] = entry.Next;
                    }
                    else
                    {
                        prevEntry.Next = entry.Next;
                    }
                }
            }
        }
        public virtual object Search(int key)
        {
            int hash = (key % _capacity);
            if (_table[hash] == null)
                return null;
            else
            {
                Chain entry = _table[hash];
                while (entry != null && entry.Key != key)
                {
                    entry = entry.Next;
                }
                if (entry == null)
                {
                    return null;
                }
                else
                {
                    return entry.Value;
                }
            }
        }

        public bool IsEmpty()
        {
            for (int i = 0; i < _capacity; ++i)
            {
                Chain entry = _table[i];
                if (entry != null)
                {
                    return false;
                }
            }
            return true;
        }

        public virtual string Print()
        {
            StringBuilder description = new StringBuilder("Hash table: [ ");
            for (int i = 0; i < _capacity; i++)
            {
                description.Append("{  ");
                if (_table[i] != null)
                {
                    Chain entry = _table[i];
                    do
                    {
                        description.Append($"{entry.Value}");
                        entry = entry.Next;
                    } while (entry != null);
                }
                description.Append("} ");
            }
            description.Append(']');
            return description.ToString();
        }
    }
}
