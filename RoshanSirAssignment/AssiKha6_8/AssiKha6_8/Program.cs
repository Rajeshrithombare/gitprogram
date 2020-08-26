using System;

namespace AssiKha6_8
{
    //Avrage is
    class Avrage
    {
        public float sum { get; set;}
        public float Avra { get; set;}
        public float Number1 { get; set;}
        public float Number2 { get; set; }
        public float Number3 { get; set;}

        public void Calculate(float num1, float num2,float num3)

        {
            Number1 = num1;
            Number2=num2;
            Number3 = num3;
           
            sum = Number1 + Number2 + Number3;
            Avra = sum/3;
            Console.WriteLine("Avrage is= "+Avra);
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Avrage av = new Avrage();
            float n1, n2, n3;
            Console.WriteLine("Enter Number One");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number One");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number One");
            n3 = float.Parse(Console.ReadLine());
            av.Calculate(n1,n2,n3);
            Console.ReadKey();

        }
    }
}
