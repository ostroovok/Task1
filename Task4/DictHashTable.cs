using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class DictHashTable: HashTable
    {
        private HashTable _hashTable;
        public int Size { get; set; } = 0;

        public DictHashTable()
        {
            _hashTable = new HashTable();
        }

        public override void Add(int k, string v)
        {
            _hashTable.Add(k, v);
            Size++;
        }
        public void Remove(int k)
        {
            _hashTable.Delete(k);
            Size--;
        }
        public object GetElement(int k)
        {
            return _hashTable.Search(k);
        }
        public override string Print()
        {
            return _hashTable.Print();
        }
    }
}
