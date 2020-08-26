using System;

namespace AssiRosh5_3Bitwise
{
    class Program
    {
        //Bitwise Oprator shift two left

        static void Main(string[] args)
        {
            int num;
            
           
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            num <<= 2;

            Console.WriteLine("number is"+num);
           
        }
    }
}
