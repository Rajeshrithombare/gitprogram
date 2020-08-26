using System;
//constructor with paramiter
namespace Constructwithparamitr
{
    public class person //class
    {
        private string last;//member variabl
        private string first;
        

        public person(string lastname,string firstname)//constructor
        {
            last = lastname;
            first = firstname;
        }
        public void showdata()//method
        {
            Console.WriteLine("first= " + first);
            Console.WriteLine("last= " + last);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person ob = new person("kumar","rajesh");
            ob.showdata();

            Console.ReadKey();

        }
    }
}
