using System;

namespace Array21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter the marks of subject");
                marks[i] = int.Parse(Console.ReadLine());

            }
            int total = 0;
           foreach(int m in marks)
            {
                total = total + m;
                Console.WriteLine("marks = " +m);

            }
            Console.WriteLine("total " + total);
            float per = (float)total / 500.0f * 100.0f;
            Console.WriteLine("persentage= " + per);
           
            if(per>85)
            {
                Console.WriteLine("Pass in first divission");
            }
             else if(per>75)
            {
                Console.WriteLine("pass in Second division");
            }
            else if(per>65)
            {
                Console.WriteLine("pass in therd divission");
            }
            else if(per>55)
            {
                Console.WriteLine("pass in forth divition");
            }
            else
            {
                Console.WriteLine("You are fail");
            }
            Console.ReadKey();

        }
    }
}
