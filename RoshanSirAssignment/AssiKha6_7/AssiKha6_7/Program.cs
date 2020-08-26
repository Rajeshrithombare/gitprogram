using System;

namespace AssiKha6_7
{
    class Area
    {
        public float Lenghth { get; set;}
        public float Breadth { get; set;}

        public Area(float lenghth,float breadth)
        {
            Lenghth = lenghth;
            Breadth = breadth;
        }
        public string ReturnArea(float lenghth,float breadth)
        {
           float Area = Lenghth * Breadth;
            Console.WriteLine("Area is= " + Area);
            return "The Lenghth id" + Lenghth + "The Breadth is" + Breadth;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area ar = new Area(4,6);
            ar.ReturnArea(3,6);
            Console.ReadKey();
        }
    }
}
