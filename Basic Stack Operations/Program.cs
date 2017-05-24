using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            

            var pushNum = input[0];
            var popNum = input[1];
            var num = input[2];

       
            
                var push = Console.ReadLine().Split(' ').Select(int.Parse);

                foreach (var item in push)
                {
                    stack.Push(item);
                }
                
            
            for (int i = 1; i <= popNum; i++)
            {   
                stack.Pop();
            }
            if (stack.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(num))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }

            }
           
            
        }
    }
}
