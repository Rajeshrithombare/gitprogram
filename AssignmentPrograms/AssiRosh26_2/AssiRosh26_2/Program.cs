using System;

namespace AssiRosh26_2
{
    class Program
    {
        //sum of odd number between 1to 5
        static void Main(string[] args)
        {
            int [] num=new int[5];
            int  odd=0;
            Console.WriteLine("Enter the number");

            for (int i = 0; i <= 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                
                if (num[i] % 2 != 0)
                {
                    odd = odd + num[i];
                    Console.WriteLine("odd sum is= " + odd);

                }
                else
                {
                    Console.WriteLine("it is an even number");
                }
                
            }
            

            Console.ReadKey();
                
            
        }
    }
}
