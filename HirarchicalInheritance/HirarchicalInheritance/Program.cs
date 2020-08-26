using System;

namespace HirarchicalInheritance
{
    public class Person
    {
        public String EmpName { get; set; }
        public String EmpAddress { get; set; }
    }
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeDesignation { get; set; }
        public double EmployeeSalory { get; set; }

        public void GetEmployeeDetail(int empnumber, string empname, string empaddress, double empsalory, string empdesignation)
        {
            EmpName = empname;
            EmpAddress = empaddress;
            EmployeeNumber = empnumber;
            EmployeeDesignation = empdesignation;
            EmployeeSalory = empsalory;

        }
        public void ShowEmployeeData()
        {
            Console.WriteLine("Employee Detail are");
            Console.WriteLine("Employee Number is:= " + EmployeeNumber);
            Console.WriteLine("Employee Name is:= " + EmpName);
            Console.WriteLine("Employee Address is:= " + EmpAddress);
            Console.WriteLine("Employee Designation is:= " + EmployeeDesignation);
            Console.WriteLine("Employee Salory is:= " + EmployeeSalory);
        }
    }


 
    public class Student: Person
    {
        public String StuName { get; set; }
        public String StuAddress { get; set; }
        public int StudenteNumber { get; set; }
        public double StudentMarks { get; set; }

        public void GetStudentDetail(int stunumber, string stuname, string studdress, double stumarks)
        {
            StuName = stuname;
            StuAddress = studdress;
            StudenteNumber = stunumber;
            StudentMarks = stumarks;

        }
        public void ShowStudentData()
        {
            Console.WriteLine("Student Detail are");
            Console.WriteLine("Student Number is:= " + StuName);
            Console.WriteLine("Student Name is:= " + StuAddress);
            Console.WriteLine("Student is:= " + StudenteNumber);
            Console.WriteLine("Student Designation is:= " + StudentMarks);
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.GetEmployeeDetail(123, "rashi", "Nagpur", 79000, "manager");
            emp.ShowEmployeeData();
            Student stu = new Student();
            stu.GetStudentDetail(23, "rajjo", "Faras", 87);
            stu.ShowStudentData();
            Console.ReadKey();
        }
    }
}
