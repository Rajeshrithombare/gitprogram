using System;

namespace Structure
{
    public struct Student
    {
        public string name;
        public int age;

        public Student(string a,int b)
        {
            name = a;
            age = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
              Student classstudent = new Student();  

             Console.WriteLine("Enter the name of student");
             string name = Console.ReadLine();

             Console.WriteLine("Enter the age of student");
             int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name = " + classstudent.name);
                Console.WriteLine("Age = " + classstudent.age);


                Console.ReadKey();

           
        }
    }
}
