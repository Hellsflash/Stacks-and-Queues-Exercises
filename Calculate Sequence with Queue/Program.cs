using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = int.Parse(Console.ReadLine());

            Sequance(input, 50);


        }

        public static void Sequance(int start, int seqLength)
        {
            var Queue = new Queue<int>();

            Queue.Enqueue(start);

            Console.Write(start);

            for (int i = 0; i < seqLength - 1; i++)
            {
                int print = 0;
                if (i % 3 == 0 && i != 0)
                {
                    Queue.Dequeue();
                }

                if (i % 3 == 0)
                {
                    print = Queue.Peek() + 1;
                    Queue.Enqueue(print);
                }
                else if (i % 3 == 1)
                {
                    print = Queue.Peek() *2 + 1;
                    Queue.Enqueue(print);
                }
               else if (i % 3 == 2)
                {
                    print = Queue.Peek() + 2;
                    Queue.Enqueue(print);
                }

                Console.Write(" "+ print);
            }
            Console.WriteLine();
        }
    }
}
