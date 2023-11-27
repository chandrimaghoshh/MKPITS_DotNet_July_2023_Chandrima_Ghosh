using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_LinkedList_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            
            nums.AddLast(5);
            nums.AddLast(6);
            nums.AddLast(7);
            nums.AddLast(8);
            nums.AddFirst(1);
            nums.AddFirst(2);
            nums.AddFirst(3);
            nums.AddFirst(4);

            LinkedListNode<int> node = nums.Find(7);
            nums.AddBefore(node, 6);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
