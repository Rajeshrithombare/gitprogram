using System;

namespace AssiAbstract6
{//Abstract7
    public abstract class Shape
    {
        public abstract void RectangleArea(int lenght,int bredth);
        public abstract void SquareArea(int side);
        public abstract void CircleArea(int redius);
    }
    class Area
    {
        public float Lenght { get; set;}
        public float Bredth { get; set;}
        public float Rectangle { get; set;}
        public float Side { get; set;}
        public float Square { get; set;}
        public float Redius { get; set;}
        public float Circle { get; set;}
        public void RectangleArea()
        {
            
            Rectangle = Lenght * Bredth;
            Console.WriteLine("Area of Rectangle is:= " +Rectangle);
        }
        public void SquareArea()
        {
            Square = Side * Side;
            Console.WriteLine("Square is= " +Square);
        }
        public void CircleArea()
        {
            Circle = 2 * (Redius * Redius);
            Console.WriteLine("Circle Area is= " +Circle);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area[] A = new Area[5];
            for(int i=0;i<4;i++)
            {
                A[i]=new Area();
                Console.WriteLine("Enter the Lenghth");
                float len= float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Bredth");
                float bre = float.Parse(Console.ReadLine());
                A[i].RectangleArea();
            }
            for(int j=0;j<4;j++)
            {
                A[j] = new Area();
                Console.WriteLine("Enter the Side");
                float sid = float.Parse(Console.ReadLine());
                A[j].SquareArea();
            }
            for(int k=0;k<5;k++)
            {
                A[k] = new Area();
                Console.WriteLine("Enter the Redius");
                float red = float.Parse(Console.ReadLine());
                A[k].CircleArea();
            }
            
            Console.ReadKey();
        }
    }
}
