using System;

namespace PolyMethodOverriding
{
    class Figure
    {
        public virtual void Drow()
        {
            Console.WriteLine("the codding of figure class drow mwethod");
        }

    }
    class Rectangle:Figure
    {
        public override void Drow()
        {
            Console.WriteLine("the coding of Rectangle class drow method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure re = new Rectangle();
            re.Drow();
            Console.ReadKey();
            
        }
    }
}
