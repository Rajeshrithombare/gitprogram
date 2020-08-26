using System;

namespace AssiKha4_AreaofRectangle
{

    class Rectangle
    {
        public float Area { get; set;}
        public float Lenght { get; set;}
        public float Breadth { get; set;}

        public Rectangle(float lenght,float breadth)
        {
            Lenght = lenght;
            Breadth = breadth;
        }
        public string Area1()
        {
            Area = Lenght * Breadth;
            Console.WriteLine("Lenght is=  "+ Lenght +   "Breadth is=  "+Breadth);
            Console.WriteLine("Area is= " + Area);
            return "Area " + Area + "is Lenght is " + Lenght + "Breadth is" + Breadth + "";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle re = new Rectangle(4,8);
            re.Area1();
            Console.ReadKey();
        }
    }
}
