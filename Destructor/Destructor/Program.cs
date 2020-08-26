using System;

namespace Destructor
{
    class car
    {
        public car()
        {
            Console.WriteLine("Constructor called");
        }
        ~car()
        {
            Console.WriteLine("destructor is called");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();

            Console.ReadKey();
           
        }
    }
}
