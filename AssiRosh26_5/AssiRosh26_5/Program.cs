using System;

namespace AssiRosh26_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number between 1 to 12");
            num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("Janvery");
                    break;
                case 2:
                    Console.WriteLine("febru");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("Jun");
                    break;
                case 7:
                    Console.WriteLine("Jully");
                    break;
                case 8:
                    Console.WriteLine("ogust");
                    break;
                case 9:
                    Console.WriteLine("suptember");
                    break;
                case 10:
                    Console.WriteLine("octomber");
                    break;
                case 11:
                    Console.WriteLine("november");
                    break;
                case 12:
                    Console.WriteLine("dicember");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
            Console.ReadKey();
        }
    }
}
