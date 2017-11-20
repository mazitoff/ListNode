using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List(23);
            list.Add(7);
            list.Add(67);
            list.Add(3);
            list.Add(8);

            list.Print(list);
            Console.ReadKey();
        }
    }
}
