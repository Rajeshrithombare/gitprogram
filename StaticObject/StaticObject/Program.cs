using System;

namespace StaticObject
{
  public  class Student
    {
      public string name;
        public  int marks;
        public  int decr = 80;

        public void decrismark(string n,int decr)
        {
            name = n;
            marks = marks - decr;
            Console.WriteLine("Student name is{0} {1}", name, marks);
        }

        public void Incrsmark(string n, int decr)
        {
            name = n;
            marks = marks + decr;
            Console.WriteLine("Student marks is{0} {1}", name, marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ob = new Student();
            Console.WriteLine("Enter student name and marks");
            string n = Console.ReadLine();
            //Student.naya = 100;
            ob.decrismark("rashi",44);
            int ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Student marks is");
            string t = Console.ReadLine();

            switch(t)
            {
                case "decreassMarks":
                    ob.decrismark(n, ma);
                    Console.WriteLine(n, ma);
                    break;
                case "IncreeassMarks":
                    ob.Incrsmark(n, ma);
                    break;
                default:
                    Console.WriteLine("Invalid marks");
                    break;
            }
            Console.ReadKey();
        }
    }
}
