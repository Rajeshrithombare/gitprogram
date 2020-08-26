using System;

namespace AssiKha4_5Arearecta
{

    class Area
    {
        public float Lenghth { get; set; }
        public float Breadht { get; set; }
        public float Areav { get; set; }

        public void SetDim(float lenght,float breadth)
        {
            Lenghth = lenght;
            Breadht = breadth;
        }
        public string GetArea()
        {

            
            Areav = Lenghth * Breadht;
            Console.WriteLine("Area is " + Areav);
            return "Area is= " + Areav;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area ar = new Area();
            float le, br, are;
            Console.WriteLine("Enter Lenghth");
            le = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            br = float.Parse(Console.ReadLine());

            are = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is" + are);
            
            ar.GetArea();
            Console.ReadKey();
        }
    }
}
