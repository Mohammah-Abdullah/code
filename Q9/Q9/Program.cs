
// Write a C# programs to demonstrate the concepts of single Inheritance

using System;
namespace InheritanceApplication
{
    class a
    {
        public void display()
        {
            System.Console.WriteLine("hahahaha");
        }
    }
    class b : a //b is child of a
    {
        public void display1()
        {
            System.Console.WriteLine("hihihih");
        }
    }
    class c
    {
        public static void Main()
        {
            b x = new b();
            x.display();
            x.display1();
        }
    }
}
