using System;

namespace AssiEmployee12
{
    //12 Employee Salary
    class Employee
    {
        public int Salary { get; set; }
        public int NoOfHors { get; set;}

        
        public int Add { get; set; }
        

        public void getinfo(int salary,int noofhr)
        {
            Salary = salary;
            NoOfHors = noofhr;


        }

        public void Addsal()
        {
            if(Salary<500)
            {
                Add = Salary + 10;
                Console.WriteLine("salary is= " + Add);
            }
        }
        public void Addwork()
        {
            if (NoOfHors > 6)
            {
                Add = Salary + 5;
                Console.WriteLine("salary is= " + Add);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Console.WriteLine("Entre the Salary");
            int sal = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre Number of Hours");
            int hr = int.Parse(Console.ReadLine());
            em.getinfo(sal,hr);
            em.Addsal();
            em.Addwork();
            Console.ReadKey();

        }
    }
}
