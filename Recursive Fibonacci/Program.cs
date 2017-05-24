using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNthFibonacci_Ite(n));

        }
        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 1;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
    }
}
