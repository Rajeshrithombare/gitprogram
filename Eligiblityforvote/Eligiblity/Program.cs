using System;

namespace Eligiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            
            Console.WriteLine("Enter the age");

             age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age " + age);

            if (age>= 18)
            {
                Console.WriteLine("Elligible for vote");
            }
            else
            {
                Console.WriteLine("Not Elligible for vote");
            }

            Console.ReadKey();
        }
    }
}
