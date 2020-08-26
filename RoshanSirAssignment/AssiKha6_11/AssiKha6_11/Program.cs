using System;

namespace AssiKha6_11
{

    class Program
    {
        static void Main(string[] args)
        {
            double Inch1, Inch2, Feet1, Feet2;
            double result1, result2;

            Console.WriteLine("Enter the first Distance");
            Console.WriteLine("Enter the feet");
            Feet1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Inch");
            Inch1 = double.Parse(Console.ReadLine());     //11.Enter Feet And Ince 

            Console.WriteLine("Enter the Second Distance");
            Console.WriteLine("Enter the Feet");
            Feet2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Inch");
            Inch2 = double.Parse(Console.ReadLine());

            result1 = Feet1 + Feet2;
            result2 = Inch1 + Inch2;

            Console.WriteLine("Inch of Distance One is= " + result1);
            Console.WriteLine("Feet of Distance One is= " + result2);
            
            Console.ReadKey();

        }
    }
}
