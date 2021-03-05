using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class BinaryHeap : IEnumerable<BinaryHeap.Node>
    {
        public struct Node
        {
            public int Priority { get; set; }
            public object Value { get; set; }

            public Node(int priority, object value)
            {
                Priority = priority;
                Value = value;
            }
        }

        private Node[] _elements;

        public BinaryHeap()
        {
        }

        public int Size
        {
            get
            {
                return _elements.Length;
            }
        }

        public void Insert(object value, int priority)
        {
            if (_elements == null)
                _elements = new Node[] { new Node(priority, value) };
            else
            {
                Node[] newElements = new Node[_elements.Length + 1];
                _elements.CopyTo(newElements, 0);
                newElements[newElements.Length - 1] = new Node(priority, value);
                _elements = newElements;
            }

            Up(_elements.Length - 1);
        }
        public object ExtractMax()
        {
            object result = _elements[0].Value;
            _elements[0] = _elements[_elements.Length - 1];
            DeleteLast();

            if (!IsEmpty())
            {
                Down(0);
            }

            return result;
        }

        public void Increase(object value, int priority)
        {
            Node temp;
            for (int i = 0; i < _elements.Length; i++)
            {
                if(_elements[i].Value == value)
                {
                    temp = _elements[i];
                    temp.Priority += priority;
                    Up(temp.Priority);
                    break;
                }
            }
        }

        public void Clear()
        {
            _elements = new Node[0];
        }

        #region Private Methods
        private void Down(int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int largest = i;
            if (left < _elements.Length && _elements[left].Priority > _elements[i].Priority)
            {
                largest = left;
            }
            if (right < _elements.Length && _elements[right].Priority >= _elements[largest].Priority)
            {
                largest = right;
            }
            if (largest != i)
            {
                Swap(i, largest);
                Down(largest);
            }
        }

        private void Swap(int index1, int index2)
        {
            Node temp = _elements[index1];
            _elements[index1] = _elements[index2];
            _elements[index2] = temp;
        }

        private void Up(int i)
        {
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (_elements[i].Priority < _elements[parent].Priority)
                    return;
                Swap(i, parent);
                i = parent;
            }
        }
        private bool IsEmpty()
        {
            return _elements.Length == 0;
        }
        private void DeleteLast()
        {
            if (_elements.Length > 1)
            {
                Node[] newElements = new Node[_elements.Length - 1];
                Array.Copy(_elements, 0, newElements, 0, _elements.Length - 1);
                _elements = newElements;
            }
            else
            {
                _elements = new Node[0];
            }
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return ((IEnumerable<Node>)_elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        #endregion
    }
}
