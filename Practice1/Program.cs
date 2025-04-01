using System;
using System.ComponentModel;
namespace college
{

    class Student
    {
        int x = 12;
        int y = 12;
        public int add(int a,int b)//and method with return type and with parmeters
        {
            int c = a + b;
            return c;
        }
        public void sub(int d, int e)//method with parameters(datatypes along with names), without return type
        { 
            int f = d - e;
            Console.WriteLine($"Sub of two numbers {f}");
        }
        public void mul()//method without return type and parameters
        {
            int z = x * y;
            Console.WriteLine($"Mul of two numbers {z}");
        }
        public void div()
        {
            int z = x / y;
            Console.WriteLine($"Division of two numbers is {z}");
        }
        public void mod()
        {
            int z = x % y;
            Console.WriteLine($"Modules of two numbers is {z}");
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            int h = s.add(1,2);
            s.sub(6, 2);
            s.mul();
            s.div();
            s.mod();
            Console.WriteLine($"Addition of two numbers is {h}");
            Console.ReadLine();
        }
        
      

    }
}


