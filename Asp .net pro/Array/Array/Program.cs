using System;

namespace Array
{
    class Program
    {
        //No agrument and no returntype
        /*static void Main(string[] args)
        {
            Method();
            Console.ReadLine();
        }
        static void Method()
        {
            int[] n = new int[3];
            int[] m = new int[3];
            int[] res = new int[3];
            int i;
            Console.WriteLine("Enter first array element");
            for(i=0;i<=2;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array element");
            for(i=0;i<=2;i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<=2;i++)
            {
                res[i] = n[i] + m[i];
                Console.WriteLine("Result is=" + res[i]);
            }
            
        }*/
        //2.With argument no return type
        /*static void Main(string[] args)
        {
           
            int[] n=new int[3];
            int[] m = new int[3];
            int i;

            Console.WriteLine("Enter the first array element");
            for (i = 0; i <= 2; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array element");
            for (i = 0; i <= 2; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            Method(n,m);
            
            
            
        }
        static void Method(int [] n1,int[] n2)
        {
            int[] res = new int[3];
           
            int i;
            for (i = 0; i <= 2; i++)
            {
                res[i] = n1[i] + n2[i];
                Console.WriteLine("Result is=" + res[i]);
            }
           
        }*/
        //3.With argument and with return type
        /*static void Main(string[] args)
        {

            int[] n = new int[3];
            int[] m = new int[3];
            int[] r = new int[3];
          
            int i;

            Console.WriteLine("Enter the first array element");
            for (i = 0; i <= 2; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array element");
            for (i = 0; i <= 2; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            r = Method(m, n);
            Console.WriteLine("The addition of two array is");
            for(i=0;i<=2;i++)
            {
                Console.WriteLine(r[i]);
            }
            

        }
        static int[] Method(int[] n1,params int[] n2)
        {
            int[] res = new int[3];

            int i;
            for (i = 0; i <= 2; i++)
            {
                res[i] = n1[i] + n2[i];
                
            }
            return res;
        }*/
        //With return type no argument

        static void Main(string[] args)
        {
            int i;
            int[] r = new int[3];
            r = Method();
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(r[i]);
            }

        }
        static int[] Method()
        {
            
                int[] n = new int[3];
                int[] m = new int[3];
                int[] res = new int[3];
                int i;
                Console.WriteLine("Enter first array element");
                for (i = 0; i <= 2; i++)
                {
                    n[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter second array element");
                for (i = 0; i <= 2; i++)
                {
                    m[i] = int.Parse(Console.ReadLine());
                }
                for (i = 0; i <= 2; i++)
                {
                    res[i] = n[i] + m[i];
                   
                }
            return res;

            }
        }
}
