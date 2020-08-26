using System;

namespace CopyConstructor
{
   public  class student
    {
        public int Age;
        public string name;
      
        public student(string n,int age)
        {
            name = n;
            Age = age;
        }
        public student(student pv)
        {
            name = pv.name;
            Age = pv.Age;
        }
        public void  showdata()
        {
            Console.WriteLine("Name is= " + name + "Age is= " + Age);
        }
        public void showdata1()
        {
            Console.WriteLine("Name is= " + name + "Age is= " + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student Age");
            int Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("name is " + name);
            Console.WriteLine("Age is " + Age);

            student ob = new student("ravi ", 30);
            ob.showdata();

           student ob2 = new student(ob);

            ob.Age = 70;
            ob.name = "rashi";

            ob.showdata1();


            Console.ReadKey();


            
        }
    }
}
