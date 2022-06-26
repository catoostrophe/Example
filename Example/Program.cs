using System;

namespace Example
{
    internal class Program
    {
        public static int live_function()
        {
            int a = 3;
            int b = 4;
            int deadVariable = 10;
            int c = a + b;
            return c;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(live_function());
        }
    }
}