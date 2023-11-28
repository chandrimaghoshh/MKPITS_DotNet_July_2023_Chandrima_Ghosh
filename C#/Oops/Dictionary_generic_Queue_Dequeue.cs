using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_list_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("Chandrima");
            q.Enqueue("Chestu");
            q.Enqueue("Pooja");
            q.Enqueue("Kareena");
            q.Enqueue("Akash");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Peek());

            Console.WriteLine();
            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
