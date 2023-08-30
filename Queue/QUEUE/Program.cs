using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            Console.WriteLine(queue);
            queue.Insert(2);
            Console.WriteLine(queue);
            queue.Insert(3);
            Console.WriteLine(queue);
            queue.Remove();
            Console.WriteLine(queue);
            queue.Remove();
            Console.WriteLine(queue);
            queue.Remove();
            Console.WriteLine(queue);
            queue.Insert(4);
            Console.WriteLine(queue);
        }
    }
}
