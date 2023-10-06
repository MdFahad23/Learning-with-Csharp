using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statick_Constructor
{

    class Person
    {
        public static string Name;
        public static int Age;

        static Person(){
            Name = "Akil";
            Age = 22;
            Console.WriteLine("Statick Constructor Invoked!!");
        }

        public Person()
        {
            Console.WriteLine("Default Consturctor Invoked!!");
        }

        public static void getDetails()
        {
            Console.WriteLine("Person Name: {0}", Name);
            Console.WriteLine("Person Age: {0}", Age);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person pe = new Person();

            Console.ReadLine();
        }
    }
}
