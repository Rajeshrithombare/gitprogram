using System;

namespace AssiRosh4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum=0, r;
           
            Console.WriteLine("Enter positive Number");
            num = int.Parse(Console.ReadLine());
             if(num<=3)
                {
                    r = num % 10;
                    num = num / 10;
                    sum = sum + r;
                    
                Console.WriteLine("sum of Number is" +sum);
            }
                
         
            Console.ReadKey();
        }
    }
}
