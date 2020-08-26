using System;

namespace AssigRosh26_9
{
    //positive negative
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int pos = 0, nig = 0;
            Console.WriteLine("Enter the 5 number");
            for(int i=0;i<5;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < 5;i++)
            {
                if(num[i]>0)
                {
                    Console.WriteLine("Number is positive= "+num[i]);
                    pos++;
                }
                else if(num[i]<0)
                {
                    Console.WriteLine("number is negative= "+num[i]);
                    nig++;
                }

            }
            //Console.WriteLine("number= " + num);
            Console.ReadKey();
        }
    }
}
