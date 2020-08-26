using System;

namespace AssiRoshArithmeticSeriz3_1
{
    class Program
    {//4
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Arithmatic seriz");
            int j =int.Parse(Console.ReadLine());

            for(int i=1;i<=j;i++)
            {
                int Num = i * i*i;

                Console.WriteLine("the range is" + Num);
            }


            Console.ReadKey();
        }
    }
}
