using System;

namespace AssiAbsract3
{
    //Abstract3
    public abstract class Marks
    {
        public abstract void getPercentage();
    }
    public class StudentA
    {

        public float Total = 0;
        public float Per { get; set;}
        public StudentA(int S1,int S2,int S3)
        {
            
            Total = S1 + S2 + S3;
             Per = Total / 300;

            
        }
        public void getPercentage()
        {
            Console.WriteLine("Persentage is=:" + Per);
        }
    }
    public class StudentB
    {
        public float total { get; set;}
        public float per { get; set;}
        public StudentB(int s1,int s2,int s3,int s4)
        {
             total = s1 + s2 + s3 + s4;
            per = total / 400;
        }
        public void getPercentage()
        {
           
            Console.WriteLine("Persentage is=:" + per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentA A = new StudentA(50,90,78);
            A.getPercentage();
            StudentB B = new StudentB(78, 65, 35,90);
            B.getPercentage();
            Console.ReadKey();
        }
    }
}
