using System.Buffers;
using Functions;

namespace Calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Operators.Root(1000000, 5));
            Console.WriteLine(Operators.Root(81, 4));
        }
    }
}