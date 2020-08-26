using System;

namespace AssiKha3_4
{
    class Trangle
    {
        public int side1;
        public int side2;
        public int side3;

        public Trangle()
        {
            
                Console.WriteLine("Area of trangle");

                Console.WriteLine("Enter side One");
                side1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter side two");
                side2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter side three");
                side3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Area of Parameter");

                float parameter = side1 + side2 + side3;
                Console.WriteLine("parameter is= " + parameter);
        }

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Trangle tra = new Trangle();
            Console.ReadKey();
        }
    }
}
