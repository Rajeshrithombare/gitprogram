using System;

namespace Enternumadshowinword
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {

                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 5:
                    Console.WriteLine("Four");
                    break;

                default:
                    Console.WriteLine("Some other number");
                    break;
            }


            Console.ReadKey();

        }
    }
}
