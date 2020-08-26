using System;

namespace AssiKha4
{

    class Rectangle
    {
        public float Lenght { get; set; }
        public float Bredth { get; set; }

        public Rectangle()
        {

        }


        public Rectangle(float lenght, float bredth)
        {
            Lenght = lenght;
            Bredth = bredth;
        }
        public void Area()
        {
            float Area = Lenght * Bredth;
            Console.WriteLine(Area);
        }
        public void Parameter()
        {
            float Parameter = Lenght + Bredth;
            Console.WriteLine(Parameter);
        }
    }

        class Square:Rectangle
        {
        public float Side { get; set; }
        public Square(float S)
        {
           Side = S;
        }

        public void SquareArea()
        {
            float SqArea = Side * Side;
            Console.WriteLine(SqArea);
        }
        public void SquareParameter()
        {
            float SqPara = 4 * Side;
            Console.WriteLine(SqPara);
        }
        
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle();

                float le, bre;
                Console.WriteLine("Enter the Lenght");
                le = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bredth");
                bre = float.Parse(Console.ReadLine());

                re.Area();
                re.Parameter();
            Square[] sq = new Square[10];
            for (int i = 0; i < 10; i++)
            {
   
               
                Console.WriteLine("Enter the Side");
               float s=float.Parse(Console.ReadLine());
               
                sq[i] = new Square(s);
                sq[i].SquareArea();
                sq[i].SquareParameter();

            }
            Console.ReadKey();
        }
    }
}
