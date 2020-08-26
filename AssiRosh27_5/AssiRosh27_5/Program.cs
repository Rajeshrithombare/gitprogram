using System;

namespace AssiRosh27_5
{
    class Program
    {
        //calculate sum of all number divisible by 17
        static void Main(string[] args)
        {
            int n1,n2;
            int sum = 0;

            Console.WriteLine("Enter the number");

            n1= int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            while(n1<n2)
            {

                if (n1 % 17 != 0)
                {

                    sum = sum + n1;
                    n1++;
                    
                }
               

            }
            Console.WriteLine("sum is=" + sum);

            Console.ReadKey();
        }
    }
}
