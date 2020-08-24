using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var sum = a + b;

            Console.WriteLine($"{a}+{b} adds up to {sum}");

            var multiply = a * b;

            Console.WriteLine($"The product of {a}*{b} is {multiply}");

            var subtract = a - b;

            Console.WriteLine($"{a}-{b} comes out to {subtract}");

            var div = a/b;
            var mod = a%b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
        }
    }
}
