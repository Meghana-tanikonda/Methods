using System;
namespace MyNamespace
{
    class MyClass
    {
        static void add(int x, int y)//static method adding two numbers
        {
            int z = x + y;
            Console.WriteLine($"Adding two numbers is {z}");
        }
        static void Main()
        {
            add(2, 3);
        }
    }
}


