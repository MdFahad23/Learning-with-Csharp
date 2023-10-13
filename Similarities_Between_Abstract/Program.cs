using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similarities_Between_Abstract
{
    interface MyInterface
    {
        void Print();
    }

    abstract class MyClass
    {
        public abstract void Print1();
    }

    class Example :  MyClass, MyInterface
    {
        public void Print()
        {
            Console.WriteLine("This is a method Interface!!");
        }

        public override void Print1()
        {
            Console.WriteLine("This is a method Abestract!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Print();
            example.Print1();

            Console.ReadLine();
        }
    }
}
