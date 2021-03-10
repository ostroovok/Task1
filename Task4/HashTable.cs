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
        private int _maxSize = 255;
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


        public virtual void Add(string key, int value)
        {
            int hash = GetHash(key);
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


        public virtual void Delete(string key)
        {
            int hash = GetHash(key);
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
        public virtual Chain Search(string key)
        {
            int hash = GetHash(key);
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
                    return entry;
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

        private int GetHash(string value)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.Length > _maxSize)
            {
                throw new ArgumentException($"Максимальная длинна ключа составляет {_maxSize} символов.", nameof(value));
            }

            // Получаем длину строки.
            var hash = value.Length;
            return hash;
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

        public virtual Chain[] ToArray()
        {
            List<Chain> list = new List<Chain>();
            for (int i = 0; i < _capacity; i++)
            {
                if (_table[i] != null)
                {
                    Chain entry = _table[i];
                    do
                    {
                        list.Add(entry);
                        entry = entry.Next;
                    } while (entry != null);
                }
            }
            return list.ToArray();
        }
    }
}
