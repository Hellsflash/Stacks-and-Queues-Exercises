using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var Queue = new Queue<int>();


            var queueNum = input[0];
            var dequNum = input[1];
            var num = input[2];



            var queue = Console.ReadLine().Split(' ').Select(int.Parse);

            foreach (var item in queue)
            {
                Queue.Enqueue(item);
            }


            for (int i = 1; i <= dequNum; i++)
            {
                Queue.Dequeue();
            }
            if (Queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (Queue.Contains(num))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(Queue.Min());
                }

            }

        }
    }
}
