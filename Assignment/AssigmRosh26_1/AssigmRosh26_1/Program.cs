using System;

namespace AssigmRosh26_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if(num<10)
            {
                Console.WriteLine("This number comes under the 1 to 10 range");
            }
            else if(num<30 && num>10)
            {
                Console.WriteLine("This number comes under the 11 to 30 range");
            }
            else if (num < 40 && num>30)
            {
                Console.WriteLine("This number comes under the 30 to 40 range");
            }
            else if (num < 50 && num>40)
            {
                Console.WriteLine("This number comes under the 41 to 50 range");
            } 
            else if (num < 60 && num>50)
            {
                Console.WriteLine("This number comes under the 51 to 60 range");
            }
            else if (num < 70 && num>60)
            {
                Console.WriteLine("This number comes under the 61 to 70 range");
            }
            else if (num < 80 && num>70)
            {
                Console.WriteLine("This number comes under the 71 to 80 range");
            }
            else
            {
                Console.WriteLine("Number is nigative or invalid");
            }
            Console.ReadKey();
        }
    }
}
