using System;

namespace ArrayofobjAssi1
{//ArrayofobjectAssi1
    class Employee
    {
        public string Name { get; set;}
        public int Salary { get; set;}
        public string DateOfJoin { get; set;}

        public void EmployeeMethod()
        {
           
                  Console.WriteLine("Name of Employee= " + Name);
            Console.WriteLine("Salary of Employee= "+Salary);
                  Console.WriteLine("Date of joining= " + DateOfJoin);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] em = new Employee[10];
            for(int i=1;i<10;i++)
            {
                em[i] = new Employee();
                Console.WriteLine("Enter the Name of Employee");
                em[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                em[i].Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Date of Employee");
                em[i].DateOfJoin = Console.ReadLine();
                em[i].EmployeeMethod();
            }
            Console.ReadKey();
        }
    }
}
