using System;

namespace ConsoleApp2
{

    class Token
    {
        protected Token(string name)
        {
            Console.WriteLine("Base class Constructor= " + name);
        }
    }

    class CommentToken:Token
    {
        public CommentToken(string name):base(name)
        {
            Console.WriteLine("derived class " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CommentToken ct = new CommentToken("mk"); 

            Console.ReadKey();
        }
    }
}
