using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNode
{
    class List
    {
        private ListNode _head;
        private ListNode _last;
        private int _countIndex;

        public List(int value)
        {
            _head = new ListNode
            {
                Value = value
            };
            _last = _head;
            _countIndex = 0;
        }

        public void Add(int value)
        {
            var node = new ListNode
            {
                Value = value
            };
            _last.Next = node;
            _last = node;
            node.Index = ++_countIndex;
        }

        public void Print(List list)
        {
            ListNode nextNode = list._head;
            while (nextNode != null)
            {
                Console.WriteLine(nextNode.Value + " _ " + nextNode.Index);
                nextNode = nextNode.Next;
            }
            
        }

        //public ListNode this[int index]
        //    {
        //        get
        //    {
        //        return this;
        //        //ListNode nextNode = _head;
        //        //while (nextNode != null)
        //        //{
        //        //    if (nextNode.Index = index)
        //        //    {
        //        //        return nextNode;
        //        //    }
        //        //}
        //    }
        //    }

    }
}
