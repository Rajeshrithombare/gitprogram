using System;

namespace AssiRosh27_1
{
    //two number is pair is in assending order or dissendin
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if(n1<=n2)
            {
                Console.WriteLine("Number is in accending order");
            }
            else if(n1>=n2)
            {
                Console.WriteLine("Number is in deccending order");
            }
            else
            {
                Console.WriteLine("Number is equal");
            }
            Console.ReadKey();
            
        }
    }
}
