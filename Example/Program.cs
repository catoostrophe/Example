using System;

namespace Example
{
    internal class Program
    {
        public static int dead_function()
        {
            return 21;
        }

        public static int live_function()
        {
            int a = 3;
            int b = 4;
            int deadVariable = 10;
            int c = a + b + deadVariable;
            return c;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(live_function() + dead_function());
        }
    }
}