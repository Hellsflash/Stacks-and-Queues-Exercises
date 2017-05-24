using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 1; i <= number; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var mode = input[0];

                switch (mode)
                {
                    case 1:
                        var num = input[1];
                        stack.Push(num);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.Max());
                        break;

                }
              
            }

        }
    }
}
