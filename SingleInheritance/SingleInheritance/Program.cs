using System;

namespace SingleInheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set;}
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set;}
        public string EmployeeDesignation { get; set;}
        public double EmployeeSalory { get; set;}

        public void GetEemployeeData(int employeenumber,string employeename,string employeeaddress,string designation,double salory)
        {
            EmployeeNumber = employeenumber;
            Name = employeename;
            Address = employeeaddress;
            EmployeeDesignation = designation;
            EmployeeSalory = salory;
        }
        public void ShowEmployeeData()
        {
            Console.WriteLine("Employee detail are:");
            Console.WriteLine("Employee Name is:=" + Name);
            Console.WriteLine("Employee Address is:=" + Address);
            Console.WriteLine("Employee Number is:=" + EmployeeNumber);
            Console.WriteLine("Employee Designation is:=" + EmployeeDesignation);
            Console.WriteLine("Employee salory is:=" + EmployeeSalory);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Empaddress, Empdesignation;
            int EmpNumber;
            double Empsalory;

            Employee emp = new Employee();

            Console.WriteLine("Enter employee number");
            EmpNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee Name");
            Name =Console.ReadLine();

            Console.WriteLine("Enter employee Address");
            Empaddress = Console.ReadLine();

            Console.WriteLine("Enter employee designation");
            Empdesignation = Console.ReadLine();

            Console.WriteLine("Enter employee salory");
            Empsalory =double.Parse(Console.ReadLine());

            emp.GetEemployeeData(EmpNumber, Name, Empaddress, Empdesignation, Empsalory);
            emp.ShowEmployeeData();

            Console.ReadKey();
        }
    }
}
