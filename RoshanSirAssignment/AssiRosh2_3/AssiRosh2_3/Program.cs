using System;

namespace AssigKhsir2_1
{
    //Create class student 
    class Student { 
           
        public int roll_no { get; set;}
        public string Phone_no { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetStudentData(int Roll_no,string phone_no,string name,string address)
        {
           
            roll_no = Roll_no;
            Phone_no = phone_no;
            Name = name;
            Address = address;
        }
        public void ShowStudentData()
        {
            Console.WriteLine("first Student Detail");
            Console.WriteLine("Student RollNumber= " + roll_no);
            Console.WriteLine("Student PhoneNumber= " + Phone_no);
            Console.WriteLine("Student Name= " + Name);
            Console.WriteLine("Student Adress= " + Address);
        }
        public void GetStudentData1(int Roll_no, string phone_no,string name, string address)
        {
            roll_no = Roll_no;
            Phone_no = phone_no;
            Name = name;
            Address = address;
        }
        public void ShowStudentData1()
        {
            Console.WriteLine("Second Student Detail");
            Console.WriteLine("Student RollNumber= " + roll_no);
            Console.WriteLine("Student PhoneNumber= " + Phone_no);
            Console.WriteLine("Student Name= " + Name);
            Console.WriteLine("Student Adress= " + Address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Roll_no;
            string phoneno;
            string nam;
            string addre;
            Student std = new Student();
            Console.WriteLine("Enter Student Roll_no");
            Roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Phone Number");
            phoneno=Console.ReadLine();
            Console.WriteLine("Enter the Student Name");
            nam = Console.ReadLine();
            Console.WriteLine("Enter the Student Address");
            addre = Console.ReadLine();
           std.GetStudentData(Roll_no,phoneno,nam,addre);
            std.ShowStudentData();

            int roll_no;
            string phone_no;
            string names;
            string addres;


            Student std2 = new Student();
            Console.WriteLine("Enter studentm Detail");
            Console.WriteLine("Enter Student Roll_no");
            roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Phone Number");
            phone_no = Console.ReadLine();
            Console.WriteLine("Enter the Student Name");
            names = Console.ReadLine();
            Console.WriteLine("Enter the Student Address");
            addres = Console.ReadLine();
            std2.GetStudentData1(roll_no, phone_no, names, addres);
            std2.ShowStudentData1();
            
            
            Console.ReadKey();
        }
    }
}
