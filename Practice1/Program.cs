using System;
using System.ComponentModel;
namespace college
{
    /* class Student
     {
         int id;
         string name;
         string branch;
         float percentage;
         static void Main(string[] args)
         {
             Student m = new Student();//classname variable_name=new classname
             Student s = new Student();

             /*s.id = 1;
             s.name = "john";
             s.branch = "cse";
             s.percentage = 98;
             m.id = 34;
             m.name = "johny";
             m.branch = "ece";
             m.percentage = 75;
             Console.WriteLine("student id "+m.id);
             Console.WriteLine(m.name);
             Console.WriteLine(m.percentage);
             Console.WriteLine(m.branch);
             Console.WriteLine(s.id);
             Console.WriteLine(s.name);
             Console.WriteLine(s.percentage);
             Console.WriteLine(s.branch);
             Console.ReadKey(); //

             Console.WriteLine("Enter student id");
             s.id = Convert.ToInt32(Console.ReadLine());
             // Console.ReadLine();
             Console.WriteLine("Enter Student name");
             s.name = Console.ReadLine();
             Console.WriteLine("Enter student percentage");
             s.percentage = (float)Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("student id is " + s.id);
             Console.WriteLine("Student name is " + s.name);
             Console.WriteLine("student percentage is "+s.percentage);
             Console.ReadLine() ; 
         }
     }*/
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


