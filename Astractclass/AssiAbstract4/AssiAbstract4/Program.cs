using System;

namespace AssiAbstract4
{//Abstract4

    public abstract class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("This is Constructor of abstract class");
        }
        public abstract void a_method();
        public  virtual void method()
        {
            Console.WriteLine("This is Normal Method of Abstract class");
        }
    }
    public class SubClass:BaseClass
    {
        public override void a_method()
        {
            Console.WriteLine("This is Abstract Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SubClass s = new SubClass();
            s.a_method();
            s.method();
            Console.ReadKey();
        }
    }
}
