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
        private int size = 0;

        public DictHashTable()
        {
            _hashTable = new HashTable();
        }

        public override void Add(int k, int v)
        {
            _hashTable.Add(k, v);
            size++;
        }
        public void Remove(int k)
        {
            _hashTable.Delete(k);
            size--;
        }
        public int Size()
        {
            return size;
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
