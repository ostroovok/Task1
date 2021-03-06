using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Chain
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public Chain Next { get; set; }

        public Chain(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
