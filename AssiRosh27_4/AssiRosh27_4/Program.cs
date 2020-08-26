using System;

namespace AssiRosh27_4
{
    //number is divisible or not
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter two number");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n1>n2)
            {
                Console.WriteLine("Number is divisable");
            }
            else
            {
                Console.WriteLine("Number is not divisible ");
            }
            Console.ReadKey();
        }
    }
}
