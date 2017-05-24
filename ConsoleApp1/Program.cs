using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                var intNumbers = input.Split(' ').Select(int.Parse).ToList();
                var stackNumbers = new Stack<int>();
                intNumbers.ForEach(n => stackNumbers.Push(n));
                foreach (var stackNumber in stackNumbers)
                {
                    Console.Write(stackNumber + " ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(input);
            }
        }
    }
}
