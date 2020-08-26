using System;

namespace structwithcons
{
    public struct Employee
    {
        string firstname;
        int age;
        //Constructur
        public Employee(string a,int b)
        {
            firstname = a;
            age = b;
        }
        //method
        public void showemmployeedata()
        {
            Console.WriteLine("Firstname" + firstname);
            Console.WriteLine("Age" + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name and age");

            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());

            Employee CompanyEmployee = new Employee(a, b);
            CompanyEmployee.showemmployeedata();

            Console.ReadKey();
        }
    }
}
