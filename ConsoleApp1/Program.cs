using Logic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class1();
            c.Calc("2+2*2");
            var d = c.Calc("2+2*2");
            Console.WriteLine($"2+2*2 = {d}");
        }
    }
}
