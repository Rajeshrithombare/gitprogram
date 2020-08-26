using System;

namespace AssiKha2_3
{
    class Trangle
    {
        public int side1 = 3;
        public int side2 = 4;
        public int side3 = 5;

        public Trangle(int s1,int s2,int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
              Console.WriteLine("Area of Trangle");

                  float area = side1 * side2 / 2;
              Console.WriteLine("Area is= " + area);
              Console.WriteLine("Area of Parameter");
                  float parameter = side1 + side2 + side3;
              Console.WriteLine("parameter is= " + parameter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Trangle t = new Trangle(3,4,5);
            Console.ReadKey();
        }
    }
}
