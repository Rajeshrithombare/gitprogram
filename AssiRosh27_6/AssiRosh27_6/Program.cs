using System;

namespace AssiRosh27_6
{
    class Program
    {
        //number divide by 7 and remender 2 or 3
        static void Main(string[] args)
        {
            int n1, n2;
            //int sum = 0;
            Console.WriteLine("Enter the number");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            while (n1 < n2)
            {
                if (n1 % 7 == 2)
                {                  
                    Console.WriteLine("number is= " + n1);
                }
                else if(n1 % 7==3)
                {  
                    Console.WriteLine("number is= " + n1);
                }
                n1++;
            }
            Console.ReadKey();
        }
    }
}
