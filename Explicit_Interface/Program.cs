using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }

    class MyClass : I1, I2
    {
        //void I1.show()
        //{
        //    Console.WriteLine("This is method of explicit interface 1");
        //}

        //Implicitive Interface Method
        public void show()
        {
            Console.WriteLine("This is method of explicit interface 1");
        }

        //Explicit Interface
        void I2.show()
        {
            Console.WriteLine("This is method of explicit interface 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.show();
            ((I2)obj).show();

            //MyClass obj = new MyClass();
            //((I1)obj).show();
            //((I2)obj).show();

            //I1 obj = new MyClass();
            //obj.show();

            //I2 obj2 = new MyClass();
            //obj2.show();


            Console.ReadLine();
        }
    }
}
