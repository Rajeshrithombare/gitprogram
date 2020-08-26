using System;

namespace enternumforShowdayswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.WriteLine("Enter the Day number you wont to know");
            day = Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("tusday");
                    break;

                case 3:
                    Console.WriteLine("wesday");
                    break;

                case 4:
                    Console.WriteLine("Thusday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Satday");
                    break;

                case 7:
                    Console.WriteLine("Sunday holiyday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }


            Console.ReadKey();
        }
    }
}
