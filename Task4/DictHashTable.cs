using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class DictHashTable: IEnumerable
    {
        private HashTable _hashTable;
        public int Size { get; set; } = 0;

        public DictHashTable()
        {
            _hashTable = new HashTable();
        }

        public void Add(string k, int v)
        {
            _hashTable.Add(k, v);
            Size++;
        }
        public void Remove(string k)
        {
            _hashTable.Delete(k);
            Size--;
        }
        public Chain GetElement(string k)
        {
            return _hashTable.Search(k);
        }
        public string GetElementKey(string k)
        {
            return _hashTable.Search(k).Key;
        }
        public string Print()
        {
            return _hashTable.Print();
        }

        public IEnumerator GetEnumerator()
        {
            return _hashTable.ToArray().GetEnumerator();
        }
    }
}
