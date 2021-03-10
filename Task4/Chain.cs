using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Chain
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public Chain Next { get; set; }

        public Chain(string key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
