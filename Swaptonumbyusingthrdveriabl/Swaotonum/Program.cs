using System;

namespace Swaotonum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int temp;

            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());


                    temp = n1;
                    n1 = n2;
                    n2 = temp;


            Console.WriteLine("N1= " + n1);
            Console.WriteLine("N2= " + n2);


            Console.ReadKey();
        }
    }
}
