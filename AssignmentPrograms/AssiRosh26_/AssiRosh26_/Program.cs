using System;

namespace AssiRosh26_7
{
    class Program
    {
        //sum of all positive number between any 5 num and avrage
        static void Main(string[] args)
        {
            int cnt = 0;
            float avg;
            int sum = 0;
            Console.WriteLine("Enter the 5 number");
            int[] num = new int[5];
            for(int i=0;i<5;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                if(num[i]>0)
                {
                    cnt++;
                    sum = sum + num[i];
                }
               
               

            }
            avg = sum / cnt;
            Console.WriteLine("avrage is= " +avg);
            Console.WriteLine("sum is= " + sum);
            
            Console.ReadKey();
        }
    }
}
