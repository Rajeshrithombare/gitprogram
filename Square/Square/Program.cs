using System;

namespace Square
{
    public class squ
    {
        public int Method(int n)
        {
            int square;
            square = n * n;
            Console.WriteLine("Result is " + square);
            return square;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            squ ob = new squ();
            ob.Method(2);
            Console.ReadKey();

        }
    }
}
