using System;

namespace AssiRosh5_2
{
    //revers three Number
    class Program
    {
        static void Main(string[] args)
        {
            int rev=0, r, num;
            Console.WriteLine("Enter three digit Number");
            num = int.Parse(Console.ReadLine());
             while(num>0)
            {
                r = num % 10;
                num = num / 10;
                rev = rev * 10 + r;
                
            }
            Console.WriteLine("Revers Number is= "+rev);

            Console.ReadKey();
        }
    }
}
