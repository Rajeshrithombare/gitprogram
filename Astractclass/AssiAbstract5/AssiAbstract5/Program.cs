using System;
//Abstract5
namespace AssiAbstract5
{
    public abstract class Animals
    {
        public abstract void cats();
        public abstract void dogs();
    }
    public class Cats:Animals
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }
        public override void dogs()
        {
            Console.WriteLine("Dogs bark");
        }
    }
    public  class Dogs:Animals
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }
        public override void dogs()
        {
            Console.WriteLine("Dogs bark");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cats c = new Cats();
            c.cats();
            Dogs d = new Dogs();
            d.dogs();
        }
    }
}
