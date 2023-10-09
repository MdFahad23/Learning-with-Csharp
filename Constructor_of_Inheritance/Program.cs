using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_of_Inheritance
{
    class BaseClass
    {
        public BaseClass(string message) {
            Console.WriteLine(message);
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("This is Base Class") {
            Console.WriteLine("This is Derived Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();

            Console.ReadLine();
        }
    }
}
