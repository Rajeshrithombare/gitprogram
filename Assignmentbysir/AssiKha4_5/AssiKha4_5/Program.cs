using System;

namespace AssiKha4_5
{
     class Shape
    {


        public void MehodShape()
        {
            Console.WriteLine("This is Shape");
        }

    }

    class Rectangle:Shape
    {
        public void MehodRectangle()
        {
            Console.WriteLine("This is Rectangle Shap");
        }
    }

    class Square:Rectangle
    {
        public void MethodSquare()
        {
            Console.WriteLine("Square is a rectangle shap");
        }
    }
    class Circul:Shape
    {
        public void MehodCircul()
        {
            Console.WriteLine("This is Circul");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.MehodShape();
            sq.MehodRectangle();

            Console.ReadKey();
        }
    }
}
