using System;

namespace AssignRosh25_1
{
    class Program
    {
        static void Main(string[] args)
        {
           


            float av;
            int dis;
            float fule;

            Console.WriteLine("Enter the Distence user want to go");
            dis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fule you use");
            fule = Convert.ToInt32(Console.ReadLine());

             float res=dis + fule;
             av = res / 2;

            Console.WriteLine("Avrage is=" + av);

            Console.ReadKey();
        }

    }
}
