using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class BinaryListHeap
    {
        public class Node
        {
            public int Priority { get; set; }
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int priority, int value, Node next)
            {
                Priority = priority;
                Value = value;
                Next = next;
            }
        }

        public int Size { get; set; } = 0;

        //private List<Node> _elements;
        protected Node _head = null;
        protected Node _tail = null;

        public BinaryListHeap()
        {
            //_elements = new List<Node>();
        }

        public void Insert(int priority, int value)
        {
            Node node = new Node(priority, value, null);
            if (_head == null)                                       // null
                _head = _tail = node; 
            else
            {
                Node max = _head;
                Node prev = _head;

                if (node.Priority > _head.Priority)                  // first
                {
                    node.Next = _head;
                    _head = node;
                }
                else
                {
                    while (max != null)                              // middle 
                    {
                        if (node.Priority > max.Priority)
                        {
                            node.Next = max;
                            prev.Next = node;
                            break;
                        }
                        prev = max;
                        max = max.Next;
                    }
                    if(max == null)                                  // last
                    {
                        _tail.Next = node;
                        _tail = node;
                    }
                }
            }
            Size++;
        }
        public int ExtractMax()
        {
            Node temp = _head;
            if(_head.Next != null)
                _head = _head.Next;
            Size--;
            return temp.Value;
        }
        public void Increase(int priority, int value)
        {
            if (_head == null)
                return;
            Node max = _head;
            Node prev = _head;
            while(max != null)
            {
                if(max.Value == value)
                {
                    max.Priority += priority;
                    Node temp = max;
                    max = max.Next;
                    prev.Next = max;
                    Insert(temp.Priority, temp.Value);
                    Size--;
                    break;
                }
                prev = max;
                max = max.Next;
            }
        }
    }
}
